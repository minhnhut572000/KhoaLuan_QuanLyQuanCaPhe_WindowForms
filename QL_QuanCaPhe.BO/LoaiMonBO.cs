﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.BO
{
    /// <summary>
	/// Created by 		: Ngô Văn Mười
	/// Created date 	: 10/14/2021 
	/// Class           : LOAIMON
	/// </summary>	
    public class LoaiMonBO
    {
        public LoaiMonBO()
        { }

        /// <summary>
		/// MaLoai
		/// Mã Loại
		/// </summary>
        private string strMaLoai = string.Empty;
        public string MaLoai
        {
            get { return strMaLoai; }
            set { strMaLoai = value; }
        }

        /// <summary>
		/// TenLoai
		/// Tên Loại
		/// </summary>
        private string strTenLoai = string.Empty;
        public string TenLoai
        {
            get { return strTenLoai; }
            set { strTenLoai = value; }
        }
    }
}
