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
//	/// Quan Ly SP_Vi Tri Trung Bay
//	/// </summary>	
//	public class SPVITRITRUNGBAYDAO
//	{
//		private IData objDataAccess = null;

//		public IData DataAccess
//		{
//  			get { return objDataAccess; }
//   			set { objDataAccess = value; }
//		}

//		#region Constructor
//		public SPVITRITRUNGBAYDAO()
//		{
//		}
//		public SPVITRITRUNGBAYDAO(ProcessManager objProcessManager)
//		{
//			objDataAccess = objProcessManager.DataAccess;
//		}
//		#endregion

//		#region Methods

//		///<summary>
//		/// Nạp thông tin từ CSDL
//		///</summary>
//		/// <returns>OjbectBO</returns>
//		public SPVITRITRUNGBAYBO LoadInfo(string strMavitri)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_VITRITRUNGBAY_SEL");
//				objIData.AddParameter(P_Mavitri, strMavitri);
//				IDataReader reader = objIData.ExecStoreToDataReader();
// 		    	SPVITRITRUNGBAYBO objSPVITRITRUNGBAYBO = new SPVITRITRUNGBAYBO();
//				if (reader.Read())
// 				{
// 					if (!Convert.IsDBNull(reader[C_Mavitri]))  objSPVITRITRUNGBAYBO.Mavitri = Convert.ToString(reader[C_Mavitri]).Trim();
// 					if (!Convert.IsDBNull(reader[C_Maloai]))  objSPVITRITRUNGBAYBO.Maloai = Convert.ToString(reader[C_Maloai]).Trim();
// 					objSPVITRITRUNGBAYBO.IsExist = true;
// 				}
// 				else
// 				{
// 					objSPVITRITRUNGBAYBO.IsExist = false;
// 				}
//				reader.Close();
//				return objSPVITRITRUNGBAYBO;
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
//		/// Insert : SP_VITRITRUNGBAY
//		/// Thêm dữ liệu
//		///</summary>
//		public bool Insert(SPVITRITRUNGBAYBO objSPVITRITRUNGBAYBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_VITRITRUNGBAY_ADD");

//				objIData.AddParameter(P_Mavitri, objSPVITRITRUNGBAYBO.Mavitri);
//				objIData.AddParameter(P_Maloai, objSPVITRITRUNGBAYBO.Maloai);
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
//		/// Update : SP_VITRITRUNGBAY
//		/// Cập nhật dữ liệu
//		///</summary>
//		public bool Update(SPVITRITRUNGBAYBO objSPVITRITRUNGBAYBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_VITRITRUNGBAY_UPD");
//				objIData.AddParameter(P_Mavitri, objSPVITRITRUNGBAYBO.Mavitri);
//				objIData.AddParameter(P_Maloai, objSPVITRITRUNGBAYBO.Maloai);
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
//		/// Delete : SP_VITRITRUNGBAY
//		/// Xóa dữ liệu
//		///</summary>
//		public bool Delete(SPVITRITRUNGBAYBO objSPVITRITRUNGBAYBO)
//		{
// 			IData objIData;
// 		    if (objDataAccess == null)
// 		        objIData = Data.CreateData();
// 		    else
// 		        objIData = objDataAccess;
//			try 
//			{
//				objIData.Connect();
//				objIData.CreateNewStoredProcedure("SP_VITRITRUNGBAY_DEL");
//				objIData.AddParameter(P_Mavitri, objSPVITRITRUNGBAYBO.Mavitri);
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
//		/// SearchData : SP_VITRITRUNGBAY
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
//				objIData.CreateNewStoredProcedure("SP_VITRITRUNGBAY_SRH");
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

//		public const String P_Mavitri = "@" + C_Mavitri;
//		public const String P_Maloai = "@" + C_Maloai;

//		#endregion //Parameter names

//		#region Column Names

//		public const String C_Mavitri = "Mavitri";
//		public const String C_Maloai = "Maloai";

//		#endregion //Column names

//		#endregion Variable Static		
//	}
//}
