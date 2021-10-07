//#region Using
//using System;
//using System.Data;
//using System.Collections;
//using System.Collections.Generic;
//using KL.MeVaBe.DAO;
//using KL.MeVaBe.BO;
//#endregion

//namespace KL.MeVaBe.DAO
//{
//    /// <summary>
//	/// Created by 		: Dong Py 
//	/// Created date 	: 10/5/2021 
//	/// Quan Ly San pham Dai Dien
//	/// </summary>	
//	public class SPSANPHAMDAO
//	{
//		private string objDataAccess = null;


//		#region Constructor
//		public SPSANPHAMDAO()
//		{
//		}
//		public SPSANPHAMDAO(string objProcessManager)
//		{
//			objDataAccess = objProcessManager;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public SPSANPHAMBO LoadInfo(string strMasp)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_SANPHAM_SEL");
//				objIData.AddParameter(P_Masp, strMasp);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	SPSANPHAMBO objSPSANPHAMBO = new SPSANPHAMBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Masp]))  objSPSANPHAMBO.Masp = Convert.ToString(reader[C_Masp]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Tensp]))  objSPSANPHAMBO.Tensp = Convert.ToString(reader[C_Tensp]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Maloai]))  objSPSANPHAMBO.Maloai = Convert.ToString(reader[C_Maloai]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Mathuonghieu]))  objSPSANPHAMBO.Mathuonghieu = Convert.ToString(reader[C_Mathuonghieu]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Maxuatxu]))  objSPSANPHAMBO.Maxuatxu = Convert.ToString(reader[C_Maxuatxu]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Madotuoi]))  objSPSANPHAMBO.Madotuoi = Convert.ToString(reader[C_Madotuoi]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Hinhanh]))  objSPSANPHAMBO.Hinhanh = Convert.ToString(reader[C_Hinhanh]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Diemtichluy]))  objSPSANPHAMBO.Diemtichluy = Convert.ToInt32(reader[C_Diemtichluy]);
// 					if (!Convert.IsDBNull(reader[C_IsActive]))  objSPSANPHAMBO.IsActive = Convert.ToBoolean(reader[C_IsActive]);
// 					objSPSANPHAMBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objSPSANPHAMBO.IsExist = false;
// 				}
//				reader.Close();
//				return objSPSANPHAMBO;
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
//		/// Insert : SP_SANPHAM
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(SPSANPHAMBO objSPSANPHAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_SANPHAM_ADD");

//				objIData.AddParameter(P_Masp, objSPSANPHAMBO.Masp);
//				objIData.AddParameter(P_Tensp, objSPSANPHAMBO.Tensp);
//				objIData.AddParameter(P_Maloai, objSPSANPHAMBO.Maloai);
//				objIData.AddParameter(P_Mathuonghieu, objSPSANPHAMBO.Mathuonghieu);
//				objIData.AddParameter(P_Maxuatxu, objSPSANPHAMBO.Maxuatxu);
//				objIData.AddParameter(P_Madotuoi, objSPSANPHAMBO.Madotuoi);
//				objIData.AddParameter(P_Hinhanh, objSPSANPHAMBO.Hinhanh);
//				objIData.AddParameter(P_Diemtichluy, objSPSANPHAMBO.Diemtichluy);
//				objIData.AddParameter(P_IsActive, objSPSANPHAMBO.IsActive);
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
//		/// Update : SP_SANPHAM
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(SPSANPHAMBO objSPSANPHAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_SANPHAM_UPD");
//				objIData.AddParameter(P_Masp, objSPSANPHAMBO.Masp);
//				objIData.AddParameter(P_Tensp, objSPSANPHAMBO.Tensp);
//				objIData.AddParameter(P_Maloai, objSPSANPHAMBO.Maloai);
//				objIData.AddParameter(P_Mathuonghieu, objSPSANPHAMBO.Mathuonghieu);
//				objIData.AddParameter(P_Maxuatxu, objSPSANPHAMBO.Maxuatxu);
//				objIData.AddParameter(P_Madotuoi, objSPSANPHAMBO.Madotuoi);
//				objIData.AddParameter(P_Hinhanh, objSPSANPHAMBO.Hinhanh);
//				objIData.AddParameter(P_Diemtichluy, objSPSANPHAMBO.Diemtichluy);
//				objIData.AddParameter(P_IsActive, objSPSANPHAMBO.IsActive);
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
//		/// Delete : SP_SANPHAM
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(SPSANPHAMBO objSPSANPHAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_SANPHAM_DEL");
//				objIData.AddParameter(P_Masp, objSPSANPHAMBO.Masp);
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
//		/// SearchData : SP_SANPHAM
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
//				objIData.CreateNewStoredProcedure("SP_SANPHAM_SRH");
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

//		public const String P_Masp = "@" + C_Masp;
//		public const String P_Tensp = "@" + C_Tensp;
//		public const String P_Maloai = "@" + C_Maloai;
//		public const String P_Mathuonghieu = "@" + C_Mathuonghieu;
//		public const String P_Maxuatxu = "@" + C_Maxuatxu;
//		public const String P_Madotuoi = "@" + C_Madotuoi;
//		public const String P_Hinhanh = "@" + C_Hinhanh;
//		public const String P_Diemtichluy = "@" + C_Diemtichluy;
//		public const String P_IsActive = "@" + C_IsActive;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Masp = "Masp";
//		public const String C_Tensp = "Tensp";
//		public const String C_Maloai = "Maloai";
//		public const String C_Mathuonghieu = "Mathuonghieu";
//		public const String C_Maxuatxu = "Maxuatxu";
//		public const String C_Madotuoi = "Madotuoi";
//		public const String C_Hinhanh = "Hinhanh";
//		public const String C_Diemtichluy = "Diemtichluy";
//		public const String C_IsActive = "IsActive";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
