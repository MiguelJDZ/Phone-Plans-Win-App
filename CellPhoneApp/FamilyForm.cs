using System;
using System.Windows.Forms;

namespace CellPhoneApp
{
    public partial class FamilyForm : Form
    {
        // Declare instance variables for the subtotal, tax, total, options, pckage charge and total per month.
        private double subtotal;
        private double tax;
        private double total;
        private double options;
        private double packagecharge;
        private double totalmonth;

        // Initializes form.
        public FamilyForm()
        {
            InitializeComponent();
        }

        // Tries method or else catches error exceptions.
        private void btnViewTotal_Click(object sender, EventArgs e)
        { 
            try
            {
                if (rdo800Min.Checked || rdo1500Min.Checked || rdoUnlMin.Checked)
                {
                    if (rdoModel100.Checked || rdoModel110.Checked || rdoModel200.Checked)
                    {
                        RadioModel();
                        CheckOptions();
                        RadioMin();

                        tax = subtotal * 0.115;
                        txtTax.Text = tax.ToString("c");
                        total = subtotal + tax;
                        txtTotal.Text = total.ToString("c");
                        totalmonth = options + packagecharge;
                        txtTotalMonth.Text = totalmonth.ToString("c");
                    }
                    else
                        MessageBox.Show("Must select atleast 1 model", "Select a Model", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Must select atleast 1 minutes plan", "Select a Plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException. Try using smaller numbers.", "Entry Error");
            }
            catch (FormatException)
            {
                MessageBox.Show("All entries must be numeric.", "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ": " + ex.Message, "Unknown Exception");
            }
        }

        // Method checks wich radio of models is checked and adds it to the subtotal.
        private void RadioModel()
        {
            double numbofphones = Convert.ToInt32(nmrNumberPhones.Value);

            if (rdoModel100.Checked)
                subtotal = 229.95 * numbofphones;
            else if (rdoModel110.Checked)
                subtotal = 249.95 * numbofphones;
            else if (rdoModel200.Checked)
                subtotal = 299.95 * numbofphones;
            txtSubtotal.Text = subtotal.ToString("c");
        }

        // Method checks wich checkmark of options is checked and adds it to the subtotal.
        private void CheckOptions()
        {
            double numbofphones = Convert.ToInt32(nmrNumberPhones.Value);

            if (checkEmail.Checked && checkText.Checked)
                options = 35.00 * numbofphones;
            else if (checkText.Checked)
                options = 10.00 * numbofphones;
            else if (checkEmail.Checked)
                options = 25.00 * numbofphones;
            else
                options = 0.00;
            txtOptions.Text = options.ToString("c");
        }

        // Method checks wich radio of minutes per month is checked and adds it to the subtotal.
        private void RadioMin()
        {
            if (rdo800Min.Checked)
                packagecharge = 45.00;
            else if (rdo1500Min.Checked)
                packagecharge = 65.00;
            else if (rdoUnlMin.Checked)
                packagecharge = 99.00;
            txtPackCharge.Text = packagecharge.ToString("c");
        }

        // Event handler when nmrNumberPhones is changed.
        private void nmrNumberPhones_ValueChanged(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtOptions.Clear();
            txtPackCharge.Clear();
            txtTotalMonth.Clear();
        }

        // Event handler when rdoModel100 is changed.
        private void rdoModel100_CheckedChanged(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtOptions.Clear();
            txtPackCharge.Clear();
            txtTotalMonth.Clear();
        }

        // Event handler when rdoModel110 is changed.
        private void rdoModel110_CheckedChanged(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtOptions.Clear();
            txtPackCharge.Clear();
            txtTotalMonth.Clear();
        }

        // Event handler when rdoModel200 is changed.
        private void rdoModel200_CheckedChanged(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtOptions.Clear();
            txtPackCharge.Clear();
            txtTotalMonth.Clear();
        }

        // Event handler when checkEmail is changed.
        private void checkEmail_CheckedChanged(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtOptions.Clear();
            txtPackCharge.Clear();
            txtTotalMonth.Clear();
        }

        // Event handler when checkText is changed.
        private void checkText_CheckedChanged(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtOptions.Clear();
            txtPackCharge.Clear();
            txtTotalMonth.Clear();
        }

        // Event handler when rdo800min is changed.
        private void rdo800Min_CheckedChanged(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtOptions.Clear();
            txtPackCharge.Clear();
            txtTotalMonth.Clear();
        }

        // Event handler when rdo1500min is changed.
        private void rdo1500Min_CheckedChanged(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtOptions.Clear();
            txtPackCharge.Clear();
            txtTotalMonth.Clear();
        }

        // Event handler when rdoUnlMin is changed.
        private void rdoUnlMin_CheckedChanged(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtOptions.Clear();
            txtPackCharge.Clear();
            txtTotalMonth.Clear();
        }

        //Event handler CLOSE button is clicked.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
