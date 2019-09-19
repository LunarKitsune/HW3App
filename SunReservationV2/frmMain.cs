//Ken Macneal
//9/13/2019
//Sun Reservation App V2(Framework version)


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SunReservationV2
{
   
    public partial class frmMain : Form
    {
        Reservation reserve = new Reservation();

        public frmMain()
        {
            InitializeComponent();
        }

        #region Interactive Form UI

        #region Menu Strip Buttons
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutSunResortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some detail here", "Sun Reservation App");
        }

        private void ContactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some Contact info here", "Sun Reservation App");
        }

        #endregion Menu Strip Buttons

        private void BtnReserveReservation_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            try
            {
                if (txtNameInput.Text == string.Empty)
                {
                    errProvider.SetError(txtNameInput, "Name Required!");
                }
                else
                {
                    if (txtAddressInput.Text == string.Empty)
                    {
                        errProvider.SetError(txtAddressInput, "Address Required!");
                    }
                    else
                    {
                        if (txtCreditInput.Text == string.Empty || txtCreditInput.Text.Length < 19)
                        {
                            errProvider.SetError(txtCreditInput, "Credit Card Input Error!");
                        }
                        else
                        {
                            if (radDouble.Checked == false && radKing.Checked == false && radQueen.Checked == false)
                            {
                                errProvider.SetError(grpBedTypes, "Must select bed type!");
                            }
                            else
                            {
                                string cardNumber;
                                cardNumber = txtCreditInput.Text;
                                if (lboxCards.Items.Contains(cardNumber) == false)
                                {
                                    lboxCards.Items.Add(cardNumber);
                                }

                                reserve.BedType = (radDouble.Checked) ? bedRoomType.Double : (radKing.Checked) ?     bedRoomType.King : bedRoomType.Queen;

                                reserve.CheckIn = dtpCheckIn.Value;
                                reserve.CheckedOut = dtpCheckOut.Value;
                                reserve.Member = chkIsMember.Checked;
                                reserve.Name = txtNameInput.Text;

                                rtbReservationView.Text = reserve.ToString();
                                
                            }
                        }
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK);
            }
        }

        #endregion Interactive Form UI

        #region Main Form Functions
        private void FrmMain_Load(object sender, EventArgs e)
        {
            dtpCheckIn.MinDate = DateTime.Today;
            dtpCheckOut.MinDate = DateTime.Today.AddDays(1);
            dtpCheckOut.MaxDate = DateTime.Today.AddYears(1);
        }

        #endregion Main Form Functions
    }
}
