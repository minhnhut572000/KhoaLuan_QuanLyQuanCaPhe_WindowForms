using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.BO.PhanQuyen
{
    /// <summary>
	/// Created by 		: Ngô Văn Mười
	/// Created date 	: 10/15/2021 
	/// Class           : NHOMNGUOIDUNG
	/// </summary>
    public class NhomNguoiDungBO
    {
        public NhomNguoiDungBO()
        { }

        /// <summary>
		/// MANHOM
		/// Mã Nhóm
		/// </summary>
        private string strMaNhom = string.Empty;
        public string MaNhom
        {
            get { return strMaNhom; }
            set { strMaNhom = value; }
        }

        /// <summary>
		/// TENNHOM
		/// Tên Nhóm
		/// </summary>
        private string strTenNhom = string.Empty;
        public string TenNhom
        {
            get { return strTenNhom; }
            set { strTenNhom = value; }
        }

        /// <summary>
		/// GHICHU
		/// Ghi Chú
		/// </summary>
        private string strGhiChu = string.Empty;
        public string GhiChu
        {
            get { return strGhiChu; }
            set { strGhiChu = value; }
        }
    }
}
