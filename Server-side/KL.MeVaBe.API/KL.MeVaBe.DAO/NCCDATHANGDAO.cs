////#region Using
////using System;
////using System.Data;
////using System.Collections;
////using System.Collections.Generic;
////using TGDD.Library.Data;
////using KL.MeVaBe.DAO;
////using TGDD.Library.Framework;
////#endregion

////namespace KL.MeVaBe.DAO
////{
////    /// <summary>
////	/// Created by 		: Dong Py 
////	/// Created date 	: 10/5/2021 
////	/// Quan Ly NCC_Dat Hang
////	/// </summary>	
////	public class NCCDATHANGDAO
////	{
////		private IData objDataAccess = null;

////		public IData DataAccess
////		{
////  			get { return objDataAccess; }
////   			set { objDataAccess = value; }
////		}

////		#region Constructor
////		public NCCDATHANGDAO()
////		{
////		}
////		public NCCDATHANGDAO(ProcessManager objProcessManager)
////		{
////			objDataAccess = objProcessManager.DataAccess;
////		}
////		#endregion

////		#region Methods

////		///<summary>
////		/// Nạp thông tin từ CSDL
////		///</summary>
////		/// <returns>OjbectBO</returns>
////		public NCCDATHANGBO LoadInfo(string strMaphieudat)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NCC_DATHANG_SEL");
////				objIData.AddParameter(P_Maphieudat, strMaphieudat);
////				IDataReader reader = objIData.ExecStoreToDataReader();
//// 		    	NCCDATHANGBO objNCCDATHANGBO = new NCCDATHANGBO();
////				if (reader.Read())
//// 				{
//// 					if (!Convert.IsDBNull(reader[C_Maphieudat]))  objNCCDATHANGBO.Maphieudat = Convert.ToString(reader[C_Maphieudat]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Ngaylap]))  objNCCDATHANGBO.Ngaylap = Convert.ToDateTime(reader[C_Ngaylap]);
//// 					if (!Convert.IsDBNull(reader[C_Manv]))  objNCCDATHANGBO.Manv = Convert.ToString(reader[C_Manv]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Mancc]))  objNCCDATHANGBO.Mancc = Convert.ToString(reader[C_Mancc]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Ngaygiaodukien]))  objNCCDATHANGBO.Ngaygiaodukien = Convert.ToDateTime(reader[C_Ngaygiaodukien]);
//// 					if (!Convert.IsDBNull(reader[C_Ngaygiaothucte]))  objNCCDATHANGBO.Ngaygiaothucte = Convert.ToDateTime(reader[C_Ngaygiaothucte]);
//// 					if (!Convert.IsDBNull(reader[C_Tongtien]))  objNCCDATHANGBO.Tongtien = Convert.ToInt32(reader[C_Tongtien]);
//// 					if (!Convert.IsDBNull(reader[C_Trangthai]))  objNCCDATHANGBO.Trangthai = Convert.ToInt32(reader[C_Trangthai]);
//// 					objNCCDATHANGBO.IsExist = true;
//// 				}
//// 				else
//// 				{
//// 					objNCCDATHANGBO.IsExist = false;
//// 				}
////				reader.Close();
////				return objNCCDATHANGBO;
////			}
////			catch (Exception objEx)
////			{
////				throw objEx;
////			}
////			finally
////    		{
////    			if (objDataAccess == null)
////        			objIData.Disconnect();
////    		}
////		}

////		///<summary>
////		/// Insert : NCC_DATHANG
////		/// Thêm dữ liệu
////		///</summary>
////		public bool Insert(NCCDATHANGBO objNCCDATHANGBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NCC_DATHANG_ADD");

////				objIData.AddParameter(P_Maphieudat, objNCCDATHANGBO.Maphieudat);
////				objIData.AddParameter(P_Ngaylap, objNCCDATHANGBO.Ngaylap);
////				objIData.AddParameter(P_Manv, objNCCDATHANGBO.Manv);
////				objIData.AddParameter(P_Mancc, objNCCDATHANGBO.Mancc);
////				objIData.AddParameter(P_Ngaygiaodukien, objNCCDATHANGBO.Ngaygiaodukien);
////				objIData.AddParameter(P_Ngaygiaothucte, objNCCDATHANGBO.Ngaygiaothucte);
////				objIData.AddParameter(P_Tongtien, objNCCDATHANGBO.Tongtien);
////				objIData.AddParameter(P_Trangthai, objNCCDATHANGBO.Trangthai);
////              	objIData.ExecNonQuery();
////				return true;
////			}
////			catch (Exception objEx)
////			{
////				throw objEx;
////			}
////			finally
////    		{
////    			if (objDataAccess == null)
////        			objIData.Disconnect();
////    		}
////		}

////		///<summary>
////		/// Update : NCC_DATHANG
////		/// Cập nhật dữ liệu
////		///</summary>
////		public bool Update(NCCDATHANGBO objNCCDATHANGBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NCC_DATHANG_UPD");
////				objIData.AddParameter(P_Maphieudat, objNCCDATHANGBO.Maphieudat);
////				objIData.AddParameter(P_Ngaylap, objNCCDATHANGBO.Ngaylap);
////				objIData.AddParameter(P_Manv, objNCCDATHANGBO.Manv);
////				objIData.AddParameter(P_Mancc, objNCCDATHANGBO.Mancc);
////				objIData.AddParameter(P_Ngaygiaodukien, objNCCDATHANGBO.Ngaygiaodukien);
////				objIData.AddParameter(P_Ngaygiaothucte, objNCCDATHANGBO.Ngaygiaothucte);
////				objIData.AddParameter(P_Tongtien, objNCCDATHANGBO.Tongtien);
////				objIData.AddParameter(P_Trangthai, objNCCDATHANGBO.Trangthai);
////                objIData.ExecNonQuery();
////                return true;
////			}
////			catch (Exception objEx)
////			{
////				throw objEx;
////			}
////			finally
////    		{
////    			if (objDataAccess == null)
////        			objIData.Disconnect();
////    		}
////		}

////		///<summary>
////		/// Delete : NCC_DATHANG
////		/// Xóa dữ liệu
////		///</summary>
////		public bool Delete(NCCDATHANGBO objNCCDATHANGBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NCC_DATHANG_DEL");
////				objIData.AddParameter(P_Maphieudat, objNCCDATHANGBO.Maphieudat);
//// 				objIData.ExecNonQuery();
////              return true;
////			}
////			catch (Exception objEx)
////			{
////				throw objEx;
////			}
////			finally
////    		{
////    			if (objDataAccess == null)
////        			objIData.Disconnect();
////    		}
////		}

////		///<summary>
////		/// SearchData : NCC_DATHANG
////		/// Nap dữ liệu
////		///</summary>
////		public DataTable SearchData(params object[] objKeywords)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NCC_DATHANG_SRH");
////				objIData.AddParameter(objKeywords);
//// 				return objIData.ExecStoreToDataTable();
////			}
////			catch (Exception objEx)
////			{
////				throw objEx;
////			}
////			finally
////    		{
////    			if (objDataAccess == null)
////        			objIData.Disconnect();
////    		}
////		}
		
////		#endregion
		
////		#region Variable Static

////		#region Parameter Names

////		public const String P_Maphieudat = "@" + C_Maphieudat;
////		public const String P_Ngaylap = "@" + C_Ngaylap;
////		public const String P_Manv = "@" + C_Manv;
////		public const String P_Mancc = "@" + C_Mancc;
////		public const String P_Ngaygiaodukien = "@" + C_Ngaygiaodukien;
////		public const String P_Ngaygiaothucte = "@" + C_Ngaygiaothucte;
////		public const String P_Tongtien = "@" + C_Tongtien;
////		public const String P_Trangthai = "@" + C_Trangthai;

////		#endregion //Parameter names

////		#region Column Names

////		public const String C_Maphieudat = "Maphieudat";
////		public const String C_Ngaylap = "Ngaylap";
////		public const String C_Manv = "Manv";
////		public const String C_Mancc = "Mancc";
////		public const String C_Ngaygiaodukien = "Ngaygiaodukien";
////		public const String C_Ngaygiaothucte = "Ngaygiaothucte";
////		public const String C_Tongtien = "Tongtien";
////		public const String C_Trangthai = "Trangthai";

////		#endregion //Column names

////		#endregion Variable Static		
////	}
////}
