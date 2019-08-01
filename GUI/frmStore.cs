using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            tblLogTrail log = new tblLogTrail();
            LogTrailBLL bll = new LogTrailBLL();
            log.Dater = DateTime.Now.ToString();
            log.Descrip = "User: " + btnBack.Text + " has successfully logged Out!";
            log.Authority = "Cashier";
            bll.Insert(log);
            this.Close();
            frmStart frmStart = new frmStart();
            frmStart.Show();
        }
        private void FrmStore_Load(object sender, EventArgs e)
        {
            ProductBLL bll = new ProductBLL();
            grdProduct.DataSource =  bll.GetProducts();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ProductBLL bll = new ProductBLL();
            grdProduct.DataSource = bll.SearchProductBLL(txtSearch.Text);
        }
    }
}
