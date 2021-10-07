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
////	/// Quan Ly Khach Hang
////	/// </summary>	
////	public class KHKHACHHANGDAO
////	{
////		private IData objDataAccess = null;

////		public IData DataAccess
////		{
////  			get { return objDataAccess; }
////   			set { objDataAccess = value; }
////		}

////		#region Constructor
////		public KHKHACHHANGDAO()
////		{
////		}
////		public KHKHACHHANGDAO(ProcessManager objProcessManager)
////		{
////			objDataAccess = objProcessManager.DataAccess;
////		}
////		#endregion

////		#region Methods

////		///<summary>
////		/// Nạp thông tin từ CSDL
////		///</summary>
////		/// <returns>OjbectBO</returns>
////		public KHKHACHHANGBO LoadInfo(string strMakh)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("KH_KHACHHANG_SEL");
////				objIData.AddParameter(P_Makh, strMakh);
////				IDataReader reader = objIData.ExecStoreToDataReader();
//// 		    	KHKHACHHANGBO objKHKHACHHANGBO = new KHKHACHHANGBO();
////				if (reader.Read())
//// 				{
//// 					if (!Convert.IsDBNull(reader[C_Makh]))  objKHKHACHHANGBO.Makh = Convert.ToString(reader[C_Makh]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Tenkh]))  objKHKHACHHANGBO.Tenkh = Convert.ToString(reader[C_Tenkh]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Sdt]))  objKHKHACHHANGBO.Sdt = Convert.ToString(reader[C_Sdt]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Email]))  objKHKHACHHANGBO.Email = Convert.ToString(reader[C_Email]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Password]))  objKHKHACHHANGBO.Password = Convert.ToString(reader[C_Password]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Diemtichluy]))  objKHKHACHHANGBO.Diemtichluy = Convert.ToInt32(reader[C_Diemtichluy]);
//// 					objKHKHACHHANGBO.IsExist = true;
//// 				}
//// 				else
//// 				{
//// 					objKHKHACHHANGBO.IsExist = false;
//// 				}
////				reader.Close();
////				return objKHKHACHHANGBO;
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
////		/// Insert : KH_KHACHHANG
////		/// Thêm dữ liệu
////		///</summary>
////		public bool Insert(KHKHACHHANGBO objKHKHACHHANGBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("KH_KHACHHANG_ADD");

////				objIData.AddParameter(P_Makh, objKHKHACHHANGBO.Makh);
////				objIData.AddParameter(P_Tenkh, objKHKHACHHANGBO.Tenkh);
////				objIData.AddParameter(P_Sdt, objKHKHACHHANGBO.Sdt);
////				objIData.AddParameter(P_Email, objKHKHACHHANGBO.Email);
////				objIData.AddParameter(P_Password, objKHKHACHHANGBO.Password);
////				objIData.AddParameter(P_Diemtichluy, objKHKHACHHANGBO.Diemtichluy);
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
////		/// Update : KH_KHACHHANG
////		/// Cập nhật dữ liệu
////		///</summary>
////		public bool Update(KHKHACHHANGBO objKHKHACHHANGBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("KH_KHACHHANG_UPD");
////				objIData.AddParameter(P_Makh, objKHKHACHHANGBO.Makh);
////				objIData.AddParameter(P_Tenkh, objKHKHACHHANGBO.Tenkh);
////				objIData.AddParameter(P_Sdt, objKHKHACHHANGBO.Sdt);
////				objIData.AddParameter(P_Email, objKHKHACHHANGBO.Email);
////				objIData.AddParameter(P_Password, objKHKHACHHANGBO.Password);
////				objIData.AddParameter(P_Diemtichluy, objKHKHACHHANGBO.Diemtichluy);
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
////		/// Delete : KH_KHACHHANG
////		/// Xóa dữ liệu
////		///</summary>
////		public bool Delete(KHKHACHHANGBO objKHKHACHHANGBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("KH_KHACHHANG_DEL");
////				objIData.AddParameter(P_Makh, objKHKHACHHANGBO.Makh);
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
////		/// SearchData : KH_KHACHHANG
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
////				objIData.CreateNewStoredProcedure("KH_KHACHHANG_SRH");
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

////		public const String P_Makh = "@" + C_Makh;
////		public const String P_Tenkh = "@" + C_Tenkh;
////		public const String P_Sdt = "@" + C_Sdt;
////		public const String P_Email = "@" + C_Email;
////		public const String P_Password = "@" + C_Password;
////		public const String P_Diemtichluy = "@" + C_Diemtichluy;

////		#endregion //Parameter names

////		#region Column Names

////		public const String C_Makh = "Makh";
////		public const String C_Tenkh = "Tenkh";
////		public const String C_Sdt = "Sdt";
////		public const String C_Email = "Email";
////		public const String C_Password = "Password";
////		public const String C_Diemtichluy = "Diemtichluy";

////		#endregion //Column names

////		#endregion Variable Static		
////	}
////}
