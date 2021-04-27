using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ontap3
{
    public partial class TrangSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoMotKetNoi();
            string idSanPham = Request.QueryString.Get("idSanPham");
            string sql;
            
            if (idSanPham != null)
            {
                sql = $"SELECT * FROM SanPham where Id={idSanPham}";
                DataTable datatable = dataAccess.LayBangDuLieu(sql);
                ltTen.Text = datatable.Rows[0]["Ten"].ToString();
                img.ImageUrl = "hinhanh/" + datatable.Rows[0]["Hinh"].ToString();
                ltGia.Text = datatable.Rows[0]["Gia"].ToString();
                ltMota.Text = datatable.Rows[0]["MoTa"].ToString();
            }
            dataAccess.DongKetNoiCSDL();
        }
    }
}