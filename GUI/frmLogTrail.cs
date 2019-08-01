using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmLogTrail : Form
    {
        
        public frmLogTrail()
        {
           
            //frmLogin login = new frmLogin();
            InitializeComponent();
        
         
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmAdminMenu Am = new frmAdminMenu();
            Am.Show();
        }
        
        private void  CboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cboSort.Text == "Default")
             {
                 LogTrailBLL bll = new LogTrailBLL();
                 gvLogTrail.DataSource = bll.GetTblLogTrails();
             }
        }

        private void FrmLogTrail_Load(object sender, EventArgs e)
        {
            LogTrailBLL bll = new LogTrailBLL();
            gvLogTrail.DataSource = bll.GetTblLogTrails();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0) return;
            DataGridViewRow row = gvLogTrail.Rows[e.RowIndex];
            gvLogTrail.Text = row.Cells[0].Value + "";
            gvLogTrail.Text = row.Cells[1].Value + "";
            gvLogTrail.Text = row.Cells[2].Value + "";

        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to delete all record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                LogTrailBLL bll = new LogTrailBLL();
                gvLogTrail.DataSource = bll.RemoveLogTrailsBLL();
                //lblTotal.Text = Total().ToString("#,###,##0");
                MessageBox.Show("All record have delete");
            }
        }

        private void LblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
