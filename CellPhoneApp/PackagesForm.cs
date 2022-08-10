/*
 * File: PackagesForm.cs
 * Author: Miguel Duran 841-17-1372
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 03/27/2021
 * Purpose: This is a menu form where the user chooses
 *          if he wants a individual or family plan.
 */

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
