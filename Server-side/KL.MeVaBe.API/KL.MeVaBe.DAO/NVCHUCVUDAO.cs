#region Using
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using KL.MeVaBe.DAO;
using KL.MeVaBe.BO;
#endregion

namespace KL.MeVaBe.DAO
{
    /// <summary>
	/// Created by 		: Dong Py 
	/// Created date 	: 10/5/2021 
	/// Quan Ly Chuc Vu Nhan Vien
	/// </summary>	
	public class NVCHUCVUDAO
    {
        DataAccess da = new DataAccess();

        #region Constructor
        public NVCHUCVUDAO()
        {
            if(da.ConnectionString == "")
                da.CreateData();
        }
        #endregion

        #region Methods

        ///<summary>
        /// Nạp thông tin từ CSDL
        ///</summary>
        /// <returns>OjbectBO</returns>
        public NVCHUCVUBO LoadInfo(string strMachucvu)
        {
            if (da.ConnectionString == null)
                da.CreateData();
            try
            {
                da.Connect();
                da.CreateNewStoredProcedure("sp_NV_CHUCVU_GET_BY_ID");
                da.AddParameter(P_Machucvu, strMachucvu, SqlDbType.NChar);
                IDataReader reader = da.ExecStoreToDataReader();
                NVCHUCVUBO objNVCHUCVUBO = new NVCHUCVUBO();
                if (reader.Read())
                {
                    if (!Convert.IsDBNull(reader[C_Machucvu])) objNVCHUCVUBO.Machucvu = Convert.ToString(reader[C_Machucvu]).Trim();
                    if (!Convert.IsDBNull(reader[C_Tenchucvu])) objNVCHUCVUBO.Tenchucvu = Convert.ToString(reader[C_Tenchucvu]).Trim();
                    if (!Convert.IsDBNull(reader[C_Mucluong])) objNVCHUCVUBO.Mucluong = Convert.ToInt32(reader[C_Mucluong]);
                    objNVCHUCVUBO.IsExist = true;
                }
                else
                {
                    objNVCHUCVUBO.IsExist = false;
                }
                reader.Close();
                return objNVCHUCVUBO;
            }
            catch (Exception objEx)
            {
                throw objEx;
            }
            finally
            {
                da.Disconnect();
            }
        }

        ///<summary>
        /// Insert : NV_CHUCVU
        /// Thêm dữ liệu
        ///</summary>
        //public bool Insert(NVCHUCVUBO objNVCHUCVUBO)
        //{
        //    IData objIData;
        //    if (objDataAccess == null)
        //        objIData = Data.CreateData();
        //    else
        //        objIData = objDataAccess;
        //    try
        //    {
        //        objIData.Connect();
        //        objIData.CreateNewStoredProcedure("NV_CHUCVU_ADD");

        //        objIData.AddParameter(P_Machucvu, objNVCHUCVUBO.Machucvu);
        //        objIData.AddParameter(P_Tenchucvu, objNVCHUCVUBO.Tenchucvu);
        //        objIData.AddParameter(P_Mucluong, objNVCHUCVUBO.Mucluong);
        //        objIData.ExecNonQuery();
        //        return true;
        //    }
        //    catch (Exception objEx)
        //    {
        //        throw objEx;
        //    }
        //    finally
        //    {
        //        if (objDataAccess == null)
        //            objIData.Disconnect();
        //    }
        //}

        /////<summary>
        ///// Update : NV_CHUCVU
        ///// Cập nhật dữ liệu
        /////</summary>
        //public bool Update(NVCHUCVUBO objNVCHUCVUBO)
        //{
        //    IData objIData;
        //    if (objDataAccess == null)
        //        objIData = Data.CreateData();
        //    else
        //        objIData = objDataAccess;
        //    try
        //    {
        //        objIData.Connect();
        //        objIData.CreateNewStoredProcedure("NV_CHUCVU_UPD");
        //        objIData.AddParameter(P_Machucvu, objNVCHUCVUBO.Machucvu);
        //        objIData.AddParameter(P_Tenchucvu, objNVCHUCVUBO.Tenchucvu);
        //        objIData.AddParameter(P_Mucluong, objNVCHUCVUBO.Mucluong);
        //        objIData.ExecNonQuery();
        //        return true;
        //    }
        //    catch (Exception objEx)
        //    {
        //        throw objEx;
        //    }
        //    finally
        //    {
        //        if (objDataAccess == null)
        //            objIData.Disconnect();
        //    }
        //}

        /////<summary>
        ///// Delete : NV_CHUCVU
        ///// Xóa dữ liệu
        /////</summary>
        //public bool Delete(NVCHUCVUBO objNVCHUCVUBO)
        //{
        //    IData objIData;
        //    if (objDataAccess == null)
        //        objIData = Data.CreateData();
        //    else
        //        objIData = objDataAccess;
        //    try
        //    {
        //        objIData.Connect();
        //        objIData.CreateNewStoredProcedure("NV_CHUCVU_DEL");
        //        objIData.AddParameter(P_Machucvu, objNVCHUCVUBO.Machucvu);
        //        objIData.ExecNonQuery();
        //        return true;
        //    }
        //    catch (Exception objEx)
        //    {
        //        throw objEx;
        //    }
        //    finally
        //    {
        //        if (objDataAccess == null)
        //            objIData.Disconnect();
        //    }
        //}

        /////<summary>
        ///// SearchData : NV_CHUCVU
        ///// Nap dữ liệu
        /////</summary>
        //public DataTable SearchData(params object[] objKeywords)
        //{
        //    IData objIData;
        //    if (objDataAccess == null)
        //        objIData = Data.CreateData();
        //    else
        //        objIData = objDataAccess;
        //    try
        //    {
        //        objIData.Connect();
        //        objIData.CreateNewStoredProcedure("NV_CHUCVU_SRH");
        //        objIData.AddParameter(objKeywords);
        //        return objIData.ExecStoreToDataTable();
        //    }
        //    catch (Exception objEx)
        //    {
        //        throw objEx;
        //    }
        //    finally
        //    {
        //        if (objDataAccess == null)
        //            objIData.Disconnect();
        //    }
        //}

        #endregion

        #region Variable Static

        #region Parameter Names

        public const String P_Machucvu = "@" + C_Machucvu;
        public const String P_Tenchucvu = "@" + C_Tenchucvu;
        public const String P_Mucluong = "@" + C_Mucluong;

        #endregion //Parameter names

        #region Column Names

        public const String C_Machucvu = "Machucvu";
        public const String C_Tenchucvu = "Tenchucvu";
        public const String C_Mucluong = "Mucluong";

        #endregion //Column names

        #endregion Variable Static		
    }
}
