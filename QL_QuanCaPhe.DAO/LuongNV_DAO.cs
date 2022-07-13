using QL_QuanCaPhe.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.DAO
{
    public class LuongNV_DAO
    {
        //SqlConnection con = ConnectDB.cnn;

        //public DataTable loadCTLUONGNV()
        //{
        //    DataSet ds = new DataSet();
        //    string loadCTLUONG = "select * from CTBANGLUONG ";
        //    SqlDataAdapter da = new SqlDataAdapter(loadCTLUONG,ConnectDB.cnn);
        //    da.Fill(ds, "LUONGNV");
        //    return ds.Tables["LUONGNV"];
        //}

        //public DataTable loadBANGLUONG()
        //{
        //    DataSet ds = new DataSet();
        //    string loadCTLUONG = "select * from BANGLUONG ";
        //    SqlDataAdapter da = new SqlDataAdapter(loadCTLUONG, ConnectDB.cnn);
        //    da.Fill(ds, "LUONGNV");
        //    return ds.Tables["LUONGNV"];
        //}

        //public DataTable loadNHANVIEN()
        //{
        //    DataSet ds = new DataSet();
        //    string loadCTLUONG = "select MANHANVIEN,HOTEN FROM NHANVIEN";
        //    SqlDataAdapter da = new SqlDataAdapter(loadCTLUONG, ConnectDB.cnn);
        //    da.Fill(ds, "NHANVIEN");
        //    return ds.Tables["NHANVIEN"];
        //}

        //public bool LuuBangLuonng(LuongNhanVienBO objLuongBO) //QL_BanBO vừa nãy thiếu BO . m lên đặt sau là QL_BanBO, QL_BanDAO, QL_BanBLL để dẽ biết
        //{
        //    try // Oke rồi đó. Ok haha 
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("CF_CTLUONGNHANVIEN_ADD", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter paMaBangLuong = new SqlParameter("@V_MABANGLUONG", SqlDbType.VarChar);
        //        paMaBangLuong.Value = objLuongBO.maBangLuong;
        //        SqlParameter paMaNhanVien = new SqlParameter("@V_MANHANVIEN", SqlDbType.VarChar);
        //        paMaNhanVien.Value = objLuongBO.maNhanVien;
        //        SqlParameter paNgayLam = new SqlParameter("@V_NGAYLAM", SqlDbType.DateTime);
        //        paNgayLam.Value = objLuongBO.NgayLam;
        //        SqlParameter paSoTien = new SqlParameter("@V_SOTIEN", SqlDbType.Float);
        //        paSoTien.Value = objLuongBO.SoTien;
        //        SqlParameter paSoTieng = new SqlParameter("@V_SOTIENG", SqlDbType.Float);
        //        paSoTieng.Value = objLuongBO.SoTieng;
        //        SqlParameter paThanhTien = new SqlParameter("@V_THANHTIEN", SqlDbType.Float);
        //        paThanhTien.Value = objLuongBO.ThanhTien;
        //        SqlParameter paGhiChu = new SqlParameter("@V_GHICHU", SqlDbType.NVarChar);
        //        paGhiChu.Value = objLuongBO.ghiChu;



        //        cmd.Parameters.Add(paMaBangLuong);
        //        cmd.Parameters.Add(paMaNhanVien);
        //        cmd.Parameters.Add(paNgayLam);
        //        cmd.Parameters.Add(paSoTien);
        //        cmd.Parameters.Add(paSoTieng);
        //        cmd.Parameters.Add(paThanhTien);
        //        cmd.Parameters.Add(paGhiChu);

        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch(Exception EX)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
    }
}
