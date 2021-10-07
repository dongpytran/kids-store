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
	/// Quan Ly Kho
	/// </summary>	
	[Serializable]
	public class KHOBO
	{
		public KHOBO()
		{
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

		private string strTenkho = string.Empty;

		/// <summary>
		/// Tenkho
		/// 
		/// </summary>
		public string Tenkho
		{
			get { return  strTenkho; }
			set { strTenkho = value; }
		}

		/// <summary>
		/// Diachi
		/// 
		/// </summary>
		public int Diachi { get; set; }

		private string strNvkho = string.Empty;

		/// <summary>
		/// Nvkho
		/// 
		/// </summary>
		public string Nvkho
		{
			get { return  strNvkho; }
			set { strNvkho = value; }
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
