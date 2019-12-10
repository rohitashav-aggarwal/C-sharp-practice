using System;

namespace checkout
{
    partial class frmCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PayAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.TaxAmount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(51, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(440, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(295, 34);
            this.txtPrice.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(440, 91);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(295, 34);
            this.txtQuantity.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(312, 149);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(167, 43);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price:";
            // 
            // PayAmount
            // 
            this.PayAmount.AutoSize = true;
            this.PayAmount.Location = new System.Drawing.Point(307, 378);
            this.PayAmount.Name = "PayAmount";
            this.PayAmount.Size = new System.Drawing.Size(150, 29);
            this.PayAmount.TabIndex = 6;
            this.PayAmount.Text = "Pay Amount";
            this.PayAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PayAmount.Click += new System.EventHandler(this.PayAmount_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 42);
            this.label3.TabIndex = 7;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Location = new System.Drawing.Point(316, 220);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(109, 29);
            this.SubTotal.TabIndex = 8;
            this.SubTotal.Text = "Subtotal";
            // 
            // TaxAmount
            // 
            this.TaxAmount.AutoSize = true;
            this.TaxAmount.Location = new System.Drawing.Point(318, 304);
            this.TaxAmount.Name = "TaxAmount";
            this.TaxAmount.Size = new System.Drawing.Size(107, 29);
            this.TaxAmount.TabIndex = 9;
            this.TaxAmount.Text = "5 % Tax";
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(514, 291);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(221, 42);
            this.lblTax.TabIndex = 10;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(514, 214);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(221, 42);
            this.lblSubTotal.TabIndex = 11;
            // 
            // lblClear
            // 
            this.lblClear.Location = new System.Drawing.Point(546, 149);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(167, 43);
            this.lblClear.TabIndex = 12;
            this.lblClear.Text = "&Clear";
            this.lblClear.UseVisualStyleBackColor = true;
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(966, 505);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.TaxAmount);
            this.Controls.Add(this.SubTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PayAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmCheckout";
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PayAmount_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PayAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label TaxAmount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button lblClear;
    }
}

