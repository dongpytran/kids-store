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
	/// Quan Ly Chi Tiet San Pham Kho
	/// </summary>	
	[Serializable]
	public class CHITIETSANPHAMKHOBO
	{
		public CHITIETSANPHAMKHOBO()
		{
		}

		private string strMachitietkho = string.Empty;

		/// <summary>
		/// Machitietkho
		/// 
		/// </summary>
		public string Machitietkho
		{
			get { return  strMachitietkho; }
			set { strMachitietkho = value; }
		}

		private string strMakho = string.Empty;

		/// <summary>
		/// Makho
		/// 
		/// </summary>
		public string Makho
		{
			get { return  strMakho; }
			set { strMakho = value; }
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
