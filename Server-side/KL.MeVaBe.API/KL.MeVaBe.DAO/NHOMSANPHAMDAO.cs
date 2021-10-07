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
//	/// Quan Ly Nhom San Pham
//	/// </summary>	
//	public class NHOMSANPHAMDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public NHOMSANPHAMDAO()
//		{
//		}
//		public NHOMSANPHAMDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public NHOMSANPHAMBO LoadInfo(string strManhomsp, string strMasp)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NHOMSANPHAM_SEL");
//				objIData.AddParameter(P_Manhomsp, strManhomsp);
//				objIData.AddParameter(P_Masp, strMasp);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	NHOMSANPHAMBO objNHOMSANPHAMBO = new NHOMSANPHAMBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Manhomsp]))  objNHOMSANPHAMBO.Manhomsp = Convert.ToString(reader[C_Manhomsp]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Masp]))  objNHOMSANPHAMBO.Masp = Convert.ToString(reader[C_Masp]).Trim();
// 					objNHOMSANPHAMBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objNHOMSANPHAMBO.IsExist = false;
// 				}
//				reader.Close();
//				return objNHOMSANPHAMBO;
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
//		/// Insert : NHOMSANPHAM
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(NHOMSANPHAMBO objNHOMSANPHAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NHOMSANPHAM_ADD");

//				objIData.AddParameter(P_Manhomsp, objNHOMSANPHAMBO.Manhomsp);
//				objIData.AddParameter(P_Masp, objNHOMSANPHAMBO.Masp);
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
//		/// Update : NHOMSANPHAM
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(NHOMSANPHAMBO objNHOMSANPHAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NHOMSANPHAM_UPD");
//				objIData.AddParameter(P_Manhomsp, objNHOMSANPHAMBO.Manhomsp);
//				objIData.AddParameter(P_Masp, objNHOMSANPHAMBO.Masp);
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
//		/// Delete : NHOMSANPHAM
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(NHOMSANPHAMBO objNHOMSANPHAMBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("NHOMSANPHAM_DEL");
//				objIData.AddParameter(P_Manhomsp, objNHOMSANPHAMBO.Manhomsp);
//				objIData.AddParameter(P_Masp, objNHOMSANPHAMBO.Masp);
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
//		/// SearchData : NHOMSANPHAM
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
//				objIData.CreateNewStoredProcedure("NHOMSANPHAM_SRH");
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

//		public const String P_Manhomsp = "@" + C_Manhomsp;
//		public const String P_Masp = "@" + C_Masp;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Manhomsp = "Manhomsp";
//		public const String C_Masp = "Masp";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
