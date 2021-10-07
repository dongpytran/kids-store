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
	/// Quan Ly SP_Xuat Xu
	/// </summary>	
	[Serializable]
	public class SPXUATXUBO
	{
		public SPXUATXUBO()
		{
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

		private string strNoixuatxu = string.Empty;

		/// <summary>
		/// Noixuatxu
		/// 
		/// </summary>
		public string Noixuatxu
		{
			get { return  strNoixuatxu; }
			set { strNoixuatxu = value; }
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
