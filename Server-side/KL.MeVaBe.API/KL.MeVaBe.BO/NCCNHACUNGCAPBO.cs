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
	/// Quan Ly Nha Cung Cap
	/// </summary>	
	[Serializable]
	public class NCCNHACUNGCAPBO
	{
		public NCCNHACUNGCAPBO()
		{
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

		private string strTenncc = string.Empty;

		/// <summary>
		/// Tenncc
		/// 
		/// </summary>
		public string Tenncc
		{
			get { return  strTenncc; }
			set { strTenncc = value; }
		}

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
