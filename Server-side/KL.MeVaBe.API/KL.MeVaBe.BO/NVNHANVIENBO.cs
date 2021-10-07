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
	/// Quan Ly Nhan Vien
	/// </summary>	
	[Serializable]
	public class NVNHANVIENBO
	{
		public NVNHANVIENBO()
		{
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

		private string strTennv = string.Empty;

		/// <summary>
		/// Tennv
		/// 
		/// </summary>
		public string Tennv
		{
			get { return  strTennv; }
			set { strTennv = value; }
		}

		/// <summary>
		/// Ngaysinh
		/// 
		/// </summary>
		public DateTime? Ngaysinh { get; set; }

		/// <summary>
		/// Ngayvaolam
		/// 
		/// </summary>
		public DateTime? Ngayvaolam { get; set; }

		/// <summary>
		/// Gioitinh
		/// 
		/// </summary>
		public bool Gioitinh { get; set; }

		private string strDiachi = string.Empty;

		/// <summary>
		/// Diachi
		/// 
		/// </summary>
		public string Diachi
		{
			get { return  strDiachi; }
			set { strDiachi = value; }
		}

		private string strSdt = string.Empty;

		/// <summary>
		/// Sdt
		/// 
		/// </summary>
		public string Sdt
		{
			get { return  strSdt; }
			set { strSdt = value; }
		}

		private string strEmail = string.Empty;

		/// <summary>
		/// Email
		/// 
		/// </summary>
		public string Email
		{
			get { return  strEmail; }
			set { strEmail = value; }
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
