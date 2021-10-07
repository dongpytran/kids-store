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
//	/// Quan Ly Chi Tiet KH_Dat Hang
//	/// </summary>	
//	public class KHCHITIETDATHANGDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public KHCHITIETDATHANGDAO()
//		{
//		}
//		public KHCHITIETDATHANGDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public KHCHITIETDATHANGBO LoadInfo(string strMadondat, string strMasp)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_CHITIETDATHANG_SEL");
//				objIData.AddParameter(P_Madondat, strMadondat);
//				objIData.AddParameter(P_Masp, strMasp);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	KHCHITIETDATHANGBO objKHCHITIETDATHANGBO = new KHCHITIETDATHANGBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Madondat]))  objKHCHITIETDATHANGBO.Madondat = Convert.ToString(reader[C_Madondat]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Masp]))  objKHCHITIETDATHANGBO.Masp = Convert.ToString(reader[C_Masp]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Soluong]))  objKHCHITIETDATHANGBO.Soluong = Convert.ToInt32(reader[C_Soluong]);
// 					if (!Convert.IsDBNull(reader[C_Thanhtien]))  objKHCHITIETDATHANGBO.Thanhtien = Convert.ToDecimal(reader[C_Thanhtien]);
// 					objKHCHITIETDATHANGBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objKHCHITIETDATHANGBO.IsExist = false;
// 				}
//				reader.Close();
//				return objKHCHITIETDATHANGBO;
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
//		/// Insert : KH_CHITIETDATHANG
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(KHCHITIETDATHANGBO objKHCHITIETDATHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_CHITIETDATHANG_ADD");

//				objIData.AddParameter(P_Madondat, objKHCHITIETDATHANGBO.Madondat);
//				objIData.AddParameter(P_Masp, objKHCHITIETDATHANGBO.Masp);
//				objIData.AddParameter(P_Soluong, objKHCHITIETDATHANGBO.Soluong);
//				objIData.AddParameter(P_Thanhtien, objKHCHITIETDATHANGBO.Thanhtien);
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
//		/// Update : KH_CHITIETDATHANG
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(KHCHITIETDATHANGBO objKHCHITIETDATHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_CHITIETDATHANG_UPD");
//				objIData.AddParameter(P_Madondat, objKHCHITIETDATHANGBO.Madondat);
//				objIData.AddParameter(P_Masp, objKHCHITIETDATHANGBO.Masp);
//				objIData.AddParameter(P_Soluong, objKHCHITIETDATHANGBO.Soluong);
//				objIData.AddParameter(P_Thanhtien, objKHCHITIETDATHANGBO.Thanhtien);
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
//		/// Delete : KH_CHITIETDATHANG
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(KHCHITIETDATHANGBO objKHCHITIETDATHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_CHITIETDATHANG_DEL");
//				objIData.AddParameter(P_Madondat, objKHCHITIETDATHANGBO.Madondat);
//				objIData.AddParameter(P_Masp, objKHCHITIETDATHANGBO.Masp);
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
//		/// SearchData : KH_CHITIETDATHANG
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
//				objIData.CreateNewStoredProcedure("KH_CHITIETDATHANG_SRH");
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
//		public const String P_Masp = "@" + C_Masp;
//		public const String P_Soluong = "@" + C_Soluong;
//		public const String P_Thanhtien = "@" + C_Thanhtien;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Madondat = "Madondat";
//		public const String C_Masp = "Masp";
//		public const String C_Soluong = "Soluong";
//		public const String C_Thanhtien = "Thanhtien";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
