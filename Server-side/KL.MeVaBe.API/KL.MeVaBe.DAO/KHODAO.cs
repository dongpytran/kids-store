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
//	/// Quan Ly Kho
//	/// </summary>	
//	public class KHODAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public KHODAO()
//		{
//		}
//		public KHODAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public KHOBO LoadInfo(string strMakho)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KHO_SEL");
//				objIData.AddParameter(P_Makho, strMakho);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	KHOBO objKHOBO = new KHOBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Makho]))  objKHOBO.Makho = Convert.ToString(reader[C_Makho]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Tenkho]))  objKHOBO.Tenkho = Convert.ToString(reader[C_Tenkho]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Diachi]))  objKHOBO.Diachi = Convert.ToInt32(reader[C_Diachi]);
// 					if (!Convert.IsDBNull(reader[C_Nvkho]))  objKHOBO.Nvkho = Convert.ToString(reader[C_Nvkho]).Trim();
// 					objKHOBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objKHOBO.IsExist = false;
// 				}
//				reader.Close();
//				return objKHOBO;
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
//		/// Insert : KHO
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(KHOBO objKHOBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KHO_ADD");

//				objIData.AddParameter(P_Makho, objKHOBO.Makho);
//				objIData.AddParameter(P_Tenkho, objKHOBO.Tenkho);
//				objIData.AddParameter(P_Diachi, objKHOBO.Diachi);
//				objIData.AddParameter(P_Nvkho, objKHOBO.Nvkho);
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
//		/// Update : KHO
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(KHOBO objKHOBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KHO_UPD");
//				objIData.AddParameter(P_Makho, objKHOBO.Makho);
//				objIData.AddParameter(P_Tenkho, objKHOBO.Tenkho);
//				objIData.AddParameter(P_Diachi, objKHOBO.Diachi);
//				objIData.AddParameter(P_Nvkho, objKHOBO.Nvkho);
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
//		/// Delete : KHO
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(KHOBO objKHOBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KHO_DEL");
//				objIData.AddParameter(P_Makho, objKHOBO.Makho);
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
//		/// SearchData : KHO
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
//				objIData.CreateNewStoredProcedure("KHO_SRH");
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

//		public const String P_Makho = "@" + C_Makho;
//		public const String P_Tenkho = "@" + C_Tenkho;
//		public const String P_Diachi = "@" + C_Diachi;
//		public const String P_Nvkho = "@" + C_Nvkho;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Makho = "Makho";
//		public const String C_Tenkho = "Tenkho";
//		public const String C_Diachi = "Diachi";
//		public const String C_Nvkho = "Nvkho";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
