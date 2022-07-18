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
    public partial class frmBuyTicket : Form
    {
        //PUBLIC VARIABLES
        // FIRST CLASS
        public static int A1;
        public static int B1;
        public static int C1;
        public static int D1;
        public static int E1;
        public static int F1;
        public static int A2;
        public static int B2;
        public static int C2;
        public static int D2;
        public static int E2;
        public static int F2;

        //BUSINESS CLASS
        public static int A3;
        public static int B3;
        public static int C3;
        public static int D3;
        public static int E3;
        public static int F3;
        public static int A4;
        public static int B4;
        public static int C4;
        public static int D4;
        public static int E4;
        public static int F4;
        public static int A5;
        public static int B5;
        public static int C5;
        public static int D5;
        public static int E5;
        public static int F5;
        public static int A6;
        public static int B6;
        public static int C6;
        public static int D6;
        public static int E6;
        public static int F6;
        public static int A7;
        public static int B7;
        public static int C7;
        public static int D7;
        public static int E7;
        public static int F7;

        //ECONOMIC CLASS
        public static int A8;
        public static int B8;
        public static int C8;
        public static int D8;
        public static int E8;
        public static int F8;
        public static int A9;
        public static int B9;
        public static int C9;
        public static int D9;
        public static int E9;
        public static int F9;
        public static int A10;
        public static int B10;
        public static int C10;
        public static int D10;
        public static int E10;
        public static int F10;
        public static int A11;
        public static int B11;
        public static int C11;
        public static int D11;
        public static int E11;
        public static int F11;
        public static int A12;
        public static int B12;
        public static int C12;
        public static int D12;
        public static int E12;
        public static int F12;
        public static int A13;
        public static int B13;
        public static int C13;
        public static int D13;
        public static int E13;
        public static int F13;

        public frmBuyTicket()
        {
            InitializeComponent();
        }

        private void frmBuyTicket_Load(object sender, EventArgs e)
        {
            cmbClass.SelectedIndex = 0;

            SeatValue();

        }

        private void SeatValue()
        {
            frmSeat formSeat = (frmSeat)Application.OpenForms["frmSeat"];

            if (formSeat.lblA1.Text == "X")
            {
                A1 = 1;
            }
            if (formSeat.lblB1.Text == "X")
            {
                B1 = 1;
            }
            if (formSeat.lblC1.Text == "X")
            {
                C1 = 1;
            }
            if (formSeat.lblD1.Text == "X")
            {
                D1 = 1;
            }
            if (formSeat.lblE1.Text == "X")
            {
                E1 = 1;
            }
            if (formSeat.lblF1.Text == "X")
            {
                F1 = 1;
            }

            if (formSeat.lblA2.Text == "X")
            {
                A2 = 1;
            }
            if (formSeat.lblB2.Text == "X")
            {
                B2 = 1;
            }
            if (formSeat.lblC2.Text == "X")
            {
                C2 = 1;
            }
            if (formSeat.lblD2.Text == "X")
            {
                D2 = 1;
            }
            if (formSeat.lblE2.Text == "X")
            {
                E2 = 1;
            }
            if (formSeat.lblF2.Text == "X")
            {
                F2 = 1;
            }

            if (formSeat.lblA3.Text == "X")
            {
                A3 = 1;
            }
            if (formSeat.lblB3.Text == "X")
            {
                B3 = 1;
            }
            if (formSeat.lblC3.Text == "X")
            {
                C3 = 1;
            }
            if (formSeat.lblD3.Text == "X")
            {
                D3 = 1;
            }
            if (formSeat.lblE3.Text == "X")
            {
                E3 = 1;
            }
            if (formSeat.lblF3.Text == "X")
            {
                F3 = 1;
            }

            if (formSeat.lblA4.Text == "X")
            {
                A4 = 1;
            }
            if (formSeat.lblB4.Text == "X")
            {
                B4 = 1;
            }
            if (formSeat.lblC4.Text == "X")
            {
                C4 = 1;
            }
            if (formSeat.lblD4.Text == "X")
            {
                D4 = 1;
            }
            if (formSeat.lblE4.Text == "X")
            {
                E4 = 1;
            }
            if (formSeat.lblF4.Text == "X")
            {
                F4 = 1;
            }

            if (formSeat.lblA5.Text == "X")
            {
                A5 = 1;
            }
            if (formSeat.lblB5.Text == "X")
            {
                B5 = 1;
            }
            if (formSeat.lblC5.Text == "X")
            {
                C5 = 1;
            }
            if (formSeat.lblD5.Text == "X")
            {
                D5 = 1;
            }
            if (formSeat.lblE5.Text == "X")
            {
                E5 = 1;
            }
            if (formSeat.lblF5.Text == "X")
            {
                F5 = 1;
            }

            if (formSeat.lblA6.Text == "X")
            {
                A6 = 1;
            }
            if (formSeat.lblB6.Text == "X")
            {
                B6 = 1;
            }
            if (formSeat.lblC6.Text == "X")
            {
                C6 = 1;
            }
            if (formSeat.lblD6.Text == "X")
            {
                D6 = 1;
            }
            if (formSeat.lblE6.Text == "X")
            {
                E6 = 1;
            }
            if (formSeat.lblF6.Text == "X")
            {
                F6 = 1;
            }

            if (formSeat.lblA7.Text == "X")
            {
                A7 = 1;
            }
            if (formSeat.lblB7.Text == "X")
            {
                B7 = 1;
            }
            if (formSeat.lblC7.Text == "X")
            {
                C7 = 1;
            }
            if (formSeat.lblD7.Text == "X")
            {
                D7 = 1;
            }
            if (formSeat.lblE7.Text == "X")
            {
                E7 = 1;
            }
            if (formSeat.lblF7.Text == "X")
            {
                F7 = 1;
            }

            if (formSeat.lblA8.Text == "X")
            {
                A8 = 1;
            }
            if (formSeat.lblB8.Text == "X")
            {
                B8 = 1;
            }
            if (formSeat.lblC8.Text == "X")
            {
                C8 = 1;
            }
            if (formSeat.lblD8.Text == "X")
            {
                D8 = 1;
            }
            if (formSeat.lblE8.Text == "X")
            {
                E8 = 1;
            }
            if (formSeat.lblF8.Text == "X")
            {
                F8 = 1;
            }

            if (formSeat.lblA9.Text == "X")
            {
                A9 = 1;
            }
            if (formSeat.lblB9.Text == "X")
            {
                B9 = 1;
            }
            if (formSeat.lblC9.Text == "X")
            {
                C9 = 1;
            }
            if (formSeat.lblD9.Text == "X")
            {
                D9 = 1;
            }
            if (formSeat.lblE9.Text == "X")
            {
                E9 = 1;
            }
            if (formSeat.lblF9.Text == "X")
            {
                F9 = 1;
            }

            if (formSeat.lblA10.Text == "X")
            {
                A10 = 1;
            }
            if (formSeat.lblB10.Text == "X")
            {
                B10 = 1;
            }
            if (formSeat.lblC10.Text == "X")
            {
                C10 = 1;
            }
            if (formSeat.lblD10.Text == "X")
            {
                D10 = 1;
            }
            if (formSeat.lblE10.Text == "X")
            {
                E10 = 1;
            }
            if (formSeat.lblF10.Text == "X")
            {
                F10 = 1;
            }

            if (formSeat.lblA11.Text == "X")
            {
                A11 = 1;
            }
            if (formSeat.lblB11.Text == "X")
            {
                B11 = 1;
            }
            if (formSeat.lblC11.Text == "X")
            {
                C11 = 1;
            }
            if (formSeat.lblD11.Text == "X")
            {
                D11 = 1;
            }
            if (formSeat.lblE11.Text == "X")
            {
                E11 = 1;
            }
            if (formSeat.lblF11.Text == "X")
            {
                F11 = 1;
            }

            if (formSeat.lblA12.Text == "X")
            {
                A12 = 1;
            }
            if (formSeat.lblB12.Text == "X")
            {
                B12 = 1;
            }
            if (formSeat.lblC12.Text == "X")
            {
                C12 = 1;
            }
            if (formSeat.lblD12.Text == "X")
            {
                D12 = 1;
            }
            if (formSeat.lblE12.Text == "X")
            {
                E12 = 1;
            }
            if (formSeat.lblF12.Text == "X")
            {
                F12 = 1;
            }
            if (formSeat.lblA13.Text == "X")
            {
                A13 = 1;
            }
            if (formSeat.lblB13.Text == "X")
            {
                B13 = 1;
            }
            if (formSeat.lblC13.Text == "X")
            {
                C13 = 1;
            }
            if (formSeat.lblD13.Text == "X")
            {
                D13 = 1;
            }
            if (formSeat.lblE13.Text == "X")
            {
                E13 = 1;
            }
            if (formSeat.lblF13.Text == "X")
            {
                F13 = 1;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtbPassportNo.Text == "" || txtbFullname.Text == "" || txtbContact.Text == "" || txbAddress.Text == "")
            {
                MessageBox.Show("All fields required!", "Ticketing App", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtbContact.Text.Length ==  11 || txtbContact.Text.Length == 13)
                {
                    if (cmbClass.SelectedIndex == 0)
                    {
                        MessageBox.Show("Select your class!", "Ticketing App", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (cmbSeatNumber.Text == "")
                        {
                            MessageBox.Show("Select your seat!", "Ticketing App", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            frmConfirm Confirm = new frmConfirm();

                            Confirm.lblPassport.Text = txtbPassportNo.Text;
                            Confirm.lblFullname.Text = txtbFullname.Text;
                            Confirm.lblContact.Text = txtbContact.Text;
                            Confirm.lblAddress.Text = txbAddress.Text;
                            Confirm.lblClass.Text = cmbClass.SelectedItem.ToString();
                            Confirm.lblSeat.Text = cmbSeatNumber.SelectedItem.ToString();
                            Confirm.lblPrice.Text = txtPrice.Text;

                            this.Close();
                            Confirm.Show();
                        }
                    }   
                }
                else
                {
                    MessageBox.Show("Invalid number!", "Ticketing App", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeatNumber.Items.Clear();
            if (cmbClass.SelectedItem.ToString() == "SELECT CLASS")
            {
                txtPrice.Text = "";

            }else if (cmbClass.SelectedItem.ToString() == "First") {

                if (A1 == 0)
                {
                    cmbSeatNumber.Items.Add("A1");
                }
                if (B1 == 0)
                {
                    cmbSeatNumber.Items.Add("B1");
                }
                if (C1 == 0)
                {
                    cmbSeatNumber.Items.Add("C1");
                }
                if (D1 == 0)
                {
                    cmbSeatNumber.Items.Add("D1");
                }
                if (E1 == 0)
                {
                    cmbSeatNumber.Items.Add("E1");
                }
                if (F1 == 0)
                {
                    cmbSeatNumber.Items.Add("F1");
                }
                if (A2 == 0)
                {
                    cmbSeatNumber.Items.Add("A2");
                }
                if (B2 == 0)
                {
                    cmbSeatNumber.Items.Add("B2");
                }
                if (C2 == 0)
                {
                    cmbSeatNumber.Items.Add("C2");
                }
                if (D2 == 0)
                {
                    cmbSeatNumber.Items.Add("D2");
                }
                if (E2 == 0)
                {
                    cmbSeatNumber.Items.Add("E2");
                }
                if (F2 == 0)
                {
                    cmbSeatNumber.Items.Add("F2");
                }

                txtPrice.Text = "1500";
                cmbSeatNumber.SelectedIndex = 0;

            } else if (cmbClass.SelectedItem.ToString() == "Business")
            {
                if (A3 == 0)
                {
                    cmbSeatNumber.Items.Add("A3");
                }
                if (B3 == 0)
                {
                    cmbSeatNumber.Items.Add("B3");
                }
                if (C3 == 0)
                {
                    cmbSeatNumber.Items.Add("C3");
                }
                if (D3 == 0)
                {
                    cmbSeatNumber.Items.Add("D3");
                }
                if (E3 == 0)
                {
                    cmbSeatNumber.Items.Add("E3");
                }
                if (F3 == 0)
                {
                    cmbSeatNumber.Items.Add("F3");
                }
                if (A4 == 0)
                {
                    cmbSeatNumber.Items.Add("A4");
                }
                if (B4 == 0)
                {
                    cmbSeatNumber.Items.Add("B4");
                }
                if (C4 == 0)
                {
                    cmbSeatNumber.Items.Add("C4");
                }
                if (D4 == 0)
                {
                    cmbSeatNumber.Items.Add("D4");
                }
                if (E4 == 0)
                {
                    cmbSeatNumber.Items.Add("E4");
                }
                if (F4 == 0)
                {
                    cmbSeatNumber.Items.Add("F4");
                }
                if (A5 == 0)
                {
                    cmbSeatNumber.Items.Add("A5");
                }
                if (B5 == 0)
                {
                    cmbSeatNumber.Items.Add("B5");
                }
                if (C5 == 0)
                {
                    cmbSeatNumber.Items.Add("C5");
                }
                if (D5 == 0)
                {
                    cmbSeatNumber.Items.Add("D5");
                }
                if (E5 == 0)
                {
                    cmbSeatNumber.Items.Add("E5");
                }
                if (F5 == 0)
                {
                    cmbSeatNumber.Items.Add("F5");
                }
                if (A6 == 0)
                {
                    cmbSeatNumber.Items.Add("A6");
                }
                if (B6 == 0)
                {
                    cmbSeatNumber.Items.Add("B6");
                }
                if (C6 == 0)
                {
                    cmbSeatNumber.Items.Add("C6");
                }
                if (D6 == 0)
                {
                    cmbSeatNumber.Items.Add("D6");
                }
                if (E6 == 0)
                {
                    cmbSeatNumber.Items.Add("E6");
                }
                if (F6 == 0)
                {
                    cmbSeatNumber.Items.Add("F6");
                }
                if (A7 == 0)
                {
                    cmbSeatNumber.Items.Add("A7");
                }
                if (B7 == 0)
                {
                    cmbSeatNumber.Items.Add("B7");
                }
                if (C7 == 0)
                {
                    cmbSeatNumber.Items.Add("C7");
                }
                if (D7 == 0)
                {
                    cmbSeatNumber.Items.Add("D7");
                }
                if (E7 == 0)
                {
                    cmbSeatNumber.Items.Add("E7");
                }
                if (F7 == 0)
                {
                    cmbSeatNumber.Items.Add("F7");
                }

                txtPrice.Text = "1100";
                cmbSeatNumber.SelectedIndex = 0;

            }
            else if(cmbClass.SelectedItem.ToString() == "Economy")
            {
                if (A8 == 0)
                {
                    cmbSeatNumber.Items.Add("A8");
                }
                if (B8 == 0)
                {
                    cmbSeatNumber.Items.Add("B8");
                }
                if (C8 == 0)
                {
                    cmbSeatNumber.Items.Add("C8");
                }
                if (D8 == 0)
                {
                    cmbSeatNumber.Items.Add("D8");
                }
                if (E8 == 0)
                {
                    cmbSeatNumber.Items.Add("E8");
                }
                if (F8 == 0)
                {
                    cmbSeatNumber.Items.Add("F8");
                }
                if (A9 == 0)
                {
                    cmbSeatNumber.Items.Add("A9");
                }
                if (B9 == 0)
                {
                    cmbSeatNumber.Items.Add("B9");
                }
                if (C9 == 0)
                {
                    cmbSeatNumber.Items.Add("C9");
                }
                if (D9 == 0)
                {
                    cmbSeatNumber.Items.Add("D9");
                }
                if (E9 == 0)
                {
                    cmbSeatNumber.Items.Add("E9");
                }
                if (F9 == 0)
                {
                    cmbSeatNumber.Items.Add("F9");
                }
                if (A10 == 0)
                {
                    cmbSeatNumber.Items.Add("A10");
                }
                if (B10 == 0)
                {
                    cmbSeatNumber.Items.Add("B10");
                }
                if (C10 == 0)
                {
                    cmbSeatNumber.Items.Add("C10");
                }
                if (D10 == 0)
                {
                    cmbSeatNumber.Items.Add("D10");
                }
                if (E10 == 0)
                {
                    cmbSeatNumber.Items.Add("E10");
                }
                if (F10 == 0)
                {
                    cmbSeatNumber.Items.Add("F10");
                }
                if (A11 == 0)
                {
                    cmbSeatNumber.Items.Add("A11");
                }
                if (B11 == 0)
                {
                    cmbSeatNumber.Items.Add("B11");
                }
                if (C11 == 0)
                {
                    cmbSeatNumber.Items.Add("C11");
                }
                if (D11 == 0)
                {
                    cmbSeatNumber.Items.Add("D11");
                }
                if (E11 == 0)
                {
                    cmbSeatNumber.Items.Add("E11");
                }
                if (F11 == 0)
                {
                    cmbSeatNumber.Items.Add("F11");
                }
                if (A12 == 0)
                {
                    cmbSeatNumber.Items.Add("A12");
                }
                if (B12 == 0)
                {
                    cmbSeatNumber.Items.Add("B12");
                }
                if (C12 == 0)
                {
                    cmbSeatNumber.Items.Add("C12");
                }
                if (D12 == 0)
                {
                    cmbSeatNumber.Items.Add("D12");
                }
                if (E12 == 0)
                {
                    cmbSeatNumber.Items.Add("E12");
                }
                if (F12 == 0)
                {
                    cmbSeatNumber.Items.Add("F12");
                }
                if (A13 == 0)
                {
                    cmbSeatNumber.Items.Add("A13");
                }
                if (B13 == 0)
                {
                    cmbSeatNumber.Items.Add("B13");
                }
                if (C13 == 0)
                {
                    cmbSeatNumber.Items.Add("C13");
                }
                if (D13 == 0)
                {
                    cmbSeatNumber.Items.Add("D13");
                }
                if (E13 == 0)
                {
                    cmbSeatNumber.Items.Add("E13");
                }
                if (F13 == 0)
                {
                    cmbSeatNumber.Items.Add("F13");
                }

                txtPrice.Text = "800";
                cmbSeatNumber.SelectedIndex = 0;
            }
           
        }

        private void txtbContact_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string phone_number = txtbContact.Text.Trim();
                txtbContact.Text = phone_number.ToString();
                txtbContact.SelectionStart = txtbContact.Text.Length;
                txtbContact.SelectionLength = 0;

                string str = txtbContact.Text;
                string res = str.Substring(0, 1);

                if (res.ToString() == "0")
                {
                    txtbContact.MaxLength = 11;
                }
                else if (res.ToString() == "+")
                {
                    txtbContact.MaxLength = 13;
                }
                else
                {
                    txtbContact.Clear();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '+' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
