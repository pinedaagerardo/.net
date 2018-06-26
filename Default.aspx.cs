using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webtestPGN
{
    public partial class Default : System.Web.UI.Page
    {
        private MyEntities en;
        Conn c;
        protected void Page_Load(object sender, EventArgs e)
        {
            en = new MyEntities();
            c = new Conn();
            refresh_grid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            c.insertNew();
            refresh_grid();
        }

        private void refresh_grid()
        {
            GridView1.DataSource = en.ENTITYTABLEs.ToList();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtidb.Text, out id);
            c.delete(id);
            refresh_grid();
        }
    }
}