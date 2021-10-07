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
////	/// Quan Ly Quyen Tai Khoan
////	/// </summary>	
////	public class NVQUYENTAIKHOANDAO
////	{
////		private IData objDataAccess = null;

////		public IData DataAccess
////		{
////  			get { return objDataAccess; }
////   			set { objDataAccess = value; }
////		}

////		#region Constructor
////		public NVQUYENTAIKHOANDAO()
////		{
////		}
////		public NVQUYENTAIKHOANDAO(ProcessManager objProcessManager)
////		{
////			objDataAccess = objProcessManager.DataAccess;
////		}
////		#endregion

////		#region Methods

////		///<summary>
////		/// Nạp thông tin từ CSDL
////		///</summary>
////		/// <returns>OjbectBO</returns>
////		public NVQUYENTAIKHOANBO LoadInfo(int intRoleid)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NV_QUYENTAIKHOAN_SEL");
////				objIData.AddParameter(P_Roleid, intRoleid);
////				IDataReader reader = objIData.ExecStoreToDataReader();
//// 		    	NVQUYENTAIKHOANBO objNVQUYENTAIKHOANBO = new NVQUYENTAIKHOANBO();
////				if (reader.Read())
//// 				{
//// 					if (!Convert.IsDBNull(reader[C_Roleid]))  objNVQUYENTAIKHOANBO.Roleid = Convert.ToInt32(reader[C_Roleid]);
//// 					if (!Convert.IsDBNull(reader[C_Rolename]))  objNVQUYENTAIKHOANBO.Rolename = Convert.ToString(reader[C_Rolename]).Trim();
//// 					objNVQUYENTAIKHOANBO.IsExist = true;
//// 				}
//// 				else
//// 				{
//// 					objNVQUYENTAIKHOANBO.IsExist = false;
//// 				}
////				reader.Close();
////				return objNVQUYENTAIKHOANBO;
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
////		/// Insert : NV_QUYENTAIKHOAN
////		/// Thêm dữ liệu
////		///</summary>
////		public bool Insert(NVQUYENTAIKHOANBO objNVQUYENTAIKHOANBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NV_QUYENTAIKHOAN_ADD");

////				objIData.AddParameter(P_Roleid, objNVQUYENTAIKHOANBO.Roleid);
////				objIData.AddParameter(P_Rolename, objNVQUYENTAIKHOANBO.Rolename);
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
////		/// Update : NV_QUYENTAIKHOAN
////		/// Cập nhật dữ liệu
////		///</summary>
////		public bool Update(NVQUYENTAIKHOANBO objNVQUYENTAIKHOANBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NV_QUYENTAIKHOAN_UPD");
////				objIData.AddParameter(P_Roleid, objNVQUYENTAIKHOANBO.Roleid);
////				objIData.AddParameter(P_Rolename, objNVQUYENTAIKHOANBO.Rolename);
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
////		/// Delete : NV_QUYENTAIKHOAN
////		/// Xóa dữ liệu
////		///</summary>
////		public bool Delete(NVQUYENTAIKHOANBO objNVQUYENTAIKHOANBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("NV_QUYENTAIKHOAN_DEL");
////				objIData.AddParameter(P_Roleid, objNVQUYENTAIKHOANBO.Roleid);
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
////		/// SearchData : NV_QUYENTAIKHOAN
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
////				objIData.CreateNewStoredProcedure("NV_QUYENTAIKHOAN_SRH");
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

////		public const String P_Roleid = "@" + C_Roleid;
////		public const String P_Rolename = "@" + C_Rolename;

////		#endregion //Parameter names

////		#region Column Names

////		public const String C_Roleid = "Roleid";
////		public const String C_Rolename = "Rolename";

////		#endregion //Column names

////		#endregion Variable Static		
////	}
////}
