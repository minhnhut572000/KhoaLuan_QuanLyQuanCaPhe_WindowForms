using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.BO
{
    /// <summary>
	/// Created by 		: Ngô Văn Mười
	/// Created date 	: 14/10/2021 
	/// Class           : Khu Vực
	/// </summary>
    public class KhuVucBO
    {
        public KhuVucBO()
        { }

        /// <summary>
		/// MaKhuVuc
		/// Mã Khu Vực
		/// </summary>
        private string strMaKH = string.Empty;

        public string MaKhuVuc
        {
            get { return strMaKH; }
            set { strMaKH = value; }
        }

        /// <summary>
		/// HoTen
		/// Họ Tên Nhân Viên
		/// </summary>
        private string strTenKV = string.Empty;

        public string TenKhuVuc
        {
            get { return strTenKV; }
            set { strTenKV = value; }
        }
    }
}
