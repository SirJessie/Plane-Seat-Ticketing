using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingApp
{
    public partial class frmSeat : Form
    {
        
        public frmSeat()
        {
            InitializeComponent();
        }

        private void formQueue_Load(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            frmBuyTicket BuyTicket = new frmBuyTicket();
            this.btnBuy.Enabled = false;
            this.btnResetSeating.Enabled = false;
            BuyTicket.Show();
            
        }

        private void btnResetSeating_Click(object sender, EventArgs e)
        {
            lblA1.Text = "*";
            lblB1.Text = "*";
            lblC1.Text = "*";
            lblD1.Text = "*";
            lblE1.Text = "*";
            lblF1.Text = "*";

            lblA2.Text = "*";
            lblB2.Text = "*";
            lblC2.Text = "*";
            lblD2.Text = "*";
            lblE2.Text = "*";
            lblF2.Text = "*";

            lblA2.Text = "*";
            lblB2.Text = "*";
            lblC2.Text = "*";
            lblD2.Text = "*";
            lblE2.Text = "*";
            lblF2.Text = "*";

            lblA3.Text = "*";
            lblB3.Text = "*";
            lblC3.Text = "*";
            lblD3.Text = "*";
            lblE3.Text = "*";
            lblF3.Text = "*";

            lblA3.Text = "*";
            lblB3.Text = "*";
            lblC3.Text = "*";
            lblD3.Text = "*";
            lblE3.Text = "*";
            lblF3.Text = "*";

            lblA4.Text = "*";
            lblB4.Text = "*";
            lblC4.Text = "*";
            lblD4.Text = "*";
            lblE4.Text = "*";
            lblF4.Text = "*";

            lblA5.Text = "*";
            lblB5.Text = "*";
            lblC5.Text = "*";
            lblD5.Text = "*";
            lblE5.Text = "*";
            lblF5.Text = "*";

            lblA6.Text = "*";
            lblB6.Text = "*";
            lblC6.Text = "*";
            lblD6.Text = "*";
            lblE6.Text = "*";
            lblF6.Text = "*";

            lblA7.Text = "*";
            lblB7.Text = "*";
            lblC7.Text = "*";
            lblD7.Text = "*";
            lblE7.Text = "*";
            lblF7.Text = "*";

            lblA8.Text = "*";
            lblB8.Text = "*";
            lblC8.Text = "*";
            lblD8.Text = "*";
            lblE8.Text = "*";
            lblF8.Text = "*";

            lblA9.Text = "*";
            lblB9.Text = "*";
            lblC9.Text = "*";
            lblD9.Text = "*";
            lblE9.Text = "*";
            lblF9.Text = "*";

            lblA10.Text = "*";
            lblB10.Text = "*";
            lblC10.Text = "*";
            lblD10.Text = "*";
            lblE10.Text = "*";
            lblF10.Text = "*";

            lblA11.Text = "*";
            lblB11.Text = "*";
            lblC11.Text = "*";
            lblD11.Text = "*";
            lblE11.Text = "*";
            lblF11.Text = "*";

            lblA12.Text = "*";
            lblB12.Text = "*";
            lblC12.Text = "*";
            lblD12.Text = "*";
            lblE12.Text = "*";
            lblF12.Text = "*";

            lblA13.Text = "*";
            lblB13.Text = "*";
            lblC13.Text = "*";
            lblD13.Text = "*";
            lblE13.Text = "*";
            lblF13.Text = "*";
        }
    }
}
