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
	/// Quan Ly Giao Hang
	/// </summary>	
	[Serializable]
	public class GIAOHANGBO
	{
		public GIAOHANGBO()
		{
		}

		private string strMadondat = string.Empty;

		/// <summary>
		/// Madondat
		/// 
		/// </summary>
		public string Madondat
		{
			get { return  strMadondat; }
			set { strMadondat = value; }
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

		/// <summary>
		/// Ngaygiao
		/// 
		/// </summary>
		public DateTime? Ngaygiao { get; set; }

		/// <summary>
		/// IsDelivery
		/// 
		/// </summary>
		public bool IsDelivery { get; set; }

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
