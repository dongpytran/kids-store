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
	/// Quan Ly Tai Khoan
	/// </summary>	
	[Serializable]
	public class NVTAIKHOANBO
	{
		public NVTAIKHOANBO()
		{
		}

		private string strManv = string.Empty;

		/// <summary>
		/// Manv
		/// 
		/// </summary>
		public string Manv
		{
			get { return  strManv; }
			set { strManv = value; }
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
		/// Roleid
		/// 
		/// </summary>
		public int Roleid { get; set; }

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
