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
////	/// Quan Ly SP_Thuong Hieu
////	/// </summary>	
////	public class SPTHUONGHIEUDAO
////	{
////		private IData objDataAccess = null;

////		public IData DataAccess
////		{
////  			get { return objDataAccess; }
////   			set { objDataAccess = value; }
////		}

////		#region Constructor
////		public SPTHUONGHIEUDAO()
////		{
////		}
////		public SPTHUONGHIEUDAO(ProcessManager objProcessManager)
////		{
////			objDataAccess = objProcessManager.DataAccess;
////		}
////		#endregion

////		#region Methods

////		///<summary>
////		/// Nạp thông tin từ CSDL
////		///</summary>
////		/// <returns>OjbectBO</returns>
////		public SPTHUONGHIEUBO LoadInfo(string strMathuonghieu)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("SP_THUONGHIEU_SEL");
////				objIData.AddParameter(P_Mathuonghieu, strMathuonghieu);
////				IDataReader reader = objIData.ExecStoreToDataReader();
//// 		    	SPTHUONGHIEUBO objSPTHUONGHIEUBO = new SPTHUONGHIEUBO();
////				if (reader.Read())
//// 				{
//// 					if (!Convert.IsDBNull(reader[C_Mathuonghieu]))  objSPTHUONGHIEUBO.Mathuonghieu = Convert.ToString(reader[C_Mathuonghieu]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Tenthuonghieu]))  objSPTHUONGHIEUBO.Tenthuonghieu = Convert.ToString(reader[C_Tenthuonghieu]).Trim();
//// 					objSPTHUONGHIEUBO.IsExist = true;
//// 				}
//// 				else
//// 				{
//// 					objSPTHUONGHIEUBO.IsExist = false;
//// 				}
////				reader.Close();
////				return objSPTHUONGHIEUBO;
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
////		/// Insert : SP_THUONGHIEU
////		/// Thêm dữ liệu
////		///</summary>
////		public bool Insert(SPTHUONGHIEUBO objSPTHUONGHIEUBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("SP_THUONGHIEU_ADD");

////				objIData.AddParameter(P_Mathuonghieu, objSPTHUONGHIEUBO.Mathuonghieu);
////				objIData.AddParameter(P_Tenthuonghieu, objSPTHUONGHIEUBO.Tenthuonghieu);
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
////		/// Update : SP_THUONGHIEU
////		/// Cập nhật dữ liệu
////		///</summary>
////		public bool Update(SPTHUONGHIEUBO objSPTHUONGHIEUBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("SP_THUONGHIEU_UPD");
////				objIData.AddParameter(P_Mathuonghieu, objSPTHUONGHIEUBO.Mathuonghieu);
////				objIData.AddParameter(P_Tenthuonghieu, objSPTHUONGHIEUBO.Tenthuonghieu);
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
////		/// Delete : SP_THUONGHIEU
////		/// Xóa dữ liệu
////		///</summary>
////		public bool Delete(SPTHUONGHIEUBO objSPTHUONGHIEUBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("SP_THUONGHIEU_DEL");
////				objIData.AddParameter(P_Mathuonghieu, objSPTHUONGHIEUBO.Mathuonghieu);
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
////		/// SearchData : SP_THUONGHIEU
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
////				objIData.CreateNewStoredProcedure("SP_THUONGHIEU_SRH");
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

////		public const String P_Mathuonghieu = "@" + C_Mathuonghieu;
////		public const String P_Tenthuonghieu = "@" + C_Tenthuonghieu;

////		#endregion //Parameter names

////		#region Column Names

////		public const String C_Mathuonghieu = "Mathuonghieu";
////		public const String C_Tenthuonghieu = "Tenthuonghieu";

////		#endregion //Column names

////		#endregion Variable Static		
////	}
////}
