
namespace CellPhoneApp
{
    partial class PackagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackagesForm));
            this.grpPlans = new System.Windows.Forms.GroupBox();
            this.btnFamily = new System.Windows.Forms.Button();
            this.lblFamily = new System.Windows.Forms.Label();
            this.imgFamily = new System.Windows.Forms.PictureBox();
            this.imgIndividual = new System.Windows.Forms.PictureBox();
            this.btnIndividual = new System.Windows.Forms.Button();
            this.lblIndividual = new System.Windows.Forms.Label();
            this.imgPhone = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpPlans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIndividual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPlans
            // 
            this.grpPlans.Controls.Add(this.btnFamily);
            this.grpPlans.Controls.Add(this.lblFamily);
            this.grpPlans.Controls.Add(this.imgFamily);
            this.grpPlans.Controls.Add(this.imgIndividual);
            this.grpPlans.Controls.Add(this.btnIndividual);
            this.grpPlans.Controls.Add(this.lblIndividual);
            this.grpPlans.Location = new System.Drawing.Point(23, 37);
            this.grpPlans.Name = "grpPlans";
            this.grpPlans.Size = new System.Drawing.Size(606, 290);
            this.grpPlans.TabIndex = 0;
            this.grpPlans.TabStop = false;
            this.grpPlans.Text = "Select a Plan";
            // 
            // btnFamily
            // 
            this.btnFamily.Location = new System.Drawing.Point(253, 184);
            this.btnFamily.Name = "btnFamily";
            this.btnFamily.Size = new System.Drawing.Size(75, 23);
            this.btnFamily.TabIndex = 1;
            this.btnFamily.Text = "&Family";
            this.btnFamily.UseVisualStyleBackColor = true;
            this.btnFamily.Click += new System.EventHandler(this.btnFamily_Click);
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(26, 168);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(173, 52);
            this.lblFamily.TabIndex = 4;
            this.lblFamily.Text = "A family plan allows you to\r\npurchase multiple cellphones of the\r\n same model, wi" +
    "th each phone\r\nsharing one monthly package.";
            // 
            // imgFamily
            // 
            this.imgFamily.Image = ((System.Drawing.Image)(resources.GetObject("imgFamily.Image")));
            this.imgFamily.Location = new System.Drawing.Point(387, 168);
            this.imgFamily.Name = "imgFamily";
            this.imgFamily.Size = new System.Drawing.Size(188, 100);
            this.imgFamily.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFamily.TabIndex = 3;
            this.imgFamily.TabStop = false;
            // 
            // imgIndividual
            // 
            this.imgIndividual.Image = ((System.Drawing.Image)(resources.GetObject("imgIndividual.Image")));
            this.imgIndividual.Location = new System.Drawing.Point(406, 34);
            this.imgIndividual.Name = "imgIndividual";
            this.imgIndividual.Size = new System.Drawing.Size(169, 109);
            this.imgIndividual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIndividual.TabIndex = 2;
            this.imgIndividual.TabStop = false;
            // 
            // btnIndividual
            // 
            this.btnIndividual.Location = new System.Drawing.Point(253, 50);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.Size = new System.Drawing.Size(75, 23);
            this.btnIndividual.TabIndex = 0;
            this.btnIndividual.Text = "&Individual";
            this.btnIndividual.UseVisualStyleBackColor = true;
            this.btnIndividual.Click += new System.EventHandler(this.btnIndividual_Click);
            // 
            // lblIndividual
            // 
            this.lblIndividual.AutoSize = true;
            this.lblIndividual.Location = new System.Drawing.Point(26, 34);
            this.lblIndividual.Name = "lblIndividual";
            this.lblIndividual.Size = new System.Drawing.Size(171, 39);
            this.lblIndividual.TabIndex = 0;
            this.lblIndividual.Text = "The individual plan provides one\r\ncell phone and a variety of monthly\r\npackages.";
            // 
            // imgPhone
            // 
            this.imgPhone.Image = ((System.Drawing.Image)(resources.GetObject("imgPhone.Image")));
            this.imgPhone.Location = new System.Drawing.Point(23, 333);
            this.imgPhone.Name = "imgPhone";
            this.imgPhone.Size = new System.Drawing.Size(175, 161);
            this.imgPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPhone.TabIndex = 1;
            this.imgPhone.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(523, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(657, 522);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.imgPhone);
            this.Controls.Add(this.grpPlans);
            this.Name = "PackagesForm";
            this.Text = "Cell Phone Packages";
            this.grpPlans.ResumeLayout(false);
            this.grpPlans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIndividual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlans;
        private System.Windows.Forms.Button btnFamily;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.PictureBox imgFamily;
        private System.Windows.Forms.PictureBox imgIndividual;
        private System.Windows.Forms.Button btnIndividual;
        private System.Windows.Forms.Label lblIndividual;
        private System.Windows.Forms.PictureBox imgPhone;
        private System.Windows.Forms.Button btnExit;
    }
}

