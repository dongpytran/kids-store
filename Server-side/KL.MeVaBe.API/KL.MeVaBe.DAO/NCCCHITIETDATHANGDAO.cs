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
//	/// Quan Ly Chi Tiet NCC_Dat Hang
//	/// </summary>	
//	public class NCCCHITIETDATHANGDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public NCCCHITIETDATHANGDAO()
//		{
//		}
//		public NCCCHITIETDATHANGDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public NCCCHITIETDATHANGBO LoadInfo(string strMaphieudat, string strMasp)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NCC_CHITIETDATHANG_SEL");
//				objIData.AddParameter(P_Maphieudat, strMaphieudat);
//				objIData.AddParameter(P_Masp, strMasp);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	NCCCHITIETDATHANGBO objNCCCHITIETDATHANGBO = new NCCCHITIETDATHANGBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Maphieudat]))  objNCCCHITIETDATHANGBO.Maphieudat = Convert.ToString(reader[C_Maphieudat]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Masp]))  objNCCCHITIETDATHANGBO.Masp = Convert.ToString(reader[C_Masp]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Soluongdat]))  objNCCCHITIETDATHANGBO.Soluongdat = Convert.ToInt32(reader[C_Soluongdat]);
// 					if (!Convert.IsDBNull(reader[C_Soluongnhap]))  objNCCCHITIETDATHANGBO.Soluongnhap = Convert.ToInt32(reader[C_Soluongnhap]);
// 					if (!Convert.IsDBNull(reader[C_Dongianhap]))  objNCCCHITIETDATHANGBO.Dongianhap = Convert.ToString(reader[C_Dongianhap]).Trim();
// 					objNCCCHITIETDATHANGBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objNCCCHITIETDATHANGBO.IsExist = false;
// 				}
//				reader.Close();
//				return objNCCCHITIETDATHANGBO;
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
//		/// Insert : NCC_CHITIETDATHANG
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(NCCCHITIETDATHANGBO objNCCCHITIETDATHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NCC_CHITIETDATHANG_ADD");

//				objIData.AddParameter(P_Maphieudat, objNCCCHITIETDATHANGBO.Maphieudat);
//				objIData.AddParameter(P_Masp, objNCCCHITIETDATHANGBO.Masp);
//				objIData.AddParameter(P_Soluongdat, objNCCCHITIETDATHANGBO.Soluongdat);
//				objIData.AddParameter(P_Soluongnhap, objNCCCHITIETDATHANGBO.Soluongnhap);
//				objIData.AddParameter(P_Dongianhap, objNCCCHITIETDATHANGBO.Dongianhap);
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
//		/// Update : NCC_CHITIETDATHANG
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(NCCCHITIETDATHANGBO objNCCCHITIETDATHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NCC_CHITIETDATHANG_UPD");
//				objIData.AddParameter(P_Maphieudat, objNCCCHITIETDATHANGBO.Maphieudat);
//				objIData.AddParameter(P_Masp, objNCCCHITIETDATHANGBO.Masp);
//				objIData.AddParameter(P_Soluongdat, objNCCCHITIETDATHANGBO.Soluongdat);
//				objIData.AddParameter(P_Soluongnhap, objNCCCHITIETDATHANGBO.Soluongnhap);
//				objIData.AddParameter(P_Dongianhap, objNCCCHITIETDATHANGBO.Dongianhap);
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
//		/// Delete : NCC_CHITIETDATHANG
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(NCCCHITIETDATHANGBO objNCCCHITIETDATHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NCC_CHITIETDATHANG_DEL");
//				objIData.AddParameter(P_Maphieudat, objNCCCHITIETDATHANGBO.Maphieudat);
//				objIData.AddParameter(P_Masp, objNCCCHITIETDATHANGBO.Masp);
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
//		/// SearchData : NCC_CHITIETDATHANG
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
//				objIData.CreateNewStoredProcedure("NCC_CHITIETDATHANG_SRH");
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

//		public const String P_Maphieudat = "@" + C_Maphieudat;
//		public const String P_Masp = "@" + C_Masp;
//		public const String P_Soluongdat = "@" + C_Soluongdat;
//		public const String P_Soluongnhap = "@" + C_Soluongnhap;
//		public const String P_Dongianhap = "@" + C_Dongianhap;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Maphieudat = "Maphieudat";
//		public const String C_Masp = "Masp";
//		public const String C_Soluongdat = "Soluongdat";
//		public const String C_Soluongnhap = "Soluongnhap";
//		public const String C_Dongianhap = "Dongianhap";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
