#region Using
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using KL.MeVaBe.BO;
using KL.MeVaBe.DAO;
#endregion

namespace KL.MeVaBe.BLL
{
    /// <summary>
	/// Created by 		: Dong Py 
	/// Created date 	: 10/5/2021 
	/// Quan Ly Chuc Vu Nhan Vien
	/// </summary>	
	public class NVCHUCVUBLL
	{
	
		#region Constructor
		public NVCHUCVUBLL()
		{
		}
		#endregion

		#region Methods			
		
		///<summary>
		/// Nạp thông tin từ CSDL
		///</summary>
		/// <returns>true ? Có : False ? Không</returns>
		public NVCHUCVUBO LoadInfo(string strMachucvu)
		{
			NVCHUCVUBO objNVCHUCVUBO = null;
			try 
			{
				NVCHUCVUDAO objNVCHUCVUDAO = new NVCHUCVUDAO();
				objNVCHUCVUBO = objNVCHUCVUDAO.LoadInfo(strMachucvu);
			}
			catch (Exception objEx)
			{
				throw objEx;
			}
    		return objNVCHUCVUBO;
		}
		///<summary>
		/// Insert : NV_CHUCVU
		/// Thêm dữ liệu
		///</summary>
		//public bool Insert(NVCHUCVUBO objNVCHUCVUBO)
		//{
		//	try 
		//	{
		//		NVCHUCVUDAO objNVCHUCVUDAO = new NVCHUCVUDAO();
		//		return objNVCHUCVUDAO.Insert(objNVCHUCVUBO);
		//	}
		//	catch (Exception objEx)
		//	{
		//		objResultMessageBO = ResultMessageDAO.InitResultMessage(true, SystemErrorBO.ErrorTypes.Insert
		//			, "Lỗi thêm thông tin NVCHUCVUItem", objEx, "NVCHUCVU -> Insert", "Quan Ly Chuc Vu Nhan Vien");
  //  			return false;
		//	}
		//}

		/////<summary>
		///// Update : NV_CHUCVU
		///// Cập nhật dữ liệu
		/////</summary>
		//public bool Update(NVCHUCVUBO objNVCHUCVUBO)
		//{
		//	try 
		//	{
		//		NVCHUCVUDAO objNVCHUCVUDAO = new NVCHUCVUDAO();
		//		return objNVCHUCVUDAO.Update(objNVCHUCVUBO);
		//	}
		//	catch (Exception objEx)
		//	{
		//		objResultMessageBO = ResultMessageDAO.InitResultMessage(true, SystemErrorBO.ErrorTypes.Update
		//			, "Lỗi cập nhật thông tin NVCHUCVUItem", objEx, "NVCHUCVU -> Update", "Quan Ly Chuc Vu Nhan Vien");
  //  			return false;
		//	}
		//}

		/////<summary>
		///// Delete : NV_CHUCVU
		/////Xóa dữ liệu
		/////</summary>
		//public bool Delete(NVCHUCVUBO objNVCHUCVUBO)
		//{
		//	try 
		//	{
		//		NVCHUCVUDAO objNVCHUCVUDAO = new NVCHUCVUDAO();
		//		return objNVCHUCVUDAO.Delete(objNVCHUCVUBO);
		//	}
		//	catch (Exception objEx)
		//	{
		//		objResultMessageBO = ResultMessageDAO.InitResultMessage(true, SystemErrorBO.ErrorTypes.Delete
		//			, "Lỗi xóa thông tin NVCHUCVUItem", objEx, "NVCHUCVU -> Delete", "Quan Ly Chuc Vu Nhan Vien");
  //  			return false;
		//	}
		//}

		/////<summary>
		///// Get all : NV_CHUCVU
		/////nạp danh sách
		/////</summary>
		//public DataTable SearchData(params object[] objKeywords)
		//{
		//	try 
		//	{
		//		NVCHUCVUDAO objNVCHUCVUDAO = new NVCHUCVUDAO();
		//		return objNVCHUCVUDAO.SearchData(objKeywords);
		//	}
		//	catch (Exception objEx)
		//	{
		//		objResultMessageBO = ResultMessageDAO.InitResultMessage(true, SystemErrorBO.ErrorTypes.SearchData
		//			, "Lỗi nạp danh sách NVCHUCVUItem", objEx, "NVCHUCVU -> SearchData", "Quan Ly Chuc Vu Nhan Vien");
  //  			return null;
		//	}
		//}	
		
		#endregion	
	}
}
