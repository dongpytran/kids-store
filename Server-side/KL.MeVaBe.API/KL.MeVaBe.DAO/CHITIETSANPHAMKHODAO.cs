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
//	/// Quan Ly Chi Tiet San Pham Kho
//	/// </summary>	
//	public class CHITIETSANPHAMKHODAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public CHITIETSANPHAMKHODAO()
//		{
//		}
//		public CHITIETSANPHAMKHODAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public CHITIETSANPHAMKHOBO LoadInfo(string strMachitietkho)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("CHITIETSANPHAMKHO_SEL");
//				objIData.AddParameter(P_Machitietkho, strMachitietkho);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	CHITIETSANPHAMKHOBO objCHITIETSANPHAMKHOBO = new CHITIETSANPHAMKHOBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Machitietkho]))  objCHITIETSANPHAMKHOBO.Machitietkho = Convert.ToString(reader[C_Machitietkho]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Makho]))  objCHITIETSANPHAMKHOBO.Makho = Convert.ToString(reader[C_Makho]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Masp]))  objCHITIETSANPHAMKHOBO.Masp = Convert.ToString(reader[C_Masp]).Trim();
// 					objCHITIETSANPHAMKHOBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objCHITIETSANPHAMKHOBO.IsExist = false;
// 				}
//				reader.Close();
//				return objCHITIETSANPHAMKHOBO;
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
//		/// Insert : CHITIETSANPHAMKHO
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(CHITIETSANPHAMKHOBO objCHITIETSANPHAMKHOBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("CHITIETSANPHAMKHO_ADD");

//				objIData.AddParameter(P_Machitietkho, objCHITIETSANPHAMKHOBO.Machitietkho);
//				objIData.AddParameter(P_Makho, objCHITIETSANPHAMKHOBO.Makho);
//				objIData.AddParameter(P_Masp, objCHITIETSANPHAMKHOBO.Masp);
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
//		/// Update : CHITIETSANPHAMKHO
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(CHITIETSANPHAMKHOBO objCHITIETSANPHAMKHOBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("CHITIETSANPHAMKHO_UPD");
//				objIData.AddParameter(P_Machitietkho, objCHITIETSANPHAMKHOBO.Machitietkho);
//				objIData.AddParameter(P_Makho, objCHITIETSANPHAMKHOBO.Makho);
//				objIData.AddParameter(P_Masp, objCHITIETSANPHAMKHOBO.Masp);
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
//		/// Delete : CHITIETSANPHAMKHO
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(CHITIETSANPHAMKHOBO objCHITIETSANPHAMKHOBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("CHITIETSANPHAMKHO_DEL");
//				objIData.AddParameter(P_Machitietkho, objCHITIETSANPHAMKHOBO.Machitietkho);
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
//		/// SearchData : CHITIETSANPHAMKHO
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
//				objIData.CreateNewStoredProcedure("CHITIETSANPHAMKHO_SRH");
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

//		public const String P_Machitietkho = "@" + C_Machitietkho;
//		public const String P_Makho = "@" + C_Makho;
//		public const String P_Masp = "@" + C_Masp;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Machitietkho = "Machitietkho";
//		public const String C_Makho = "Makho";
//		public const String C_Masp = "Masp";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
