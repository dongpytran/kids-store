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
//	/// Quan Ly Phuong Thuc Thanh Toan
//	/// </summary>	
//	public class KHDHPHUONGTHUCTTDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public KHDHPHUONGTHUCTTDAO()
//		{
//		}
//		public KHDHPHUONGTHUCTTDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public KHDHPHUONGTHUCTTBO LoadInfo(string strMaphuongthuctt)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_DH_PHUONGTHUCTT_SEL");
//				objIData.AddParameter(P_Maphuongthuctt, strMaphuongthuctt);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	KHDHPHUONGTHUCTTBO objKHDHPHUONGTHUCTTBO = new KHDHPHUONGTHUCTTBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Maphuongthuctt]))  objKHDHPHUONGTHUCTTBO.Maphuongthuctt = Convert.ToString(reader[C_Maphuongthuctt]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Tenphuongthuctt]))  objKHDHPHUONGTHUCTTBO.Tenphuongthuctt = Convert.ToString(reader[C_Tenphuongthuctt]).Trim();
// 					objKHDHPHUONGTHUCTTBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objKHDHPHUONGTHUCTTBO.IsExist = false;
// 				}
//				reader.Close();
//				return objKHDHPHUONGTHUCTTBO;
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
//		/// Insert : KH_DH_PHUONGTHUCTT
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(KHDHPHUONGTHUCTTBO objKHDHPHUONGTHUCTTBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_DH_PHUONGTHUCTT_ADD");

//				objIData.AddParameter(P_Maphuongthuctt, objKHDHPHUONGTHUCTTBO.Maphuongthuctt);
//				objIData.AddParameter(P_Tenphuongthuctt, objKHDHPHUONGTHUCTTBO.Tenphuongthuctt);
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
//		/// Update : KH_DH_PHUONGTHUCTT
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(KHDHPHUONGTHUCTTBO objKHDHPHUONGTHUCTTBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_DH_PHUONGTHUCTT_UPD");
//				objIData.AddParameter(P_Maphuongthuctt, objKHDHPHUONGTHUCTTBO.Maphuongthuctt);
//				objIData.AddParameter(P_Tenphuongthuctt, objKHDHPHUONGTHUCTTBO.Tenphuongthuctt);
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
//		/// Delete : KH_DH_PHUONGTHUCTT
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(KHDHPHUONGTHUCTTBO objKHDHPHUONGTHUCTTBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("KH_DH_PHUONGTHUCTT_DEL");
//				objIData.AddParameter(P_Maphuongthuctt, objKHDHPHUONGTHUCTTBO.Maphuongthuctt);
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
//		/// SearchData : KH_DH_PHUONGTHUCTT
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
//				objIData.CreateNewStoredProcedure("KH_DH_PHUONGTHUCTT_SRH");
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

//		public const String P_Maphuongthuctt = "@" + C_Maphuongthuctt;
//		public const String P_Tenphuongthuctt = "@" + C_Tenphuongthuctt;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Maphuongthuctt = "Maphuongthuctt";
//		public const String C_Tenphuongthuctt = "Tenphuongthuctt";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
