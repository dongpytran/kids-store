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
//	/// Quan Ly Nhan Vien
//	/// </summary>	
//	public class NVNHANVIENDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public NVNHANVIENDAO()
//		{
//		}
//		public NVNHANVIENDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public NVNHANVIENBO LoadInfo(string strManv)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NV_NHANVIEN_SEL");
//				objIData.AddParameter(P_Manv, strManv);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	NVNHANVIENBO objNVNHANVIENBO = new NVNHANVIENBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Manv]))  objNVNHANVIENBO.Manv = Convert.ToString(reader[C_Manv]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Tennv]))  objNVNHANVIENBO.Tennv = Convert.ToString(reader[C_Tennv]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Ngaysinh]))  objNVNHANVIENBO.Ngaysinh = Convert.ToDateTime(reader[C_Ngaysinh]);
// 					if (!Convert.IsDBNull(reader[C_Ngayvaolam]))  objNVNHANVIENBO.Ngayvaolam = Convert.ToDateTime(reader[C_Ngayvaolam]);
// 					if (!Convert.IsDBNull(reader[C_Gioitinh]))  objNVNHANVIENBO.Gioitinh = Convert.ToBoolean(reader[C_Gioitinh]);
// 					if (!Convert.IsDBNull(reader[C_Diachi]))  objNVNHANVIENBO.Diachi = Convert.ToString(reader[C_Diachi]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Sdt]))  objNVNHANVIENBO.Sdt = Convert.ToString(reader[C_Sdt]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Email]))  objNVNHANVIENBO.Email = Convert.ToString(reader[C_Email]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Machucvu]))  objNVNHANVIENBO.Machucvu = Convert.ToString(reader[C_Machucvu]).Trim();
// 					if (!Convert.IsDBNull(reader[C_IsActive]))  objNVNHANVIENBO.IsActive = Convert.ToBoolean(reader[C_IsActive]);
// 					objNVNHANVIENBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objNVNHANVIENBO.IsExist = false;
// 				}
//				reader.Close();
//				return objNVNHANVIENBO;
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
//		/// Insert : NV_NHANVIEN
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(NVNHANVIENBO objNVNHANVIENBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NV_NHANVIEN_ADD");

//				objIData.AddParameter(P_Manv, objNVNHANVIENBO.Manv);
//				objIData.AddParameter(P_Tennv, objNVNHANVIENBO.Tennv);
//				objIData.AddParameter(P_Ngaysinh, objNVNHANVIENBO.Ngaysinh);
//				objIData.AddParameter(P_Ngayvaolam, objNVNHANVIENBO.Ngayvaolam);
//				objIData.AddParameter(P_Gioitinh, objNVNHANVIENBO.Gioitinh);
//				objIData.AddParameter(P_Diachi, objNVNHANVIENBO.Diachi);
//				objIData.AddParameter(P_Sdt, objNVNHANVIENBO.Sdt);
//				objIData.AddParameter(P_Email, objNVNHANVIENBO.Email);
//				objIData.AddParameter(P_Machucvu, objNVNHANVIENBO.Machucvu);
//				objIData.AddParameter(P_IsActive, objNVNHANVIENBO.IsActive);
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
//		/// Update : NV_NHANVIEN
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(NVNHANVIENBO objNVNHANVIENBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NV_NHANVIEN_UPD");
//				objIData.AddParameter(P_Manv, objNVNHANVIENBO.Manv);
//				objIData.AddParameter(P_Tennv, objNVNHANVIENBO.Tennv);
//				objIData.AddParameter(P_Ngaysinh, objNVNHANVIENBO.Ngaysinh);
//				objIData.AddParameter(P_Ngayvaolam, objNVNHANVIENBO.Ngayvaolam);
//				objIData.AddParameter(P_Gioitinh, objNVNHANVIENBO.Gioitinh);
//				objIData.AddParameter(P_Diachi, objNVNHANVIENBO.Diachi);
//				objIData.AddParameter(P_Sdt, objNVNHANVIENBO.Sdt);
//				objIData.AddParameter(P_Email, objNVNHANVIENBO.Email);
//				objIData.AddParameter(P_Machucvu, objNVNHANVIENBO.Machucvu);
//				objIData.AddParameter(P_IsActive, objNVNHANVIENBO.IsActive);
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
//		/// Delete : NV_NHANVIEN
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(NVNHANVIENBO objNVNHANVIENBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NV_NHANVIEN_DEL");
//				objIData.AddParameter(P_Manv, objNVNHANVIENBO.Manv);
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
//		/// SearchData : NV_NHANVIEN
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
//				objIData.CreateNewStoredProcedure("NV_NHANVIEN_SRH");
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

//		public const String P_Manv = "@" + C_Manv;
//		public const String P_Tennv = "@" + C_Tennv;
//		public const String P_Ngaysinh = "@" + C_Ngaysinh;
//		public const String P_Ngayvaolam = "@" + C_Ngayvaolam;
//		public const String P_Gioitinh = "@" + C_Gioitinh;
//		public const String P_Diachi = "@" + C_Diachi;
//		public const String P_Sdt = "@" + C_Sdt;
//		public const String P_Email = "@" + C_Email;
//		public const String P_Machucvu = "@" + C_Machucvu;
//		public const String P_IsActive = "@" + C_IsActive;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Manv = "Manv";
//		public const String C_Tennv = "Tennv";
//		public const String C_Ngaysinh = "Ngaysinh";
//		public const String C_Ngayvaolam = "Ngayvaolam";
//		public const String C_Gioitinh = "Gioitinh";
//		public const String C_Diachi = "Diachi";
//		public const String C_Sdt = "Sdt";
//		public const String C_Email = "Email";
//		public const String C_Machucvu = "Machucvu";
//		public const String C_IsActive = "IsActive";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
