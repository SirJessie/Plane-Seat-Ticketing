namespace TicketingApp
{
    partial class frmBuyTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label92 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbFullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbPassportNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbSeatNumber = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label92);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 56);
            this.panel1.TabIndex = 0;
            // 
            // label92
            // 
            this.label92.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label92.AutoSize = true;
            this.label92.BackColor = System.Drawing.Color.Transparent;
            this.label92.Font = new System.Drawing.Font("Impact", 20F);
            this.label92.ForeColor = System.Drawing.Color.White;
            this.label92.Location = new System.Drawing.Point(12, 9);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(135, 34);
            this.label92.TabIndex = 138;
            this.label92.Text = "BUY TICKET";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbContact);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbFullname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbPassportNo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Impact", 18F);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(21, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 388);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONAL INFORMATION";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 14F);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(23, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 144;
            this.label4.Text = "ADDRESS";
            // 
            // txbAddress
            // 
            this.txbAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbAddress.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.txbAddress.Location = new System.Drawing.Point(23, 273);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(479, 109);
            this.txbAddress.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 14F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(23, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 142;
            this.label3.Text = "CONTACT #";
            // 
            // txtbContact
            // 
            this.txtbContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbContact.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.txtbContact.Location = new System.Drawing.Point(23, 206);
            this.txtbContact.MaxLength = 13;
            this.txtbContact.Name = "txtbContact";
            this.txtbContact.Size = new System.Drawing.Size(479, 38);
            this.txtbContact.TabIndex = 141;
            this.txtbContact.TextChanged += new System.EventHandler(this.txtbContact_TextChanged);
            this.txtbContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbContact_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 14F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 140;
            this.label2.Text = "FULLNAME";
            // 
            // txtbFullname
            // 
            this.txtbFullname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbFullname.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.txtbFullname.Location = new System.Drawing.Point(23, 139);
            this.txtbFullname.Name = "txtbFullname";
            this.txtbFullname.Size = new System.Drawing.Size(479, 38);
            this.txtbFullname.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 14F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 138;
            this.label1.Text = "PASSPORT #";
            // 
            // txtbPassportNo
            // 
            this.txtbPassportNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbPassportNo.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.txtbPassportNo.Location = new System.Drawing.Point(23, 70);
            this.txtbPassportNo.Name = "txtbPassportNo";
            this.txtbPassportNo.Size = new System.Drawing.Size(479, 38);
            this.txtbPassportNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.cmbSeatNumber);
            this.groupBox2.Controls.Add(this.cmbClass);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Impact", 18F);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(21, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 146);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TICKET TYPE";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.txtPrice.Location = new System.Drawing.Point(308, 94);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(194, 38);
            this.txtPrice.TabIndex = 150;
            // 
            // cmbSeatNumber
            // 
            this.cmbSeatNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeatNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeatNumber.FormattingEnabled = true;
            this.cmbSeatNumber.Location = new System.Drawing.Point(130, 100);
            this.cmbSeatNumber.Name = "cmbSeatNumber";
            this.cmbSeatNumber.Size = new System.Drawing.Size(93, 31);
            this.cmbSeatNumber.TabIndex = 149;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "SELECT CLASS",
            "First",
            "Business",
            "Economy"});
            this.cmbClass.Location = new System.Drawing.Point(76, 48);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(426, 31);
            this.cmbClass.TabIndex = 148;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 14F);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(248, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 147;
            this.label7.Text = "PRICE";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 14F);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(13, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 146;
            this.label6.Text = "SEAT NUMBER";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 14F);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(13, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 145;
            this.label5.Text = "CLASS";
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.BackColor = System.Drawing.Color.Maroon;
            this.btnBuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyTicket.Font = new System.Drawing.Font("Impact", 20F);
            this.btnBuyTicket.ForeColor = System.Drawing.Color.White;
            this.btnBuyTicket.Location = new System.Drawing.Point(21, 619);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(520, 61);
            this.btnBuyTicket.TabIndex = 140;
            this.btnBuyTicket.Text = "BUY TICKET";
            this.btnBuyTicket.UseVisualStyleBackColor = false;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmBuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 695);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBuyTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TICKETING APP | BUY TICKET";
            this.Load += new System.EventHandler(this.frmBuyTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuyTicket;
        public System.Windows.Forms.TextBox txtbPassportNo;
        public System.Windows.Forms.TextBox txbAddress;
        public System.Windows.Forms.TextBox txtbContact;
        public System.Windows.Forms.TextBox txtbFullname;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.ComboBox cmbSeatNumber;
        public System.Windows.Forms.ComboBox cmbClass;
    }
}