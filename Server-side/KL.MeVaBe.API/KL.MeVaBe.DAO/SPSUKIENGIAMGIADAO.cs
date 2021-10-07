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
//	/// Quan Ly Su Kien Giam Gia
//	/// </summary>	
//	public class SPSUKIENGIAMGIADAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public SPSUKIENGIAMGIADAO()
//		{
//		}
//		public SPSUKIENGIAMGIADAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public SPSUKIENGIAMGIABO LoadInfo(string strMasukien)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_SUKIENGIAMGIA_SEL");
//				objIData.AddParameter(P_Masukien, strMasukien);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	SPSUKIENGIAMGIABO objSPSUKIENGIAMGIABO = new SPSUKIENGIAMGIABO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Masukien]))  objSPSUKIENGIAMGIABO.Masukien = Convert.ToString(reader[C_Masukien]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Tensukien]))  objSPSUKIENGIAMGIABO.Tensukien = Convert.ToString(reader[C_Tensukien]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Ngaybatdau]))  objSPSUKIENGIAMGIABO.Ngaybatdau = Convert.ToDateTime(reader[C_Ngaybatdau]);
// 					if (!Convert.IsDBNull(reader[C_Ngayketthuc]))  objSPSUKIENGIAMGIABO.Ngayketthuc = Convert.ToDateTime(reader[C_Ngayketthuc]);
// 					objSPSUKIENGIAMGIABO.IsExist = true;
// 				}
// 				else
// 				{
// 					objSPSUKIENGIAMGIABO.IsExist = false;
// 				}
//				reader.Close();
//				return objSPSUKIENGIAMGIABO;
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
//		/// Insert : SP_SUKIENGIAMGIA
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(SPSUKIENGIAMGIABO objSPSUKIENGIAMGIABO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_SUKIENGIAMGIA_ADD");

//				objIData.AddParameter(P_Masukien, objSPSUKIENGIAMGIABO.Masukien);
//				objIData.AddParameter(P_Tensukien, objSPSUKIENGIAMGIABO.Tensukien);
//				objIData.AddParameter(P_Ngaybatdau, objSPSUKIENGIAMGIABO.Ngaybatdau);
//				objIData.AddParameter(P_Ngayketthuc, objSPSUKIENGIAMGIABO.Ngayketthuc);
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
//		/// Update : SP_SUKIENGIAMGIA
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(SPSUKIENGIAMGIABO objSPSUKIENGIAMGIABO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_SUKIENGIAMGIA_UPD");
//				objIData.AddParameter(P_Masukien, objSPSUKIENGIAMGIABO.Masukien);
//				objIData.AddParameter(P_Tensukien, objSPSUKIENGIAMGIABO.Tensukien);
//				objIData.AddParameter(P_Ngaybatdau, objSPSUKIENGIAMGIABO.Ngaybatdau);
//				objIData.AddParameter(P_Ngayketthuc, objSPSUKIENGIAMGIABO.Ngayketthuc);
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
//		/// Delete : SP_SUKIENGIAMGIA
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(SPSUKIENGIAMGIABO objSPSUKIENGIAMGIABO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_SUKIENGIAMGIA_DEL");
//				objIData.AddParameter(P_Masukien, objSPSUKIENGIAMGIABO.Masukien);
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
//		/// SearchData : SP_SUKIENGIAMGIA
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
//				objIData.CreateNewStoredProcedure("SP_SUKIENGIAMGIA_SRH");
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
//		public const String P_Tensukien = "@" + C_Tensukien;
//		public const String P_Ngaybatdau = "@" + C_Ngaybatdau;
//		public const String P_Ngayketthuc = "@" + C_Ngayketthuc;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Masukien = "Masukien";
//		public const String C_Tensukien = "Tensukien";
//		public const String C_Ngaybatdau = "Ngaybatdau";
//		public const String C_Ngayketthuc = "Ngayketthuc";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
