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
    public partial class frmConfirm : Form
    {
        // DISABLING CLOSE BUTTON
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public frmConfirm()
        {
            InitializeComponent();
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmBuyTicket BuyTicket = new frmBuyTicket();

            BuyTicket.txtbPassportNo.Text = lblPassport.Text;
            BuyTicket.txtbFullname.Text = lblFullname.Text;
            BuyTicket.txtbContact.Text = lblContact.Text;
            BuyTicket.txbAddress.Text = lblAddress.Text;
            
            this.Close();
            BuyTicket.Show();
            

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            frmQueue Queue = (frmQueue)Application.OpenForms["frmQueue"];

            if (lblSeat.Text == "A1")
            {
                Queue.lblA1.Text = "X";
            }
            else if (lblSeat.Text == "B1")
            {
                Queue.lblB1.Text = "X";
            }
            else if (lblSeat.Text == "C1")
            {
                Queue.lblC1.Text = "X";
            }
            else if (lblSeat.Text == "D1")
            {
                Queue.lblD1.Text = "X";
            }
            else if (lblSeat.Text == "E1")
            {
                Queue.lblE1.Text = "X";
            }
            else if (lblSeat.Text == "F1")
            {
                Queue.lblF1.Text = "X";
            }
            else if (lblSeat.Text == "A2")
            {
                Queue.lblA2.Text = "X";
            }
            else if (lblSeat.Text == "B2")
            {
                Queue.lblB2.Text = "X";
            }
            else if (lblSeat.Text == "C2")
            {
                Queue.lblC2.Text = "X";
            }
            else if (lblSeat.Text == "D2")
            {
                Queue.lblD2.Text = "X";
            }
            else if (lblSeat.Text == "E2")
            {
                Queue.lblE2.Text = "X";
            }
            else if (lblSeat.Text == "F2")
            {
                Queue.lblF2.Text = "X";
            }
            else if (lblSeat.Text == "A3")
            {
                Queue.lblA3.Text = "X";
            }
            else if (lblSeat.Text == "B3")
            {
                Queue.lblB3.Text = "X";
            }
            else if (lblSeat.Text == "C3")
            {
                Queue.lblC3.Text = "X";
            }
            else if (lblSeat.Text == "D3")
            {
                Queue.lblD3.Text = "X";
            }
            else if (lblSeat.Text == "E3")
            {
                Queue.lblE3.Text = "X";
            }
            else if (lblSeat.Text == "F3")
            {
                Queue.lblF3.Text = "X";
            }
            else if (lblSeat.Text == "A4")
            {
                Queue.lblA4.Text = "X";
            }
            else if (lblSeat.Text == "B4")
            {
                Queue.lblB4.Text = "X";
            }
            else if (lblSeat.Text == "C4")
            {
                Queue.lblC4.Text = "X";
            }
            else if (lblSeat.Text == "D4")
            {
                Queue.lblD4.Text = "X";
            }
            else if (lblSeat.Text == "E4")
            {
                Queue.lblE4.Text = "X";
            }
            else if (lblSeat.Text == "F4")
            {
                Queue.lblF4.Text = "X";
            }
            else if (lblSeat.Text == "A5")
            {
                Queue.lblA5.Text = "X";
            }
            else if (lblSeat.Text == "B5")
            {
                Queue.lblB5.Text = "X";
            }
            else if (lblSeat.Text == "C5")
            {
                Queue.lblC5.Text = "X";
            }
            else if (lblSeat.Text == "D5")
            {
                Queue.lblD5.Text = "X";
            }
            else if (lblSeat.Text == "E5")
            {
                Queue.lblE5.Text = "X";
            }
            else if (lblSeat.Text == "F5")
            {
                Queue.lblF5.Text = "X";
            }
            else if (lblSeat.Text == "A6")
            {
                Queue.lblA6.Text = "X";
            }
            else if (lblSeat.Text == "B6")
            {
                Queue.lblB6.Text = "X";
            }
            else if (lblSeat.Text == "C6")
            {
                Queue.lblC6.Text = "X";
            }
            else if (lblSeat.Text == "D6")
            {
                Queue.lblD6.Text = "X";
            }
            else if (lblSeat.Text == "E6")
            {
                Queue.lblE6.Text = "X";
            }
            else if (lblSeat.Text == "F6")
            {
                Queue.lblF6.Text = "X";
            }
            else if (lblSeat.Text == "A7")
            {
                Queue.lblA7.Text = "X";
            }
            else if (lblSeat.Text == "B7")
            {
                Queue.lblB7.Text = "X";
            }
            else if (lblSeat.Text == "C7")
            {
                Queue.lblC7.Text = "X";
            }
            else if (lblSeat.Text == "D7")
            {
                Queue.lblD7.Text = "X";
            }
            else if (lblSeat.Text == "E7")
            {
                Queue.lblE7.Text = "X";
            }
            else if (lblSeat.Text == "F7")
            {
                Queue.lblF7.Text = "X";
            }
            else if (lblSeat.Text == "A8")
            {
                Queue.lblA8.Text = "X";
            }
            else if (lblSeat.Text == "B8")
            {
                Queue.lblB8.Text = "X";
            }
            else if (lblSeat.Text == "C8")
            {
                Queue.lblC8.Text = "X";
            }
            else if (lblSeat.Text == "D8")
            {
                Queue.lblD8.Text = "X";
            }
            else if (lblSeat.Text == "E8")
            {
                Queue.lblE8.Text = "X";
            }
            else if (lblSeat.Text == "F8")
            {
                Queue.lblF8.Text = "X";
            }
            else if (lblSeat.Text == "A9")
            {
                Queue.lblA9.Text = "X";
            }
            else if (lblSeat.Text == "B9")
            {
                Queue.lblB9.Text = "X";
            }
            else if (lblSeat.Text == "C9")
            {
                Queue.lblC9.Text = "X";
            }
            else if (lblSeat.Text == "D9")
            {
                Queue.lblD9.Text = "X";
            }
            else if (lblSeat.Text == "E9")
            {
                Queue.lblE9.Text = "X";
            }
            else if (lblSeat.Text == "F9")
            {
                Queue.lblF9.Text = "X";
            }
            else if (lblSeat.Text == "A10")
            {
                Queue.lblA10.Text = "X";
            }
            else if (lblSeat.Text == "B10")
            {
                Queue.lblB10.Text = "X";
            }
            else if (lblSeat.Text == "C10")
            {
                Queue.lblC10.Text = "X";
            }
            else if (lblSeat.Text == "D10")
            {
                Queue.lblD10.Text = "X";
            }
            else if (lblSeat.Text == "E10")
            {
                Queue.lblE10.Text = "X";
            }
            else if (lblSeat.Text == "F10")
            {
                Queue.lblF10.Text = "X";
            }
            else if (lblSeat.Text == "A11")
            {
                Queue.lblA11.Text = "X";
            }
            else if (lblSeat.Text == "B11")
            {
                Queue.lblB11.Text = "X";
            }
            else if (lblSeat.Text == "C11")
            {
                Queue.lblC11.Text = "X";
            }
            else if (lblSeat.Text == "D11")
            {
                Queue.lblD11.Text = "X";
            }
            else if (lblSeat.Text == "E11")
            {
                Queue.lblE11.Text = "X";
            }
            else if (lblSeat.Text == "F11")
            {
                Queue.lblF11.Text = "X";
            }
            else if (lblSeat.Text == "A12")
            {
                Queue.lblA12.Text = "X";
            }
            else if (lblSeat.Text == "B12")
            {
                Queue.lblB12.Text = "X";
            }
            else if (lblSeat.Text == "C12")
            {
                Queue.lblC12.Text = "X";
            }
            else if (lblSeat.Text == "D12")
            {
                Queue.lblD12.Text = "X";
            }
            else if (lblSeat.Text == "E12")
            {
                Queue.lblE12.Text = "X";
            }
            else if (lblSeat.Text == "F12")
            {
                Queue.lblF12.Text = "X";
            }

            else if (lblSeat.Text == "A13")
            {
                Queue.lblA13.Text = "X";
            }
            else if (lblSeat.Text == "B13")
            {
                Queue.lblB13.Text = "X";
            }
            else if (lblSeat.Text == "C13")
            {
                Queue.lblC13.Text = "X";
            }
            else if (lblSeat.Text == "D13")
            {
                Queue.lblD13.Text = "X";
            }
            else if (lblSeat.Text == "E13")
            {
                Queue.lblE13.Text = "X";
            }
            else if (lblSeat.Text == "F13")
            {
                Queue.lblF13.Text = "X";
            }

            Queue.btnBuy.Enabled = true;
            Queue.btnResetSeating.Enabled = true;

            this.Close();

        }
    }
}
