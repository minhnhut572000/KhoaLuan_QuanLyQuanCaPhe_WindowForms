using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.DAO
{
    /// <summary>
	/// Created by 		: Ngô Văn Mười
	/// Created date 	: 10/14/2021 
	/// Class           : MANHINH
	/// </summary>	
    public class ManHinhBO
    {
        public ManHinhBO()
        { }

        /// <summary>
		/// MaManHinh
		/// Mã Màn Hình
		/// </summary>
        private string strMaH = string.Empty;
        public string MaManHinh
        {
            get { return strMaH; }
            set { strMaH = value; }
        }

        /// <summary>
		/// TenManHinh
		/// Tên Màn Hình
		/// </summary>
        private string strTenMH = string.Empty;
        public string TenManHinh
        {
            get { return strTenMH; }
            set { strTenMH = value; }
        }
    }
}
