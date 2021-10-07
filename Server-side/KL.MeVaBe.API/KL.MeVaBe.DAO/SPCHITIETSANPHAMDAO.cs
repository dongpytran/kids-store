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
//	/// Quan Ly Chi Tiet San Pham
//	/// </summary>	
//	public class SPCHITIETSANPHAMDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public SPCHITIETSANPHAMDAO()
//		{
//		}
//		public SPCHITIETSANPHAMDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public SPCHITIETSANPHAMBO LoadInfo(string strMasp)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_CHITIETSANPHAM_SEL");
//				objIData.AddParameter(P_Masp, strMasp);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	SPCHITIETSANPHAMBO objSPCHITIETSANPHAMBO = new SPCHITIETSANPHAMBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Masp]))  objSPCHITIETSANPHAMBO.Masp = Convert.ToString(reader[C_Masp]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Trongluong]))  objSPCHITIETSANPHAMBO.Trongluong = Convert.ToInt32(reader[C_Trongluong]);
// 					if (!Convert.IsDBNull(reader[C_Dacdiem]))  objSPCHITIETSANPHAMBO.Dacdiem = Convert.ToString(reader[C_Dacdiem]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Mota]))  objSPCHITIETSANPHAMBO.Mota = Convert.ToString(reader[C_Mota]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Mausac]))  objSPCHITIETSANPHAMBO.Mausac = Convert.ToString(reader[C_Mausac]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Kichco]))  objSPCHITIETSANPHAMBO.Kichco = Convert.ToString(reader[C_Kichco]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Tongsl]))  objSPCHITIETSANPHAMBO.Tongsl = Convert.ToInt32(reader[C_Tongsl]);
// 					if (!Convert.IsDBNull(reader[C_Dongia]))  objSPCHITIETSANPHAMBO.Dongia = Convert.ToInt64(reader[C_Dongia]);
// 					objSPCHITIETSANPHAMBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objSPCHITIETSANPHAMBO.IsExist = false;
// 				}
//				reader.Close();
//				return objSPCHITIETSANPHAMBO;
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
//		/// Insert : SP_CHITIETSANPHAM
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(SPCHITIETSANPHAMBO objSPCHITIETSANPHAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_CHITIETSANPHAM_ADD");

//				objIData.AddParameter(P_Masp, objSPCHITIETSANPHAMBO.Masp);
//				objIData.AddParameter(P_Trongluong, objSPCHITIETSANPHAMBO.Trongluong);
//				objIData.AddParameter(P_Dacdiem, objSPCHITIETSANPHAMBO.Dacdiem);
//				objIData.AddParameter(P_Mota, objSPCHITIETSANPHAMBO.Mota);
//				objIData.AddParameter(P_Mausac, objSPCHITIETSANPHAMBO.Mausac);
//				objIData.AddParameter(P_Kichco, objSPCHITIETSANPHAMBO.Kichco);
//				objIData.AddParameter(P_Tongsl, objSPCHITIETSANPHAMBO.Tongsl);
//				objIData.AddParameter(P_Dongia, objSPCHITIETSANPHAMBO.Dongia);
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
//		/// Update : SP_CHITIETSANPHAM
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(SPCHITIETSANPHAMBO objSPCHITIETSANPHAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_CHITIETSANPHAM_UPD");
//				objIData.AddParameter(P_Masp, objSPCHITIETSANPHAMBO.Masp);
//				objIData.AddParameter(P_Trongluong, objSPCHITIETSANPHAMBO.Trongluong);
//				objIData.AddParameter(P_Dacdiem, objSPCHITIETSANPHAMBO.Dacdiem);
//				objIData.AddParameter(P_Mota, objSPCHITIETSANPHAMBO.Mota);
//				objIData.AddParameter(P_Mausac, objSPCHITIETSANPHAMBO.Mausac);
//				objIData.AddParameter(P_Kichco, objSPCHITIETSANPHAMBO.Kichco);
//				objIData.AddParameter(P_Tongsl, objSPCHITIETSANPHAMBO.Tongsl);
//				objIData.AddParameter(P_Dongia, objSPCHITIETSANPHAMBO.Dongia);
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
//		/// Delete : SP_CHITIETSANPHAM
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(SPCHITIETSANPHAMBO objSPCHITIETSANPHAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_CHITIETSANPHAM_DEL");
//				objIData.AddParameter(P_Masp, objSPCHITIETSANPHAMBO.Masp);
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
//		/// SearchData : SP_CHITIETSANPHAM
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
//				objIData.CreateNewStoredProcedure("SP_CHITIETSANPHAM_SRH");
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
//		public const String P_Trongluong = "@" + C_Trongluong;
//		public const String P_Dacdiem = "@" + C_Dacdiem;
//		public const String P_Mota = "@" + C_Mota;
//		public const String P_Mausac = "@" + C_Mausac;
//		public const String P_Kichco = "@" + C_Kichco;
//		public const String P_Tongsl = "@" + C_Tongsl;
//		public const String P_Dongia = "@" + C_Dongia;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Masp = "Masp";
//		public const String C_Trongluong = "Trongluong";
//		public const String C_Dacdiem = "Dacdiem";
//		public const String C_Mota = "Mota";
//		public const String C_Mausac = "Mausac";
//		public const String C_Kichco = "Kichco";
//		public const String C_Tongsl = "Tongsl";
//		public const String C_Dongia = "Dongia";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
