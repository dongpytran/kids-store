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
////	/// Quan Ly SP_Xuat Xu
////	/// </summary>	
////	public class SPXUATXUDAO
////	{
////		private IData objDataAccess = null;

////		public IData DataAccess
////		{
////  			get { return objDataAccess; }
////   			set { objDataAccess = value; }
////		}

////		#region Constructor
////		public SPXUATXUDAO()
////		{
////		}
////		public SPXUATXUDAO(ProcessManager objProcessManager)
////		{
////			objDataAccess = objProcessManager.DataAccess;
////		}
////		#endregion

////		#region Methods

////		///<summary>
////		/// Nạp thông tin từ CSDL
////		///</summary>
////		/// <returns>OjbectBO</returns>
////		public SPXUATXUBO LoadInfo(string strMaxuatxu)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("SP_XUATXU_SEL");
////				objIData.AddParameter(P_Maxuatxu, strMaxuatxu);
////				IDataReader reader = objIData.ExecStoreToDataReader();
//// 		    	SPXUATXUBO objSPXUATXUBO = new SPXUATXUBO();
////				if (reader.Read())
//// 				{
//// 					if (!Convert.IsDBNull(reader[C_Maxuatxu]))  objSPXUATXUBO.Maxuatxu = Convert.ToString(reader[C_Maxuatxu]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Noixuatxu]))  objSPXUATXUBO.Noixuatxu = Convert.ToString(reader[C_Noixuatxu]).Trim();
//// 					objSPXUATXUBO.IsExist = true;
//// 				}
//// 				else
//// 				{
//// 					objSPXUATXUBO.IsExist = false;
//// 				}
////				reader.Close();
////				return objSPXUATXUBO;
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
////		/// Insert : SP_XUATXU
////		/// Thêm dữ liệu
////		///</summary>
////		public bool Insert(SPXUATXUBO objSPXUATXUBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("SP_XUATXU_ADD");

////				objIData.AddParameter(P_Maxuatxu, objSPXUATXUBO.Maxuatxu);
////				objIData.AddParameter(P_Noixuatxu, objSPXUATXUBO.Noixuatxu);
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
////		/// Update : SP_XUATXU
////		/// Cập nhật dữ liệu
////		///</summary>
////		public bool Update(SPXUATXUBO objSPXUATXUBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("SP_XUATXU_UPD");
////				objIData.AddParameter(P_Maxuatxu, objSPXUATXUBO.Maxuatxu);
////				objIData.AddParameter(P_Noixuatxu, objSPXUATXUBO.Noixuatxu);
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
////		/// Delete : SP_XUATXU
////		/// Xóa dữ liệu
////		///</summary>
////		public bool Delete(SPXUATXUBO objSPXUATXUBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("SP_XUATXU_DEL");
////				objIData.AddParameter(P_Maxuatxu, objSPXUATXUBO.Maxuatxu);
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
////		/// SearchData : SP_XUATXU
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
////				objIData.CreateNewStoredProcedure("SP_XUATXU_SRH");
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

////		public const String P_Maxuatxu = "@" + C_Maxuatxu;
////		public const String P_Noixuatxu = "@" + C_Noixuatxu;

////		#endregion //Parameter names

////		#region Column Names

////		public const String C_Maxuatxu = "Maxuatxu";
////		public const String C_Noixuatxu = "Noixuatxu";

////		#endregion //Column names

////		#endregion Variable Static		
////	}
////}
