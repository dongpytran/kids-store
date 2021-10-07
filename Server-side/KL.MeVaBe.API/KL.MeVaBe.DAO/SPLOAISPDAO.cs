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
//	/// Quan Ly SP_Loai San pham
//	/// </summary>	
//	public class SPLOAISPDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public SPLOAISPDAO()
//		{
//		}
//		public SPLOAISPDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public SPLOAIsPBO LoadInfo(string strMaloai)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_LOAISP_SEL");
//				objIData.AddParameter(P_Maloai, strMaloai);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	SPLOAIsPBO objSPLOAIsPBO = new SPLOAIsPBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Maloai]))  objSPLOAIsPBO.Maloai = Convert.ToString(reader[C_Maloai]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Tenloai]))  objSPLOAIsPBO.Tenloai = Convert.ToString(reader[C_Tenloai]).Trim();
// 					objSPLOAIsPBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objSPLOAIsPBO.IsExist = false;
// 				}
//				reader.Close();
//				return objSPLOAIsPBO;
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
//		/// Insert : SP_LOAISP
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(SPLOAIsPBO objSPLOAIsPBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_LOAISP_ADD");

//				objIData.AddParameter(P_Maloai, objSPLOAIsPBO.Maloai);
//				objIData.AddParameter(P_Tenloai, objSPLOAIsPBO.Tenloai);
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
//		/// Update : SP_LOAISP
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(SPLOAIsPBO objSPLOAIsPBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_LOAISP_UPD");
//				objIData.AddParameter(P_Maloai, objSPLOAIsPBO.Maloai);
//				objIData.AddParameter(P_Tenloai, objSPLOAIsPBO.Tenloai);
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
//		/// Delete : SP_LOAISP
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(SPLOAIsPBO objSPLOAIsPBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_LOAISP_DEL");
//				objIData.AddParameter(P_Maloai, objSPLOAIsPBO.Maloai);
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
//		/// SearchData : SP_LOAISP
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
//				objIData.CreateNewStoredProcedure("SP_LOAISP_SRH");
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

//		public const String P_Maloai = "@" + C_Maloai;
//		public const String P_Tenloai = "@" + C_Tenloai;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Maloai = "Maloai";
//		public const String C_Tenloai = "Tenloai";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
