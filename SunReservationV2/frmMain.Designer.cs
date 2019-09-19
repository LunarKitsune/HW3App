namespace SunReservationV2
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pboxDisplay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.txtAddressInput = new System.Windows.Forms.TextBox();
            this.txtCityInput = new System.Windows.Forms.TextBox();
            this.txtStateInput = new System.Windows.Forms.TextBox();
            this.txtZipInput = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.grpBedTypes = new System.Windows.Forms.GroupBox();
            this.radDouble = new System.Windows.Forms.RadioButton();
            this.radQueen = new System.Windows.Forms.RadioButton();
            this.radKing = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbReservationView = new System.Windows.Forms.RichTextBox();
            this.btnReserveReservation = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnuStripSelection = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutResort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContactResort = new System.Windows.Forms.ToolStripMenuItem();
            this.chkIsMember = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtCreditInput = new System.Windows.Forms.MaskedTextBox();
            this.lboxCards = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDisplay)).BeginInit();
            this.grpBedTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.mnuStripSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxDisplay
            // 
            this.pboxDisplay.Image = ((System.Drawing.Image)(resources.GetObject("pboxDisplay.Image")));
            this.pboxDisplay.Location = new System.Drawing.Point(12, 43);
            this.pboxDisplay.Name = "pboxDisplay";
            this.pboxDisplay.Size = new System.Drawing.Size(249, 151);
            this.pboxDisplay.TabIndex = 0;
            this.pboxDisplay.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Zip:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Check in:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(354, 45);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(100, 20);
            this.txtNameInput.TabIndex = 1;
            // 
            // txtAddressInput
            // 
            this.txtAddressInput.Location = new System.Drawing.Point(354, 87);
            this.txtAddressInput.Name = "txtAddressInput";
            this.txtAddressInput.Size = new System.Drawing.Size(100, 20);
            this.txtAddressInput.TabIndex = 2;
            // 
            // txtCityInput
            // 
            this.txtCityInput.Location = new System.Drawing.Point(354, 131);
            this.txtCityInput.Name = "txtCityInput";
            this.txtCityInput.Size = new System.Drawing.Size(100, 20);
            this.txtCityInput.TabIndex = 3;
            // 
            // txtStateInput
            // 
            this.txtStateInput.Location = new System.Drawing.Point(354, 174);
            this.txtStateInput.Name = "txtStateInput";
            this.txtStateInput.Size = new System.Drawing.Size(43, 20);
            this.txtStateInput.TabIndex = 4;
            // 
            // txtZipInput
            // 
            this.txtZipInput.Location = new System.Drawing.Point(461, 174);
            this.txtZipInput.Name = "txtZipInput";
            this.txtZipInput.Size = new System.Drawing.Size(100, 20);
            this.txtZipInput.TabIndex = 5;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(61, 225);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Check out:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(354, 225);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(207, 20);
            this.dtpCheckOut.TabIndex = 7;
            // 
            // grpBedTypes
            // 
            this.grpBedTypes.Controls.Add(this.radDouble);
            this.grpBedTypes.Controls.Add(this.radQueen);
            this.grpBedTypes.Controls.Add(this.radKing);
            this.grpBedTypes.Location = new System.Drawing.Point(10, 251);
            this.grpBedTypes.Name = "grpBedTypes";
            this.grpBedTypes.Size = new System.Drawing.Size(266, 62);
            this.grpBedTypes.TabIndex = 16;
            this.grpBedTypes.TabStop = false;
            this.grpBedTypes.Text = "Select Size Bed";
            // 
            // radDouble
            // 
            this.radDouble.AutoSize = true;
            this.radDouble.Location = new System.Drawing.Point(179, 32);
            this.radDouble.Name = "radDouble";
            this.radDouble.Size = new System.Drawing.Size(59, 17);
            this.radDouble.TabIndex = 10;
            this.radDouble.TabStop = true;
            this.radDouble.Text = "Double";
            this.radDouble.UseVisualStyleBackColor = true;
            // 
            // radQueen
            // 
            this.radQueen.AutoSize = true;
            this.radQueen.Location = new System.Drawing.Point(91, 32);
            this.radQueen.Name = "radQueen";
            this.radQueen.Size = new System.Drawing.Size(57, 17);
            this.radQueen.TabIndex = 9;
            this.radQueen.TabStop = true;
            this.radQueen.Text = "Queen";
            this.radQueen.UseVisualStyleBackColor = true;
            // 
            // radKing
            // 
            this.radKing.AutoSize = true;
            this.radKing.Location = new System.Drawing.Point(6, 32);
            this.radKing.Name = "radKing";
            this.radKing.Size = new System.Drawing.Size(46, 17);
            this.radKing.TabIndex = 8;
            this.radKing.TabStop = true;
            this.radKing.Text = "King";
            this.radKing.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Credit Card Number";
            // 
            // rtbReservationView
            // 
            this.rtbReservationView.Location = new System.Drawing.Point(354, 251);
            this.rtbReservationView.Name = "rtbReservationView";
            this.rtbReservationView.ReadOnly = true;
            this.rtbReservationView.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbReservationView.Size = new System.Drawing.Size(178, 151);
            this.rtbReservationView.TabIndex = 20;
            this.rtbReservationView.TabStop = false;
            this.rtbReservationView.Text = "";
            // 
            // btnReserveReservation
            // 
            this.btnReserveReservation.Location = new System.Drawing.Point(354, 408);
            this.btnReserveReservation.Name = "btnReserveReservation";
            this.btnReserveReservation.Size = new System.Drawing.Size(178, 56);
            this.btnReserveReservation.TabIndex = 13;
            this.btnReserveReservation.Text = "Reserve Reservation";
            this.btnReserveReservation.UseVisualStyleBackColor = true;
            this.btnReserveReservation.Click += new System.EventHandler(this.BtnReserveReservation_Click);
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // mnuStripSelection
            // 
            this.mnuStripSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuAboutResort,
            this.mnuContactResort});
            this.mnuStripSelection.Location = new System.Drawing.Point(0, 0);
            this.mnuStripSelection.Name = "mnuStripSelection";
            this.mnuStripSelection.Size = new System.Drawing.Size(603, 24);
            this.mnuStripSelection.TabIndex = 23;
            this.mnuStripSelection.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExitApp});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuExitApp
            // 
            this.mnuExitApp.Name = "mnuExitApp";
            this.mnuExitApp.Size = new System.Drawing.Size(93, 22);
            this.mnuExitApp.Text = "&Exit";
            this.mnuExitApp.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // mnuAboutResort
            // 
            this.mnuAboutResort.Name = "mnuAboutResort";
            this.mnuAboutResort.Size = new System.Drawing.Size(116, 20);
            this.mnuAboutResort.Text = "&About Sun Resorts";
            this.mnuAboutResort.Click += new System.EventHandler(this.AboutSunResortsToolStripMenuItem_Click);
            // 
            // mnuContactResort
            // 
            this.mnuContactResort.Name = "mnuContactResort";
            this.mnuContactResort.Size = new System.Drawing.Size(77, 20);
            this.mnuContactResort.Text = "&Contact Us";
            this.mnuContactResort.Click += new System.EventHandler(this.ContactUsToolStripMenuItem_Click);
            // 
            // chkIsMember
            // 
            this.chkIsMember.AutoSize = true;
            this.chkIsMember.Location = new System.Drawing.Point(10, 320);
            this.chkIsMember.Name = "chkIsMember";
            this.chkIsMember.Size = new System.Drawing.Size(122, 17);
            this.chkIsMember.TabIndex = 11;
            this.chkIsMember.Text = "AARP/AAA Member";
            this.chkIsMember.UseVisualStyleBackColor = true;
            // 
            // txtCreditInput
            // 
            this.txtCreditInput.Location = new System.Drawing.Point(165, 382);
            this.txtCreditInput.Mask = "#### #### #### ####";
            this.txtCreditInput.Name = "txtCreditInput";
            this.txtCreditInput.Size = new System.Drawing.Size(111, 20);
            this.txtCreditInput.TabIndex = 24;
            // 
            // lboxCards
            // 
            this.lboxCards.FormattingEnabled = true;
            this.lboxCards.Location = new System.Drawing.Point(10, 357);
            this.lboxCards.Name = "lboxCards";
            this.lboxCards.Size = new System.Drawing.Size(134, 147);
            this.lboxCards.TabIndex = 25;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 506);
            this.Controls.Add(this.lboxCards);
            this.Controls.Add(this.txtCreditInput);
            this.Controls.Add(this.chkIsMember);
            this.Controls.Add(this.btnReserveReservation);
            this.Controls.Add(this.rtbReservationView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpBedTypes);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtZipInput);
            this.Controls.Add(this.txtStateInput);
            this.Controls.Add(this.txtCityInput);
            this.Controls.Add(this.txtAddressInput);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxDisplay);
            this.Controls.Add(this.mnuStripSelection);
            this.MainMenuStrip = this.mnuStripSelection;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDisplay)).EndInit();
            this.grpBedTypes.ResumeLayout(false);
            this.grpBedTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.mnuStripSelection.ResumeLayout(false);
            this.mnuStripSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.TextBox txtAddressInput;
        private System.Windows.Forms.TextBox txtCityInput;
        private System.Windows.Forms.TextBox txtStateInput;
        private System.Windows.Forms.TextBox txtZipInput;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.GroupBox grpBedTypes;
        private System.Windows.Forms.RadioButton radDouble;
        private System.Windows.Forms.RadioButton radQueen;
        private System.Windows.Forms.RadioButton radKing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbReservationView;
        private System.Windows.Forms.Button btnReserveReservation;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.MenuStrip mnuStripSelection;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitApp;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutResort;
        private System.Windows.Forms.ToolStripMenuItem mnuContactResort;
        private System.Windows.Forms.CheckBox chkIsMember;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox txtCreditInput;
        private System.Windows.Forms.ListBox lboxCards;
    }
}

