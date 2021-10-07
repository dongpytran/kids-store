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
	/// Quan Ly NCC_Chi Tiet Dat Hang
	/// </summary>	
	[Serializable]
	public class NCCCHITIETDATHANGBO
	{
		public NCCCHITIETDATHANGBO()
		{
		}

		private string strMaphieudat = string.Empty;

		/// <summary>
		/// Maphieudat
		/// 
		/// </summary>
		public string Maphieudat
		{
			get { return  strMaphieudat; }
			set { strMaphieudat = value; }
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
		/// Soluongdat
		/// 
		/// </summary>
		public int Soluongdat { get; set; }

		/// <summary>
		/// Soluongnhap
		/// 
		/// </summary>
		public int Soluongnhap { get; set; }

		private string strDongianhap = string.Empty;

		/// <summary>
		/// Dongianhap
		/// 
		/// </summary>
		public string Dongianhap
		{
			get { return  strDongianhap; }
			set { strDongianhap = value; }
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
