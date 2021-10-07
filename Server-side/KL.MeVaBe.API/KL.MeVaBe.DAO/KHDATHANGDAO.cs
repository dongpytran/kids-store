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
//	/// Quan Ly KH_Dat Hang
//	/// </summary>	
//	public class KHDATHANGDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public KHDATHANGDAO()
//		{
//		}
//		public KHDATHANGDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public KHDATHANGBO LoadInfo(string strMadondat)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_DATHANG_SEL");
//				objIData.AddParameter(P_Madondat, strMadondat);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	KHDATHANGBO objKHDATHANGBO = new KHDATHANGBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Madondat]))  objKHDATHANGBO.Madondat = Convert.ToString(reader[C_Madondat]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Ngaydat]))  objKHDATHANGBO.Ngaydat = Convert.ToDateTime(reader[C_Ngaydat]);
// 					if (!Convert.IsDBNull(reader[C_Makh]))  objKHDATHANGBO.Makh = Convert.ToString(reader[C_Makh]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Tongtien]))  objKHDATHANGBO.Tongtien = Convert.ToDecimal(reader[C_Tongtien]);
// 					if (!Convert.IsDBNull(reader[C_Maphuongthuctt]))  objKHDATHANGBO.Maphuongthuctt = Convert.ToString(reader[C_Maphuongthuctt]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Trangthai]))  objKHDATHANGBO.Trangthai = Convert.ToInt32(reader[C_Trangthai]);
// 					if (!Convert.IsDBNull(reader[C_Ngaycapnhat]))  objKHDATHANGBO.Ngaycapnhat = Convert.ToDateTime(reader[C_Ngaycapnhat]);
// 					if (!Convert.IsDBNull(reader[C_Loaidonhang]))  objKHDATHANGBO.Loaidonhang = Convert.ToString(reader[C_Loaidonhang]).Trim();
// 					objKHDATHANGBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objKHDATHANGBO.IsExist = false;
// 				}
//				reader.Close();
//				return objKHDATHANGBO;
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
//		/// Insert : KH_DATHANG
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(KHDATHANGBO objKHDATHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_DATHANG_ADD");

//				objIData.AddParameter(P_Madondat, objKHDATHANGBO.Madondat);
//				objIData.AddParameter(P_Ngaydat, objKHDATHANGBO.Ngaydat);
//				objIData.AddParameter(P_Makh, objKHDATHANGBO.Makh);
//				objIData.AddParameter(P_Tongtien, objKHDATHANGBO.Tongtien);
//				objIData.AddParameter(P_Maphuongthuctt, objKHDATHANGBO.Maphuongthuctt);
//				objIData.AddParameter(P_Trangthai, objKHDATHANGBO.Trangthai);
//				objIData.AddParameter(P_Ngaycapnhat, objKHDATHANGBO.Ngaycapnhat);
//				objIData.AddParameter(P_Loaidonhang, objKHDATHANGBO.Loaidonhang);
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
//		/// Update : KH_DATHANG
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(KHDATHANGBO objKHDATHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_DATHANG_UPD");
//				objIData.AddParameter(P_Madondat, objKHDATHANGBO.Madondat);
//				objIData.AddParameter(P_Ngaydat, objKHDATHANGBO.Ngaydat);
//				objIData.AddParameter(P_Makh, objKHDATHANGBO.Makh);
//				objIData.AddParameter(P_Tongtien, objKHDATHANGBO.Tongtien);
//				objIData.AddParameter(P_Maphuongthuctt, objKHDATHANGBO.Maphuongthuctt);
//				objIData.AddParameter(P_Trangthai, objKHDATHANGBO.Trangthai);
//				objIData.AddParameter(P_Ngaycapnhat, objKHDATHANGBO.Ngaycapnhat);
//				objIData.AddParameter(P_Loaidonhang, objKHDATHANGBO.Loaidonhang);
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
//		/// Delete : KH_DATHANG
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(KHDATHANGBO objKHDATHANGBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_DATHANG_DEL");
//				objIData.AddParameter(P_Madondat, objKHDATHANGBO.Madondat);
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
//		/// SearchData : KH_DATHANG
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
//				objIData.CreateNewStoredProcedure("KH_DATHANG_SRH");
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
//		public const String P_Ngaydat = "@" + C_Ngaydat;
//		public const String P_Makh = "@" + C_Makh;
//		public const String P_Tongtien = "@" + C_Tongtien;
//		public const String P_Maphuongthuctt = "@" + C_Maphuongthuctt;
//		public const String P_Trangthai = "@" + C_Trangthai;
//		public const String P_Ngaycapnhat = "@" + C_Ngaycapnhat;
//		public const String P_Loaidonhang = "@" + C_Loaidonhang;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Madondat = "Madondat";
//		public const String C_Ngaydat = "Ngaydat";
//		public const String C_Makh = "Makh";
//		public const String C_Tongtien = "Tongtien";
//		public const String C_Maphuongthuctt = "Maphuongthuctt";
//		public const String C_Trangthai = "Trangthai";
//		public const String C_Ngaycapnhat = "Ngaycapnhat";
//		public const String C_Loaidonhang = "Loaidonhang";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
