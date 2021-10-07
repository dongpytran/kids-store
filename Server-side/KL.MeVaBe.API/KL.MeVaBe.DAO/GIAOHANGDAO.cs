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
//	/// Quan Ly Giao Hang
//	/// </summary>	
//	public class GIAOHANGDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public GIAOHANGDAO()
//		{
//		}
//		public GIAOHANGDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public GIAOHANGBO LoadInfo(string strMadondat)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("GIAOHANG_SEL");
//				objIData.AddParameter(P_Madondat, strMadondat);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	GIAOHANGBO objGIAOHANGBO = new GIAOHANGBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Madondat]))  objGIAOHANGBO.Madondat = Convert.ToString(reader[C_Madondat]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Manv]))  objGIAOHANGBO.Manv = Convert.ToString(reader[C_Manv]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Ngaygiao]))  objGIAOHANGBO.Ngaygiao = Convert.ToDateTime(reader[C_Ngaygiao]);
// 					if (!Convert.IsDBNull(reader[C_IsDelivery]))  objGIAOHANGBO.IsDelivery = Convert.ToBoolean(reader[C_IsDelivery]);
// 					objGIAOHANGBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objGIAOHANGBO.IsExist = false;
// 				}
//				reader.Close();
//				return objGIAOHANGBO;
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
//		/// Insert : GIAOHANG
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(GIAOHANGBO objGIAOHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("GIAOHANG_ADD");

//				objIData.AddParameter(P_Madondat, objGIAOHANGBO.Madondat);
//				objIData.AddParameter(P_Manv, objGIAOHANGBO.Manv);
//				objIData.AddParameter(P_Ngaygiao, objGIAOHANGBO.Ngaygiao);
//				objIData.AddParameter(P_IsDelivery, objGIAOHANGBO.IsDelivery);
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
//		/// Update : GIAOHANG
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(GIAOHANGBO objGIAOHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("GIAOHANG_UPD");
//				objIData.AddParameter(P_Madondat, objGIAOHANGBO.Madondat);
//				objIData.AddParameter(P_Manv, objGIAOHANGBO.Manv);
//				objIData.AddParameter(P_Ngaygiao, objGIAOHANGBO.Ngaygiao);
//				objIData.AddParameter(P_IsDelivery, objGIAOHANGBO.IsDelivery);
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
//		/// Delete : GIAOHANG
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(GIAOHANGBO objGIAOHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("GIAOHANG_DEL");
//				objIData.AddParameter(P_Madondat, objGIAOHANGBO.Madondat);
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
//		/// SearchData : GIAOHANG
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
//				objIData.CreateNewStoredProcedure("GIAOHANG_SRH");
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

//		public const String P_Madondat = "@" + C_Madondat;
//		public const String P_Manv = "@" + C_Manv;
//		public const String P_Ngaygiao = "@" + C_Ngaygiao;
//		public const String P_IsDelivery = "@" + C_IsDelivery;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Madondat = "Madondat";
//		public const String C_Manv = "Manv";
//		public const String C_Ngaygiao = "Ngaygiao";
//		public const String C_IsDelivery = "IsDelivery";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
