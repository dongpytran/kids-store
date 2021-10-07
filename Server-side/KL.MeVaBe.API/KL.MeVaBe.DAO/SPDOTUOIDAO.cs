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
//	/// Quan Ly SP_Do Tuoi
//	/// </summary>	
//	public class SPDOTUOIDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public SPDOTUOIDAO()
//		{
//		}
//		public SPDOTUOIDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public SPDOTUOIBO LoadInfo(string strMadotuoi)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_DOTUOI_SEL");
//				objIData.AddParameter(P_Madotuoi, strMadotuoi);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	SPDOTUOIBO objSPDOTUOIBO = new SPDOTUOIBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Madotuoi]))  objSPDOTUOIBO.Madotuoi = Convert.ToString(reader[C_Madotuoi]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Dotuoi]))  objSPDOTUOIBO.Dotuoi = Convert.ToString(reader[C_Dotuoi]).Trim();
// 					objSPDOTUOIBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objSPDOTUOIBO.IsExist = false;
// 				}
//				reader.Close();
//				return objSPDOTUOIBO;
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
//		/// Insert : SP_DOTUOI
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(SPDOTUOIBO objSPDOTUOIBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_DOTUOI_ADD");

//				objIData.AddParameter(P_Madotuoi, objSPDOTUOIBO.Madotuoi);
//				objIData.AddParameter(P_Dotuoi, objSPDOTUOIBO.Dotuoi);
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
//		/// Update : SP_DOTUOI
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(SPDOTUOIBO objSPDOTUOIBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_DOTUOI_UPD");
//				objIData.AddParameter(P_Madotuoi, objSPDOTUOIBO.Madotuoi);
//				objIData.AddParameter(P_Dotuoi, objSPDOTUOIBO.Dotuoi);
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
//		/// Delete : SP_DOTUOI
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(SPDOTUOIBO objSPDOTUOIBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_DOTUOI_DEL");
//				objIData.AddParameter(P_Madotuoi, objSPDOTUOIBO.Madotuoi);
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
//		/// SearchData : SP_DOTUOI
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
//				objIData.CreateNewStoredProcedure("SP_DOTUOI_SRH");
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

//		public const String P_Madotuoi = "@" + C_Madotuoi;
//		public const String P_Dotuoi = "@" + C_Dotuoi;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Madotuoi = "Madotuoi";
//		public const String C_Dotuoi = "Dotuoi";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
