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
//	/// Quan Ly Ds San Pham Giam Gia Theo Dot
//	/// </summary>	
//	public class SPDANHSACHSPGIAMDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public SPDANHSACHSPGIAMDAO()
//		{
//		}
//		public SPDANHSACHSPGIAMDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public SPDANHSACHSPGIAMBO LoadInfo(string strMasp, string strMasukien)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_DANHSACHSPGIAM_SEL");
//				objIData.AddParameter(P_Masp, strMasp);
//				objIData.AddParameter(P_Masukien, strMasukien);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	SPDANHSACHSPGIAMBO objSPDANHSACHSPGIAMBO = new SPDANHSACHSPGIAMBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Masukien]))  objSPDANHSACHSPGIAMBO.Masukien = Convert.ToString(reader[C_Masukien]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Masp]))  objSPDANHSACHSPGIAMBO.Masp = Convert.ToString(reader[C_Masp]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Giatrigiam]))  objSPDANHSACHSPGIAMBO.Giatrigiam = Convert.ToInt32(reader[C_Giatrigiam]);
// 					objSPDANHSACHSPGIAMBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objSPDANHSACHSPGIAMBO.IsExist = false;
// 				}
//				reader.Close();
//				return objSPDANHSACHSPGIAMBO;
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
//		/// Insert : SP_DANHSACHSPGIAM
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(SPDANHSACHSPGIAMBO objSPDANHSACHSPGIAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_DANHSACHSPGIAM_ADD");

//				objIData.AddParameter(P_Masukien, objSPDANHSACHSPGIAMBO.Masukien);
//				objIData.AddParameter(P_Masp, objSPDANHSACHSPGIAMBO.Masp);
//				objIData.AddParameter(P_Giatrigiam, objSPDANHSACHSPGIAMBO.Giatrigiam);
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
//		/// Update : SP_DANHSACHSPGIAM
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(SPDANHSACHSPGIAMBO objSPDANHSACHSPGIAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_DANHSACHSPGIAM_UPD");
//				objIData.AddParameter(P_Masukien, objSPDANHSACHSPGIAMBO.Masukien);
//				objIData.AddParameter(P_Masp, objSPDANHSACHSPGIAMBO.Masp);
//				objIData.AddParameter(P_Giatrigiam, objSPDANHSACHSPGIAMBO.Giatrigiam);
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
//		/// Delete : SP_DANHSACHSPGIAM
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(SPDANHSACHSPGIAMBO objSPDANHSACHSPGIAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_DANHSACHSPGIAM_DEL");
//				objIData.AddParameter(P_Masukien, objSPDANHSACHSPGIAMBO.Masukien);
//				objIData.AddParameter(P_Masp, objSPDANHSACHSPGIAMBO.Masp);
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
//		/// SearchData : SP_DANHSACHSPGIAM
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
//				objIData.CreateNewStoredProcedure("SP_DANHSACHSPGIAM_SRH");
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

//		public const String P_Masukien = "@" + C_Masukien;
//		public const String P_Masp = "@" + C_Masp;
//		public const String P_Giatrigiam = "@" + C_Giatrigiam;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Masukien = "Masukien";
//		public const String C_Masp = "Masp";
//		public const String C_Giatrigiam = "Giatrigiam";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
