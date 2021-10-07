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
	/// Quan Ly SP_Do Tuoi
	/// </summary>	
	[Serializable]
	public class SPDOTUOIBO
	{
		public SPDOTUOIBO()
		{
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

		private string strDotuoi = string.Empty;

		/// <summary>
		/// Dotuoi
		/// 
		/// </summary>
		public string Dotuoi
		{
			get { return  strDotuoi; }
			set { strDotuoi = value; }
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
