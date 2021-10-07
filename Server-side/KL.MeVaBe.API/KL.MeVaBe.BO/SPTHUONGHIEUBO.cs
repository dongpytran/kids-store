#region Using
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
#endregion

namespace KL.MeVaBe.BO
{
    /// <summary>
	/// Created by 		: Dong Py 
	/// Created date 	: 10/5/2021 
	/// Quan Ly SP_Thuong Hieu
	/// </summary>	
	[Serializable]
	public class SPTHUONGHIEUBO
	{
		public SPTHUONGHIEUBO()
		{
		}

		private string strMathuonghieu = string.Empty;

		/// <summary>
		/// Mathuonghieu
		/// 
		/// </summary>
		public string Mathuonghieu
		{
			get { return  strMathuonghieu; }
			set { strMathuonghieu = value; }
		}

		private string strTenthuonghieu = string.Empty;

		/// <summary>
		/// Tenthuonghieu
		/// 
		/// </summary>
		public string Tenthuonghieu
		{
			get { return  strTenthuonghieu; }
			set { strTenthuonghieu = value; }
		}

		/// <summary>
		/// Có tồn tại không?
		/// </summary>
		public bool IsExist { get; set; }

		/// <summary>
		/// Có đang chọn không?
		/// </summary>
		public bool IsSelected { get; set; }

		/// <summary>
		/// Có chỉnh sữa không?
		/// </summary>
		public bool IsEdited { get; set; }

	}
}
