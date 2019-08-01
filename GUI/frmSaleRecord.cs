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
    public partial class frmSaleRecord : Form
    {
        public frmSaleRecord()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        double Total()
        {
            int sc = gvSaleRecord.Rows.Count;
            double Total = 0;
            for (int i = 0; i < sc ; i++)
            {
                Total += double.Parse(gvSaleRecord.Rows[i].Cells["TotalSum"].Value.ToString());
            }
            return Total;
        }

        private void FrmSaleRecord_Load(object sender, EventArgs e)
        {                                                                
            SaleRecordBLL bll = new SaleRecordBLL();
            gvSaleRecord.DataSource = bll.GetAllCash();
            lblTotal.Text = Total().ToString("#,###,##0");
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            if (gvSaleRecord.RowCount == 0)
            {
                MessageBox.Show("Nothing to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("You want to delete all record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    SaleRecordBLL bll = new SaleRecordBLL();
                    bll.DeleteAllCash();
                    lblTotal.Text = Total().ToString("#,###,##0");
                    MessageBox.Show("All record have delete");
                }
            }  
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SaleRecordBLL bll = new SaleRecordBLL();
            gvSaleRecord.DataSource = bll.Search(txtSearch.Text);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCashierRecord frm = new frmCashierRecord();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRefesh_Click(object sender, EventArgs e)
        {
            SaleRecordBLL bll = new SaleRecordBLL();
            gvSaleRecord.DataSource = bll.GetAllCash();
            lblTotal.Text = Total().ToString("#,###,##0");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }
    }
}
