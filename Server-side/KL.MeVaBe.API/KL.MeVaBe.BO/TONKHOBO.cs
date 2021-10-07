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
	/// Quan Ly Ton Kho
	/// </summary>	
	[Serializable]
	public class TONKHOBO
	{
		public TONKHOBO()
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

		/// <summary>
		/// Soluongnhap
		/// 
		/// </summary>
		public int Soluongnhap { get; set; }

		/// <summary>
		/// Soluongxuat
		/// 
		/// </summary>
		public int Soluongxuat { get; set; }

		/// <summary>
		/// Soluongton
		/// 
		/// </summary>
		public int Soluongton { get; set; }

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
