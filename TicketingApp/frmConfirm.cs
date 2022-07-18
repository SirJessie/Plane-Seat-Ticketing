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
            frmSeat Seat = (frmSeat)Application.OpenForms["frmSeat"];

            if (lblSeat.Text == "A1")
            {
                Seat.lblA1.Text = "X";
            }
            else if (lblSeat.Text == "B1")
            {
                Seat.lblB1.Text = "X";
            }
            else if (lblSeat.Text == "C1")
            {
                Seat.lblC1.Text = "X";
            }
            else if (lblSeat.Text == "D1")
            {
                Seat.lblD1.Text = "X";
            }
            else if (lblSeat.Text == "E1")
            {
                Seat.lblE1.Text = "X";
            }
            else if (lblSeat.Text == "F1")
            {
                Seat.lblF1.Text = "X";
            }
            else if (lblSeat.Text == "A2")
            {
                Seat.lblA2.Text = "X";
            }
            else if (lblSeat.Text == "B2")
            {
                Seat.lblB2.Text = "X";
            }
            else if (lblSeat.Text == "C2")
            {
                Seat.lblC2.Text = "X";
            }
            else if (lblSeat.Text == "D2")
            {
                Seat.lblD2.Text = "X";
            }
            else if (lblSeat.Text == "E2")
            {
                Seat.lblE2.Text = "X";
            }
            else if (lblSeat.Text == "F2")
            {
                Seat.lblF2.Text = "X";
            }
            else if (lblSeat.Text == "A3")
            {
                Seat.lblA3.Text = "X";
            }
            else if (lblSeat.Text == "B3")
            {
                Seat.lblB3.Text = "X";
            }
            else if (lblSeat.Text == "C3")
            {
                Seat.lblC3.Text = "X";
            }
            else if (lblSeat.Text == "D3")
            {
                Seat.lblD3.Text = "X";
            }
            else if (lblSeat.Text == "E3")
            {
                Seat.lblE3.Text = "X";
            }
            else if (lblSeat.Text == "F3")
            {
                Seat.lblF3.Text = "X";
            }
            else if (lblSeat.Text == "A4")
            {
                Seat.lblA4.Text = "X";
            }
            else if (lblSeat.Text == "B4")
            {
                Seat.lblB4.Text = "X";
            }
            else if (lblSeat.Text == "C4")
            {
                Seat.lblC4.Text = "X";
            }
            else if (lblSeat.Text == "D4")
            {
                Seat.lblD4.Text = "X";
            }
            else if (lblSeat.Text == "E4")
            {
                Seat.lblE4.Text = "X";
            }
            else if (lblSeat.Text == "F4")
            {
                Seat.lblF4.Text = "X";
            }
            else if (lblSeat.Text == "A5")
            {
                Seat.lblA5.Text = "X";
            }
            else if (lblSeat.Text == "B5")
            {
                Seat.lblB5.Text = "X";
            }
            else if (lblSeat.Text == "C5")
            {
                Seat.lblC5.Text = "X";
            }
            else if (lblSeat.Text == "D5")
            {
                Seat.lblD5.Text = "X";
            }
            else if (lblSeat.Text == "E5")
            {
                Seat.lblE5.Text = "X";
            }
            else if (lblSeat.Text == "F5")
            {
                Seat.lblF5.Text = "X";
            }
            else if (lblSeat.Text == "A6")
            {
                Seat.lblA6.Text = "X";
            }
            else if (lblSeat.Text == "B6")
            {
                Seat.lblB6.Text = "X";
            }
            else if (lblSeat.Text == "C6")
            {
                Seat.lblC6.Text = "X";
            }
            else if (lblSeat.Text == "D6")
            {
                Seat.lblD6.Text = "X";
            }
            else if (lblSeat.Text == "E6")
            {
                Seat.lblE6.Text = "X";
            }
            else if (lblSeat.Text == "F6")
            {
                Seat.lblF6.Text = "X";
            }
            else if (lblSeat.Text == "A7")
            {
                Seat.lblA7.Text = "X";
            }
            else if (lblSeat.Text == "B7")
            {
                Seat.lblB7.Text = "X";
            }
            else if (lblSeat.Text == "C7")
            {
                Seat.lblC7.Text = "X";
            }
            else if (lblSeat.Text == "D7")
            {
                Seat.lblD7.Text = "X";
            }
            else if (lblSeat.Text == "E7")
            {
                Seat.lblE7.Text = "X";
            }
            else if (lblSeat.Text == "F7")
            {
                Seat.lblF7.Text = "X";
            }
            else if (lblSeat.Text == "A8")
            {
                Seat.lblA8.Text = "X";
            }
            else if (lblSeat.Text == "B8")
            {
                Seat.lblB8.Text = "X";
            }
            else if (lblSeat.Text == "C8")
            {
                Seat.lblC8.Text = "X";
            }
            else if (lblSeat.Text == "D8")
            {
                Seat.lblD8.Text = "X";
            }
            else if (lblSeat.Text == "E8")
            {
                Seat.lblE8.Text = "X";
            }
            else if (lblSeat.Text == "F8")
            {
                Seat.lblF8.Text = "X";
            }
            else if (lblSeat.Text == "A9")
            {
                Seat.lblA9.Text = "X";
            }
            else if (lblSeat.Text == "B9")
            {
                Seat.lblB9.Text = "X";
            }
            else if (lblSeat.Text == "C9")
            {
                Seat.lblC9.Text = "X";
            }
            else if (lblSeat.Text == "D9")
            {
                Seat.lblD9.Text = "X";
            }
            else if (lblSeat.Text == "E9")
            {
                Seat.lblE9.Text = "X";
            }
            else if (lblSeat.Text == "F9")
            {
                Seat.lblF9.Text = "X";
            }
            else if (lblSeat.Text == "A10")
            {
                Seat.lblA10.Text = "X";
            }
            else if (lblSeat.Text == "B10")
            {
                Seat.lblB10.Text = "X";
            }
            else if (lblSeat.Text == "C10")
            {
                Seat.lblC10.Text = "X";
            }
            else if (lblSeat.Text == "D10")
            {
                Seat.lblD10.Text = "X";
            }
            else if (lblSeat.Text == "E10")
            {
                Seat.lblE10.Text = "X";
            }
            else if (lblSeat.Text == "F10")
            {
                Seat.lblF10.Text = "X";
            }
            else if (lblSeat.Text == "A11")
            {
                Seat.lblA11.Text = "X";
            }
            else if (lblSeat.Text == "B11")
            {
                Seat.lblB11.Text = "X";
            }
            else if (lblSeat.Text == "C11")
            {
                Seat.lblC11.Text = "X";
            }
            else if (lblSeat.Text == "D11")
            {
                Seat.lblD11.Text = "X";
            }
            else if (lblSeat.Text == "E11")
            {
                Seat.lblE11.Text = "X";
            }
            else if (lblSeat.Text == "F11")
            {
                Seat.lblF11.Text = "X";
            }
            else if (lblSeat.Text == "A12")
            {
                Seat.lblA12.Text = "X";
            }
            else if (lblSeat.Text == "B12")
            {
                Seat.lblB12.Text = "X";
            }
            else if (lblSeat.Text == "C12")
            {
                Seat.lblC12.Text = "X";
            }
            else if (lblSeat.Text == "D12")
            {
                Seat.lblD12.Text = "X";
            }
            else if (lblSeat.Text == "E12")
            {
                Seat.lblE12.Text = "X";
            }
            else if (lblSeat.Text == "F12")
            {
                Seat.lblF12.Text = "X";
            }

            else if (lblSeat.Text == "A13")
            {
                Seat.lblA13.Text = "X";
            }
            else if (lblSeat.Text == "B13")
            {
                Seat.lblB13.Text = "X";
            }
            else if (lblSeat.Text == "C13")
            {
                Seat.lblC13.Text = "X";
            }
            else if (lblSeat.Text == "D13")
            {
                Seat.lblD13.Text = "X";
            }
            else if (lblSeat.Text == "E13")
            {
                Seat.lblE13.Text = "X";
            }
            else if (lblSeat.Text == "F13")
            {
                Seat.lblF13.Text = "X";
            }

            Seat.btnBuy.Enabled = true;
            Seat.btnResetSeating.Enabled = true;

            this.Close();

        }
    }
}
