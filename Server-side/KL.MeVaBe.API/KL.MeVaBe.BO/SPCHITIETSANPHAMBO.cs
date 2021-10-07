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
	/// Quan Ly Chi Tiet San Pham
	/// </summary>	
	[Serializable]
	public class SPCHITIETSANPHAMBO
	{
		public SPCHITIETSANPHAMBO()
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

		/// <summary>
		/// Trongluong
		/// 
		/// </summary>
		public int Trongluong { get; set; }

		private string strDacdiem = string.Empty;

		/// <summary>
		/// Dacdiem
		/// 
		/// </summary>
		public string Dacdiem
		{
			get { return  strDacdiem; }
			set { strDacdiem = value; }
		}

		private string strMota = string.Empty;

		/// <summary>
		/// Mota
		/// 
		/// </summary>
		public string Mota
		{
			get { return  strMota; }
			set { strMota = value; }
		}

		private string strMausac = string.Empty;

		/// <summary>
		/// Mausac
		/// 
		/// </summary>
		public string Mausac
		{
			get { return  strMausac; }
			set { strMausac = value; }
		}

		private string strKichco = string.Empty;

		/// <summary>
		/// Kichco
		/// 
		/// </summary>
		public string Kichco
		{
			get { return  strKichco; }
			set { strKichco = value; }
		}

		/// <summary>
		/// Tongsl
		/// 
		/// </summary>
		public int Tongsl { get; set; }

		/// <summary>
		/// Dongia
		/// 
		/// </summary>
		public long Dongia { get; set; }

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
