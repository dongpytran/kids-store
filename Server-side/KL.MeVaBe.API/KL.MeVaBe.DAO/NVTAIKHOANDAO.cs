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
////	/// Quan Ly Tai Khoan
////	/// </summary>	
////	public class NVTAIKHOANDAO
////	{
////		private IData objDataAccess = null;

////		public IData DataAccess
////		{
////  			get { return objDataAccess; }
////   			set { objDataAccess = value; }
////		}

////		#region Constructor
////		public NVTAIKHOANDAO()
////		{
////		}
////		public NVTAIKHOANDAO(ProcessManager objProcessManager)
////		{
////			objDataAccess = objProcessManager.DataAccess;
////		}
////		#endregion

////		#region Methods

////		///<summary>
////		/// Nạp thông tin từ CSDL
////		///</summary>
////		/// <returns>OjbectBO</returns>
////		public NVTAIKHOANBO LoadInfo(string strManv)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NV_TAIKHOAN_SEL");
////				objIData.AddParameter(P_Manv, strManv);
////				IDataReader reader = objIData.ExecStoreToDataReader();
//// 		    	NVTAIKHOANBO objNVTAIKHOANBO = new NVTAIKHOANBO();
////				if (reader.Read())
//// 				{
//// 					if (!Convert.IsDBNull(reader[C_Manv]))  objNVTAIKHOANBO.Manv = Convert.ToString(reader[C_Manv]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Password]))  objNVTAIKHOANBO.Password = Convert.ToString(reader[C_Password]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Roleid]))  objNVTAIKHOANBO.Roleid = Convert.ToInt32(reader[C_Roleid]);
//// 					objNVTAIKHOANBO.IsExist = true;
//// 				}
//// 				else
//// 				{
//// 					objNVTAIKHOANBO.IsExist = false;
//// 				}
////				reader.Close();
////				return objNVTAIKHOANBO;
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
////		/// Insert : NV_TAIKHOAN
////		/// Thêm dữ liệu
////		///</summary>
////		public bool Insert(NVTAIKHOANBO objNVTAIKHOANBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NV_TAIKHOAN_ADD");

////				objIData.AddParameter(P_Manv, objNVTAIKHOANBO.Manv);
////				objIData.AddParameter(P_Password, objNVTAIKHOANBO.Password);
////				objIData.AddParameter(P_Roleid, objNVTAIKHOANBO.Roleid);
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
////		/// Update : NV_TAIKHOAN
////		/// Cập nhật dữ liệu
////		///</summary>
////		public bool Update(NVTAIKHOANBO objNVTAIKHOANBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NV_TAIKHOAN_UPD");
////				objIData.AddParameter(P_Manv, objNVTAIKHOANBO.Manv);
////				objIData.AddParameter(P_Password, objNVTAIKHOANBO.Password);
////				objIData.AddParameter(P_Roleid, objNVTAIKHOANBO.Roleid);
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
////		/// Delete : NV_TAIKHOAN
////		/// Xóa dữ liệu
////		///</summary>
////		public bool Delete(NVTAIKHOANBO objNVTAIKHOANBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NV_TAIKHOAN_DEL");
////				objIData.AddParameter(P_Manv, objNVTAIKHOANBO.Manv);
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
////		/// SearchData : NV_TAIKHOAN
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
////				objIData.CreateNewStoredProcedure("NV_TAIKHOAN_SRH");
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

////		public const String P_Manv = "@" + C_Manv;
////		public const String P_Password = "@" + C_Password;
////		public const String P_Roleid = "@" + C_Roleid;

////		#endregion //Parameter names

////		#region Column Names

////		public const String C_Manv = "Manv";
////		public const String C_Password = "Password";
////		public const String C_Roleid = "Roleid";

////		#endregion //Column names

////		#endregion Variable Static		
////	}
////}
