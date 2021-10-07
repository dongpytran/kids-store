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
	/// Quan Ly Nhom San Pham
	/// </summary>	
	[Serializable]
	public class NHOMSANPHAMBO
	{
		public NHOMSANPHAMBO()
		{
		}

		private string strManhomsp = string.Empty;

		/// <summary>
		/// Manhomsp
		/// 
		/// </summary>
		public string Manhomsp
		{
			get { return  strManhomsp; }
			set { strManhomsp = value; }
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
