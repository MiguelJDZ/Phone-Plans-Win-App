using System;
using System.Windows.Forms;

namespace CellPhoneApp
{
    public partial class PackagesForm : Form
    {
        // Initializes form.
        public PackagesForm()
        {
            InitializeComponent();
        }

        // Event handler when INDIVIDUAL button is clicked.
        private void btnIndividual_Click(object sender, EventArgs e)
        {
            IndividualForm frmIndividual = new IndividualForm();
            frmIndividual.Show();
        }

        // Event handler when FAMILY is clicked.
        private void btnFamily_Click(object sender, EventArgs e)
        {
            FamilyForm frmFamily = new FamilyForm();
            frmFamily.Show();
        }

        // Event handler when EXIT is clicked.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
