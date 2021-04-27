using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ontap3
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.MoMotKetNoi();
            string sql = "SELECT * FROM DanhMuc";
            DataTable dataTable = dataAccess.LayBangDuLieu(sql);

            this.rptMenu.DataSource = dataTable;
            this.rptMenu.DataBind();

            dataAccess.DongKetNoiCSDL();
            //xong
        }
    }
}