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
	/// Quan Ly Su Kien Giam Gia
	/// </summary>	
	[Serializable]
	public class SPSUKIENGIAMGIABO
	{
		public SPSUKIENGIAMGIABO()
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

		private string strTensukien = string.Empty;

		/// <summary>
		/// Tensukien
		/// 
		/// </summary>
		public string Tensukien
		{
			get { return  strTensukien; }
			set { strTensukien = value; }
		}

		/// <summary>
		/// Ngaybatdau
		/// 
		/// </summary>
		public DateTime? Ngaybatdau { get; set; }

		/// <summary>
		/// Ngayketthuc
		/// 
		/// </summary>
		public DateTime? Ngayketthuc { get; set; }

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
