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
	/// Quan Ly KH_Dat Hang
	/// </summary>	
	[Serializable]
	public class KHDATHANGBO
	{
		public KHDATHANGBO()
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

		/// <summary>
		/// Ngaydat
		/// 
		/// </summary>
		public DateTime? Ngaydat { get; set; }

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

		/// <summary>
		/// Tongtien
		/// 
		/// </summary>
		public decimal Tongtien { get; set; }

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

		/// <summary>
		/// Trangthai
		/// 
		/// </summary>
		public int Trangthai { get; set; }

		/// <summary>
		/// Ngaycapnhat
		/// 
		/// </summary>
		public DateTime? Ngaycapnhat { get; set; }

		private string strLoaidonhang = string.Empty;

		/// <summary>
		/// Loaidonhang
		/// 
		/// </summary>
		public string Loaidonhang
		{
			get { return  strLoaidonhang; }
			set { strLoaidonhang = value; }
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
