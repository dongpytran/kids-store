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
	/// Quan Ly SP_Vi Tri Trung Bay
	/// </summary>	
	[Serializable]
	public class SPVITRITRUNGBAYBO
	{
		public SPVITRITRUNGBAYBO()
		{
		}

		private string strMavitri = string.Empty;

		/// <summary>
		/// Mavitri
		/// 
		/// </summary>
		public string Mavitri
		{
			get { return  strMavitri; }
			set { strMavitri = value; }
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
