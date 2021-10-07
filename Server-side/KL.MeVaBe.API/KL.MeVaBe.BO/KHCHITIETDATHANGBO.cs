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
	/// Quan Ly KH_Chi Tiet Dat Hang
	/// </summary>	
	[Serializable]
	public class KHCHITIETDATHANGBO
	{
		public KHCHITIETDATHANGBO()
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
		/// Soluong
		/// 
		/// </summary>
		public int Soluong { get; set; }

		/// <summary>
		/// Thanhtien
		/// 
		/// </summary>
		public decimal Thanhtien { get; set; }

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
