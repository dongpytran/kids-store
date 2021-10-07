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
	/// Quan Ly Quyen Tai Khoan
	/// </summary>	
	[Serializable]
	public class NVQUYENTAIKHOANBO
	{
		public NVQUYENTAIKHOANBO()
		{
		}

		/// <summary>
		/// Roleid
		/// 
		/// </summary>
		public int Roleid { get; set; }

		private string strRolename = string.Empty;

		/// <summary>
		/// Rolename
		/// 
		/// </summary>
		public string Rolename
		{
			get { return  strRolename; }
			set { strRolename = value; }
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
