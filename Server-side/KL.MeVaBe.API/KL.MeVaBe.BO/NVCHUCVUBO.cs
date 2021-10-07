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
	/// Quan Ly Chuc Vu Nhan Vien
	/// </summary>	
	[Serializable]
	public class NVCHUCVUBO
	{
		public NVCHUCVUBO()
		{
		}

		private string strMachucvu = string.Empty;

		/// <summary>
		/// Machucvu
		/// 
		/// </summary>
		public string Machucvu
		{
			get { return  strMachucvu; }
			set { strMachucvu = value; }
		}

		private string strTenchucvu = string.Empty;

		/// <summary>
		/// Tenchucvu
		/// 
		/// </summary>
		public string Tenchucvu
		{
			get { return  strTenchucvu; }
			set { strTenchucvu = value; }
		}

		/// <summary>
		/// Mucluong
		/// 
		/// </summary>
		public int Mucluong { get; set; }

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
