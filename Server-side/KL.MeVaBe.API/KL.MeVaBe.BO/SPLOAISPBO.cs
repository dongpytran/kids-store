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
	/// Quan Ly SP_Loai SP
	/// </summary>	
	[Serializable]
	public class SPLOAISPBO
	{
		public SPLOAISPBO()
		{
		}

		private string strMaloai = string.Empty;

		/// <summary>
		/// Maloai
		/// 
		/// </summary>
		public string Maloai
		{
			get { return  strMaloai; }
			set { strMaloai = value; }
		}

		private string strTenloai = string.Empty;

		/// <summary>
		/// Tenloai
		/// 
		/// </summary>
		public string Tenloai
		{
			get { return  strTenloai; }
			set { strTenloai = value; }
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
