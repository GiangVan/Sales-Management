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
    public partial class frmCashierRecord : Form
    {
        public frmCashierRecord()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double Total()
        {
            int sc = gvCashierList.Rows.Count;
            double Total = 0;
            for (int i = 0; i < sc; i++)
            {
                Total += double.Parse(gvCashierList.Rows[i].Cells["TotalSum"].Value.ToString());
            }
            return Total;
        }
        private void FrmCashierRecord_Load(object sender, EventArgs e)
        {
            CashierRecordBLL bll = new CashierRecordBLL();
            gvCashierList.DataSource = bll.GetAllCash();
            lblTotal.Text = Total().ToString("#,###,##0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CashierRecordBLL bll = new CashierRecordBLL();
            gvCashierList.DataSource = bll.GetAllCash();
            lblTotal.Text = Total().ToString("#,###,##0");
        }

        private void RemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to delete all cashier record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                CashierRecordBLL bll = new CashierRecordBLL();
                bll.DeleteAllCashier();
                lblTotal.Text = Total().ToString("#,###,##0");
                MessageBox.Show("All cashier record have delete");
            } 
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SaleRecordBLL bll = new SaleRecordBLL();
            gvCashierList.DataSource = bll.Search(txtSearch.Text);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }
    }
}
