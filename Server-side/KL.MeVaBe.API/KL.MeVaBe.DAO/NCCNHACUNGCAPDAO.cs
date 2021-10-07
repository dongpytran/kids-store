//#region Using
//using System;
//using System.Data;
//using System.Collections;
//using System.Collections.Generic;
//using TGDD.Library.Data;
//using KL.MeVaBe.DAO;
//using TGDD.Library.Framework;
//#endregion

//namespace KL.MeVaBe.DAO
//{
//    /// <summary>
//	/// Created by 		: Dong Py 
//	/// Created date 	: 10/5/2021 
//	/// Quan Ly Nha Cung Cap
//	/// </summary>	
//	public class NCCNHACUNGCAPDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public NCCNHACUNGCAPDAO()
//		{
//		}
//		public NCCNHACUNGCAPDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public NCCNHACUNGCAPBO LoadInfo(string strMancc)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NCC_NHACUNGCAP_SEL");
//				objIData.AddParameter(P_Mancc, strMancc);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	NCCNHACUNGCAPBO objNCCNHACUNGCAPBO = new NCCNHACUNGCAPBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Mancc]))  objNCCNHACUNGCAPBO.Mancc = Convert.ToString(reader[C_Mancc]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Tenncc]))  objNCCNHACUNGCAPBO.Tenncc = Convert.ToString(reader[C_Tenncc]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Diachi]))  objNCCNHACUNGCAPBO.Diachi = Convert.ToString(reader[C_Diachi]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Sdt]))  objNCCNHACUNGCAPBO.Sdt = Convert.ToString(reader[C_Sdt]).Trim();
// 					objNCCNHACUNGCAPBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objNCCNHACUNGCAPBO.IsExist = false;
// 				}
//				reader.Close();
//				return objNCCNHACUNGCAPBO;
//			}
//			catch (Exception objEx)
//			{
//				throw objEx;
//			}
//			finally
//    		{
//    			if (objDataAccess == null)
//        			objIData.Disconnect();
//    		}
//		}

//		///<summary>
//		/// Insert : NCC_NHACUNGCAP
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(NCCNHACUNGCAPBO objNCCNHACUNGCAPBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NCC_NHACUNGCAP_ADD");

//				objIData.AddParameter(P_Mancc, objNCCNHACUNGCAPBO.Mancc);
//				objIData.AddParameter(P_Tenncc, objNCCNHACUNGCAPBO.Tenncc);
//				objIData.AddParameter(P_Diachi, objNCCNHACUNGCAPBO.Diachi);
//				objIData.AddParameter(P_Sdt, objNCCNHACUNGCAPBO.Sdt);
//              	objIData.ExecNonQuery();
//				return true;
//			}
//			catch (Exception objEx)
//			{
//				throw objEx;
//			}
//			finally
//    		{
//    			if (objDataAccess == null)
//        			objIData.Disconnect();
//    		}
//		}

//		///<summary>
//		/// Update : NCC_NHACUNGCAP
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(NCCNHACUNGCAPBO objNCCNHACUNGCAPBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NCC_NHACUNGCAP_UPD");
//				objIData.AddParameter(P_Mancc, objNCCNHACUNGCAPBO.Mancc);
//				objIData.AddParameter(P_Tenncc, objNCCNHACUNGCAPBO.Tenncc);
//				objIData.AddParameter(P_Diachi, objNCCNHACUNGCAPBO.Diachi);
//				objIData.AddParameter(P_Sdt, objNCCNHACUNGCAPBO.Sdt);
//                objIData.ExecNonQuery();
//                return true;
//			}
//			catch (Exception objEx)
//			{
//				throw objEx;
//			}
//			finally
//    		{
//    			if (objDataAccess == null)
//        			objIData.Disconnect();
//    		}
//		}

//		///<summary>
//		/// Delete : NCC_NHACUNGCAP
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(NCCNHACUNGCAPBO objNCCNHACUNGCAPBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NCC_NHACUNGCAP_DEL");
//				objIData.AddParameter(P_Mancc, objNCCNHACUNGCAPBO.Mancc);
// 				objIData.ExecNonQuery();
//              return true;
//			}
//			catch (Exception objEx)
//			{
//				throw objEx;
//			}
//			finally
//    		{
//    			if (objDataAccess == null)
//        			objIData.Disconnect();
//    		}
//		}

//		///<summary>
//		/// SearchData : NCC_NHACUNGCAP
//		/// Nap dữ liệu
//		///</summary>
//		public DataTable SearchData(params object[] objKeywords)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NCC_NHACUNGCAP_SRH");
//				objIData.AddParameter(objKeywords);
// 				return objIData.ExecStoreToDataTable();
//			}
//			catch (Exception objEx)
//			{
//				throw objEx;
//			}
//			finally
//    		{
//    			if (objDataAccess == null)
//        			objIData.Disconnect();
//    		}
//		}
		
//		#endregion
		
//		#region Variable Static

//		#region Parameter Names

//		public const String P_Mancc = "@" + C_Mancc;
//		public const String P_Tenncc = "@" + C_Tenncc;
//		public const String P_Diachi = "@" + C_Diachi;
//		public const String P_Sdt = "@" + C_Sdt;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Mancc = "Mancc";
//		public const String C_Tenncc = "Tenncc";
//		public const String C_Diachi = "Diachi";
//		public const String C_Sdt = "Sdt";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
