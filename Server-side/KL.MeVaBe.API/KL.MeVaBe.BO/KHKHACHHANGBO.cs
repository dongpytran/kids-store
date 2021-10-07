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
	/// Quan Ly Khach Hang
	/// </summary>	
	[Serializable]
	public class KHKHACHHANGBO
	{
		public KHKHACHHANGBO()
		{
		}

		private string strMakh = string.Empty;

		/// <summary>
		/// Makh
		/// 
		/// </summary>
		public string Makh
		{
			get { return  strMakh; }
			set { strMakh = value; }
		}

		private string strTenkh = string.Empty;

		/// <summary>
		/// Tenkh
		/// 
		/// </summary>
		public string Tenkh
		{
			get { return  strTenkh; }
			set { strTenkh = value; }
		}

		private string strSdt = string.Empty;

		/// <summary>
		/// Sdt
		/// 
		/// </summary>
		public string Sdt
		{
			get { return  strSdt; }
			set { strSdt = value; }
		}

		private string strEmail = string.Empty;

		/// <summary>
		/// Email
		/// 
		/// </summary>
		public string Email
		{
			get { return  strEmail; }
			set { strEmail = value; }
		}

		private string strPassword = string.Empty;

		/// <summary>
		/// Password
		/// 
		/// </summary>
		public string Password
		{
			get { return  strPassword; }
			set { strPassword = value; }
		}

		/// <summary>
		/// Diemtichluy
		/// 
		/// </summary>
		public int Diemtichluy { get; set; }

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
