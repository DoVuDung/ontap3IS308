using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ontap3
{
    public partial class TrangDanhMuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoMotKetNoi();
            string idDanhMuc = Request.QueryString.Get("idDanhMuc");
            string sql;
            if(idDanhMuc == null)
            {
                sql = "SELECT * FROM SanPham";
            }
            else
            {
                sql = $"SELECT * FROM SanPham where IdDanhMuc={idDanhMuc}";
            }
            DataTable dataTable = dataAccess.LayBangDuLieu(sql);

            this.rptSanPham.DataSource = dataTable;
            this.rptSanPham.DataBind();

            dataAccess.DongKetNoiCSDL();

        }
    }
}