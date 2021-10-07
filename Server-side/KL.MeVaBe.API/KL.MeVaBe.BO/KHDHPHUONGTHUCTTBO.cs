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
	/// Quan Ly Phuong Thuc Thanh Toan
	/// </summary>	
	[Serializable]
	public class KHDHPHUONGTHUCTTBO
	{
		public KHDHPHUONGTHUCTTBO()
		{
		}

		private string strMaphuongthuctt = string.Empty;

		/// <summary>
		/// Maphuongthuctt
		/// 
		/// </summary>
		public string Maphuongthuctt
		{
			get { return  strMaphuongthuctt; }
			set { strMaphuongthuctt = value; }
		}

		private string strTenphuongthuctt = string.Empty;

		/// <summary>
		/// Tenphuongthuctt
		/// 
		/// </summary>
		public string Tenphuongthuctt
		{
			get { return  strTenphuongthuctt; }
			set { strTenphuongthuctt = value; }
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
