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
	/// Quan Ly NCC_Dat Hang
	/// </summary>	
	[Serializable]
	public class NCCDATHANGBO
	{
		public NCCDATHANGBO()
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

		/// <summary>
		/// Ngaylap
		/// 
		/// </summary>
		public DateTime? Ngaylap { get; set; }

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

		private string strMancc = string.Empty;

		/// <summary>
		/// Mancc
		/// 
		/// </summary>
		public string Mancc
		{
			get { return  strMancc; }
			set { strMancc = value; }
		}

		/// <summary>
		/// Ngaygiaodukien
		/// 
		/// </summary>
		public DateTime? Ngaygiaodukien { get; set; }

		/// <summary>
		/// Ngaygiaothucte
		/// 
		/// </summary>
		public DateTime? Ngaygiaothucte { get; set; }

		/// <summary>
		/// Tongtien
		/// 
		/// </summary>
		public int Tongtien { get; set; }

		/// <summary>
		/// Trangthai
		/// 
		/// </summary>
		public int Trangthai { get; set; }

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
