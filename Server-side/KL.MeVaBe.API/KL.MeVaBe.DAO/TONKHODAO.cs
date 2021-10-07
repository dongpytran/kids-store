////#region Using
////using System;
////using System.Data;
////using System.Collections;
////using System.Collections.Generic;
////using TGDD.Library.Data;
////using KL.MeVaBe.DAO;
////using TGDD.Library.Framework;
////#endregion

////namespace KL.MeVaBe.DAOTONKHODAO
////{
////    /// <summary>
////	/// Created by 		: Dong Py 
////	/// Created date 	: 10/5/2021 
////	/// Quan Ly Ton Kho
////	/// </summary>	
////	public class TONKHODAO
////	{
////		private IData objDataAccess = null;

////		public IData DataAccess
////		{
////  			get { return objDataAccess; }
////   			set { objDataAccess = value; }
////		}

////		#region Constructor
////		public TONKHODAO()
////		{
////		}
////		public TONKHODAO(ProcessManager objProcessManager)
////		{
////			objDataAccess = objProcessManager.DataAccess;
////		}
////		#endregion

////		#region Methods

////		///<summary>
////		/// Nạp thông tin từ CSDL
////		///</summary>
////		/// <returns>OjbectBO</returns>
////		public ToNKHOBO LoadInfo(string strMachitietkho)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("TONKHO_SEL");
////				objIData.AddParameter(P_Machitietkho, strMachitietkho);
////				IDataReader reader = objIData.ExecStoreToDataReader();
//// 		    	ToNKHOBO objToNKHOBO = new ToNKHOBO();
////				if (reader.Read())
//// 				{
//// 					if (!Convert.IsDBNull(reader[C_Machitietkho]))  objToNKHOBO.Machitietkho = Convert.ToString(reader[C_Machitietkho]).Trim();
//// 					if (!Convert.IsDBNull(reader[C_Soluongnhap]))  objToNKHOBO.Soluongnhap = Convert.ToInt32(reader[C_Soluongnhap]);
//// 					if (!Convert.IsDBNull(reader[C_Soluongxuat]))  objToNKHOBO.Soluongxuat = Convert.ToInt32(reader[C_Soluongxuat]);
//// 					if (!Convert.IsDBNull(reader[C_Soluongton]))  objToNKHOBO.Soluongton = Convert.ToInt32(reader[C_Soluongton]);
//// 					objToNKHOBO.IsExist = true;
//// 				}
//// 				else
//// 				{
//// 					objToNKHOBO.IsExist = false;
//// 				}
////				reader.Close();
////				return objToNKHOBO;
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
////		/// Insert : TONKHO
////		/// Thêm dữ liệu
////		///</summary>
////		public bool Insert(ToNKHOBO objToNKHOBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("TONKHO_ADD");

////				objIData.AddParameter(P_Machitietkho, objToNKHOBO.Machitietkho);
////				objIData.AddParameter(P_Soluongnhap, objToNKHOBO.Soluongnhap);
////				objIData.AddParameter(P_Soluongxuat, objToNKHOBO.Soluongxuat);
////				objIData.AddParameter(P_Soluongton, objToNKHOBO.Soluongton);
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
////		/// Update : TONKHO
////		/// Cập nhật dữ liệu
////		///</summary>
////		public bool Update(ToNKHOBO objToNKHOBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("TONKHO_UPD");
////				objIData.AddParameter(P_Machitietkho, objToNKHOBO.Machitietkho);
////				objIData.AddParameter(P_Soluongnhap, objToNKHOBO.Soluongnhap);
////				objIData.AddParameter(P_Soluongxuat, objToNKHOBO.Soluongxuat);
////				objIData.AddParameter(P_Soluongton, objToNKHOBO.Soluongton);
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
////		/// Delete : TONKHO
////		/// Xóa dữ liệu
////		///</summary>
////		public bool Delete(ToNKHOBO objToNKHOBO)
////		{
//// 			IData objIData;
//// 		    if (objDataAccess == null)
//// 		        objIData = Data.CreateData();
//// 		    else
//// 		        objIData = objDataAccess;
////			try 
////			{
////				objIData.Connect();
////				objIData.CreateNewStoredProcedure("TONKHO_DEL");
////				objIData.AddParameter(P_Machitietkho, objToNKHOBO.Machitietkho);
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
////		/// SearchData : TONKHO
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
////				objIData.CreateNewStoredProcedure("TONKHO_SRH");
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

////		public const String P_Machitietkho = "@" + C_Machitietkho;
////		public const String P_Soluongnhap = "@" + C_Soluongnhap;
////		public const String P_Soluongxuat = "@" + C_Soluongxuat;
////		public const String P_Soluongton = "@" + C_Soluongton;

////		#endregion //Parameter names

////		#region Column Names

////		public const String C_Machitietkho = "Machitietkho";
////		public const String C_Soluongnhap = "Soluongnhap";
////		public const String C_Soluongxuat = "Soluongxuat";
////		public const String C_Soluongton = "Soluongton";

////		#endregion //Column names

////		#endregion Variable Static		
////	}
////}
