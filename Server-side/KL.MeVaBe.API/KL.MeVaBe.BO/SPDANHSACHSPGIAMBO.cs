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
	/// Quan Ly Danh Sach San Pham Giam Gia Theo Dot
	/// </summary>	
	[Serializable]
	public class SPDANHSACHSPGIAMBO
	{
		public SPDANHSACHSPGIAMBO()
		{
		}

		private string strMasukien = string.Empty;

		/// <summary>
		/// Masukien
		/// 
		/// </summary>
		public string Masukien
		{
			get { return  strMasukien; }
			set { strMasukien = value; }
		}

		private string strMasp = string.Empty;

		/// <summary>
		/// Masp
		/// 
		/// </summary>
		public string Masp
		{
			get { return  strMasp; }
			set { strMasp = value; }
		}

		/// <summary>
		/// Giatrigiam
		/// 
		/// </summary>
		public int Giatrigiam { get; set; }

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
