
namespace CellPhoneApp
{
    partial class IndividualForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualForm));
            this.grpTotals = new System.Windows.Forms.GroupBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalMonth = new System.Windows.Forms.TextBox();
            this.txtPackCharge = new System.Windows.Forms.TextBox();
            this.txtOptions = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblPackCharge = new System.Windows.Forms.Label();
            this.lblTotalMonth = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.checkText = new System.Windows.Forms.CheckBox();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.grpPackages = new System.Windows.Forms.GroupBox();
            this.rdo800Min = new System.Windows.Forms.RadioButton();
            this.rdo1500Min = new System.Windows.Forms.RadioButton();
            this.rdoUnlMin = new System.Windows.Forms.RadioButton();
            this.imgIndividualForm = new System.Windows.Forms.PictureBox();
            this.btnViewTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpModels = new System.Windows.Forms.GroupBox();
            this.rdoModel200 = new System.Windows.Forms.RadioButton();
            this.rdoModel100 = new System.Windows.Forms.RadioButton();
            this.rdoModel110 = new System.Windows.Forms.RadioButton();
            this.grpTotals.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIndividualForm)).BeginInit();
            this.grpModels.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTotals
            // 
            this.grpTotals.Controls.Add(this.txtTax);
            this.grpTotals.Controls.Add(this.txtTotal);
            this.grpTotals.Controls.Add(this.txtTotalMonth);
            this.grpTotals.Controls.Add(this.txtPackCharge);
            this.grpTotals.Controls.Add(this.txtOptions);
            this.grpTotals.Controls.Add(this.txtSubtotal);
            this.grpTotals.Controls.Add(this.lblTax);
            this.grpTotals.Controls.Add(this.lblTotal);
            this.grpTotals.Controls.Add(this.lblOptions);
            this.grpTotals.Controls.Add(this.lblPackCharge);
            this.grpTotals.Controls.Add(this.lblTotalMonth);
            this.grpTotals.Controls.Add(this.lblSubtotal);
            this.grpTotals.Location = new System.Drawing.Point(224, 188);
            this.grpTotals.Name = "grpTotals";
            this.grpTotals.Size = new System.Drawing.Size(234, 298);
            this.grpTotals.TabIndex = 1;
            this.grpTotals.TabStop = false;
            this.grpTotals.Text = "Totals";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(128, 82);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 10;
            this.txtTax.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(128, 128);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TabStop = false;
            // 
            // txtTotalMonth
            // 
            this.txtTotalMonth.Location = new System.Drawing.Point(128, 267);
            this.txtTotalMonth.Name = "txtTotalMonth";
            this.txtTotalMonth.ReadOnly = true;
            this.txtTotalMonth.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMonth.TabIndex = 14;
            this.txtTotalMonth.TabStop = false;
            // 
            // txtPackCharge
            // 
            this.txtPackCharge.Location = new System.Drawing.Point(128, 220);
            this.txtPackCharge.Name = "txtPackCharge";
            this.txtPackCharge.ReadOnly = true;
            this.txtPackCharge.Size = new System.Drawing.Size(100, 20);
            this.txtPackCharge.TabIndex = 13;
            this.txtPackCharge.TabStop = false;
            // 
            // txtOptions
            // 
            this.txtOptions.Location = new System.Drawing.Point(128, 174);
            this.txtOptions.Name = "txtOptions";
            this.txtOptions.ReadOnly = true;
            this.txtOptions.Size = new System.Drawing.Size(100, 20);
            this.txtOptions.TabIndex = 12;
            this.txtOptions.TabStop = false;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(128, 37);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 9;
            this.txtSubtotal.TabStop = false;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(16, 85);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 13);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(16, 131);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Phone Total:";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(16, 177);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(46, 13);
            this.lblOptions.TabIndex = 3;
            this.lblOptions.Text = "Options:";
            // 
            // lblPackCharge
            // 
            this.lblPackCharge.AutoSize = true;
            this.lblPackCharge.Location = new System.Drawing.Point(16, 223);
            this.lblPackCharge.Name = "lblPackCharge";
            this.lblPackCharge.Size = new System.Drawing.Size(90, 13);
            this.lblPackCharge.TabIndex = 2;
            this.lblPackCharge.Text = "Package Charge:";
            // 
            // lblTotalMonth
            // 
            this.lblTotalMonth.AutoSize = true;
            this.lblTotalMonth.Location = new System.Drawing.Point(16, 270);
            this.lblTotalMonth.Name = "lblTotalMonth";
            this.lblTotalMonth.Size = new System.Drawing.Size(111, 13);
            this.lblTotalMonth.TabIndex = 1;
            this.lblTotalMonth.Text = "Total Monthly Charge:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(16, 40);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(83, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Phone Subtotal:";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.checkText);
            this.grpOptions.Controls.Add(this.checkEmail);
            this.grpOptions.Location = new System.Drawing.Point(24, 188);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(168, 102);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Select Option";
            // 
            // checkText
            // 
            this.checkText.AutoSize = true;
            this.checkText.Location = new System.Drawing.Point(20, 71);
            this.checkText.Name = "checkText";
            this.checkText.Size = new System.Drawing.Size(101, 17);
            this.checkText.TabIndex = 5;
            this.checkText.TabStop = false;
            this.checkText.Text = "Text Messaging";
            this.checkText.UseVisualStyleBackColor = true;
            this.checkText.CheckedChanged += new System.EventHandler(this.checkText_CheckedChanged);
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Location = new System.Drawing.Point(20, 36);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(51, 17);
            this.checkEmail.TabIndex = 4;
            this.checkEmail.TabStop = false;
            this.checkEmail.Text = "Email";
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.CheckedChanged += new System.EventHandler(this.checkEmail_CheckedChanged);
            // 
            // grpPackages
            // 
            this.grpPackages.Controls.Add(this.rdo800Min);
            this.grpPackages.Controls.Add(this.rdo1500Min);
            this.grpPackages.Controls.Add(this.rdoUnlMin);
            this.grpPackages.Location = new System.Drawing.Point(224, 24);
            this.grpPackages.Name = "grpPackages";
            this.grpPackages.Size = new System.Drawing.Size(234, 139);
            this.grpPackages.TabIndex = 1;
            this.grpPackages.TabStop = false;
            this.grpPackages.Text = "Select a Package";
            // 
            // rdo800Min
            // 
            this.rdo800Min.AutoSize = true;
            this.rdo800Min.Location = new System.Drawing.Point(19, 28);
            this.rdo800Min.Name = "rdo800Min";
            this.rdo800Min.Size = new System.Drawing.Size(118, 17);
            this.rdo800Min.TabIndex = 6;
            this.rdo800Min.Text = "800 Minutes/Month";
            this.rdo800Min.UseVisualStyleBackColor = true;
            this.rdo800Min.CheckedChanged += new System.EventHandler(this.rdo800Min_CheckedChanged);
            // 
            // rdo1500Min
            // 
            this.rdo1500Min.AutoSize = true;
            this.rdo1500Min.Location = new System.Drawing.Point(19, 66);
            this.rdo1500Min.Name = "rdo1500Min";
            this.rdo1500Min.Size = new System.Drawing.Size(124, 17);
            this.rdo1500Min.TabIndex = 7;
            this.rdo1500Min.Text = "1500 Minutes/Month";
            this.rdo1500Min.UseVisualStyleBackColor = true;
            this.rdo1500Min.CheckedChanged += new System.EventHandler(this.rdo1500Min_CheckedChanged);
            // 
            // rdoUnlMin
            // 
            this.rdoUnlMin.AutoSize = true;
            this.rdoUnlMin.Location = new System.Drawing.Point(19, 105);
            this.rdoUnlMin.Name = "rdoUnlMin";
            this.rdoUnlMin.Size = new System.Drawing.Size(108, 17);
            this.rdoUnlMin.TabIndex = 8;
            this.rdoUnlMin.Text = "Unlimited Minutes";
            this.rdoUnlMin.UseVisualStyleBackColor = true;
            this.rdoUnlMin.CheckedChanged += new System.EventHandler(this.rdoUnlMin_CheckedChanged);
            // 
            // imgIndividualForm
            // 
            this.imgIndividualForm.Image = ((System.Drawing.Image)(resources.GetObject("imgIndividualForm.Image")));
            this.imgIndividualForm.Location = new System.Drawing.Point(24, 316);
            this.imgIndividualForm.Name = "imgIndividualForm";
            this.imgIndividualForm.Size = new System.Drawing.Size(168, 101);
            this.imgIndividualForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIndividualForm.TabIndex = 2;
            this.imgIndividualForm.TabStop = false;
            // 
            // btnViewTotal
            // 
            this.btnViewTotal.Location = new System.Drawing.Point(24, 434);
            this.btnViewTotal.Name = "btnViewTotal";
            this.btnViewTotal.Size = new System.Drawing.Size(75, 23);
            this.btnViewTotal.TabIndex = 0;
            this.btnViewTotal.Text = "View Totals";
            this.btnViewTotal.UseVisualStyleBackColor = true;
            this.btnViewTotal.Click += new System.EventHandler(this.btnViewTotal_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(24, 463);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpModels
            // 
            this.grpModels.Controls.Add(this.rdoModel200);
            this.grpModels.Controls.Add(this.rdoModel100);
            this.grpModels.Controls.Add(this.rdoModel110);
            this.grpModels.Location = new System.Drawing.Point(24, 24);
            this.grpModels.Name = "grpModels";
            this.grpModels.Size = new System.Drawing.Size(168, 139);
            this.grpModels.TabIndex = 6;
            this.grpModels.TabStop = false;
            this.grpModels.Text = "Select a Model";
            // 
            // rdoModel200
            // 
            this.rdoModel200.AutoSize = true;
            this.rdoModel200.Location = new System.Drawing.Point(20, 105);
            this.rdoModel200.Name = "rdoModel200";
            this.rdoModel200.Size = new System.Drawing.Size(75, 17);
            this.rdoModel200.TabIndex = 3;
            this.rdoModel200.Text = "Model 200";
            this.rdoModel200.UseVisualStyleBackColor = true;
            this.rdoModel200.CheckedChanged += new System.EventHandler(this.rdoModel200_CheckedChanged);
            // 
            // rdoModel100
            // 
            this.rdoModel100.AutoSize = true;
            this.rdoModel100.Location = new System.Drawing.Point(20, 28);
            this.rdoModel100.Name = "rdoModel100";
            this.rdoModel100.Size = new System.Drawing.Size(75, 17);
            this.rdoModel100.TabIndex = 1;
            this.rdoModel100.Text = "Model 100";
            this.rdoModel100.UseVisualStyleBackColor = true;
            this.rdoModel100.CheckedChanged += new System.EventHandler(this.rdoModel100_CheckedChanged);
            // 
            // rdoModel110
            // 
            this.rdoModel110.AutoSize = true;
            this.rdoModel110.Location = new System.Drawing.Point(20, 66);
            this.rdoModel110.Name = "rdoModel110";
            this.rdoModel110.Size = new System.Drawing.Size(75, 17);
            this.rdoModel110.TabIndex = 2;
            this.rdoModel110.Text = "Model 110";
            this.rdoModel110.UseVisualStyleBackColor = true;
            this.rdoModel110.CheckedChanged += new System.EventHandler(this.rdoModel110_CheckedChanged);
            // 
            // IndividualForm
            // 
            this.AcceptButton = this.btnViewTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(485, 499);
            this.Controls.Add(this.grpModels);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewTotal);
            this.Controls.Add(this.imgIndividualForm);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpPackages);
            this.Controls.Add(this.grpTotals);
            this.Name = "IndividualForm";
            this.Text = "Individual Plan";
            this.Load += new System.EventHandler(this.IndividualForm_Load);
            this.grpTotals.ResumeLayout(false);
            this.grpTotals.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpPackages.ResumeLayout(false);
            this.grpPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIndividualForm)).EndInit();
            this.grpModels.ResumeLayout(false);
            this.grpModels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpTotals;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblPackCharge;
        private System.Windows.Forms.Label lblTotalMonth;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox checkText;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.GroupBox grpPackages;
        private System.Windows.Forms.RadioButton rdo800Min;
        private System.Windows.Forms.RadioButton rdo1500Min;
        private System.Windows.Forms.RadioButton rdoUnlMin;
        private System.Windows.Forms.PictureBox imgIndividualForm;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotalMonth;
        private System.Windows.Forms.TextBox txtPackCharge;
        private System.Windows.Forms.TextBox txtOptions;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnViewTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpModels;
        private System.Windows.Forms.RadioButton rdoModel200;
        private System.Windows.Forms.RadioButton rdoModel100;
        private System.Windows.Forms.RadioButton rdoModel110;
    }
}