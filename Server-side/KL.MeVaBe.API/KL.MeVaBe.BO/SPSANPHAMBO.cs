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
	/// Quan Ly San Pham Dai Dien
	/// </summary>	
	[Serializable]
	public class SPSANPHAMBO
	{
		public SPSANPHAMBO()
		{
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

		private string strTensp = string.Empty;

		/// <summary>
		/// Tensp
		/// 
		/// </summary>
		public string Tensp
		{
			get { return  strTensp; }
			set { strTensp = value; }
		}

		private string strMaloai = string.Empty;

		/// <summary>
		/// Maloai
		/// 
		/// </summary>
		public string Maloai
		{
			get { return  strMaloai; }
			set { strMaloai = value; }
		}

		private string strMathuonghieu = string.Empty;

		/// <summary>
		/// Mathuonghieu
		/// 
		/// </summary>
		public string Mathuonghieu
		{
			get { return  strMathuonghieu; }
			set { strMathuonghieu = value; }
		}

		private string strMaxuatxu = string.Empty;

		/// <summary>
		/// Maxuatxu
		/// 
		/// </summary>
		public string Maxuatxu
		{
			get { return  strMaxuatxu; }
			set { strMaxuatxu = value; }
		}

		private string strMadotuoi = string.Empty;

		/// <summary>
		/// Madotuoi
		/// 
		/// </summary>
		public string Madotuoi
		{
			get { return  strMadotuoi; }
			set { strMadotuoi = value; }
		}

		private string strHinhanh = string.Empty;

		/// <summary>
		/// Hinhanh
		/// 
		/// </summary>
		public string Hinhanh
		{
			get { return  strHinhanh; }
			set { strHinhanh = value; }
		}

		/// <summary>
		/// Diemtichluy
		/// 
		/// </summary>
		public int Diemtichluy { get; set; }

		/// <summary>
		/// IsActive
		/// 
		/// </summary>
		public bool IsActive { get; set; }

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
