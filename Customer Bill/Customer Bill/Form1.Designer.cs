namespace Customer_Bill
{
    partial class Form1
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCaluculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResidential = new System.Windows.Forms.RadioButton();
            this.btnCommercial = new System.Windows.Forms.RadioButton();
            this.btnIndustrial = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOffPeakInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(232, 95);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(182, 35);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input:";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(434, 95);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(154, 34);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCaluculate
            // 
            this.btnCaluculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCaluculate.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCaluculate.FlatAppearance.BorderSize = 2;
            this.btnCaluculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaluculate.Location = new System.Drawing.Point(232, 338);
            this.btnCaluculate.Name = "btnCaluculate";
            this.btnCaluculate.Size = new System.Drawing.Size(182, 44);
            this.btnCaluculate.TabIndex = 3;
            this.btnCaluculate.Text = "Calculate:";
            this.btnCaluculate.UseVisualStyleBackColor = false;
            this.btnCaluculate.Click += new System.EventHandler(this.btnCaluculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(434, 256);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(154, 37);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(42, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 44);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(434, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnResidential
            // 
            this.btnResidential.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResidential.Location = new System.Drawing.Point(42, 95);
            this.btnResidential.Name = "btnResidential";
            this.btnResidential.Size = new System.Drawing.Size(167, 37);
            this.btnResidential.TabIndex = 7;
            this.btnResidential.TabStop = true;
            this.btnResidential.Text = "Residential";
            this.btnResidential.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResidential.UseVisualStyleBackColor = false;
            this.btnResidential.CheckedChanged += new System.EventHandler(this.btnResidential_CheckedChanged);
            // 
            // btnCommercial
            // 
            this.btnCommercial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCommercial.Location = new System.Drawing.Point(42, 178);
            this.btnCommercial.Name = "btnCommercial";
            this.btnCommercial.Size = new System.Drawing.Size(167, 37);
            this.btnCommercial.TabIndex = 8;
            this.btnCommercial.TabStop = true;
            this.btnCommercial.Text = "Commercial";
            this.btnCommercial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCommercial.UseVisualStyleBackColor = false;
            this.btnCommercial.CheckedChanged += new System.EventHandler(this.btnCommercial_CheckedChanged);
            // 
            // btnIndustrial
            // 
            this.btnIndustrial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIndustrial.Location = new System.Drawing.Point(42, 256);
            this.btnIndustrial.Name = "btnIndustrial";
            this.btnIndustrial.Size = new System.Drawing.Size(167, 37);
            this.btnIndustrial.TabIndex = 9;
            this.btnIndustrial.TabStop = true;
            this.btnIndustrial.Text = "Industrial";
            this.btnIndustrial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIndustrial.UseVisualStyleBackColor = false;
            this.btnIndustrial.CheckedChanged += new System.EventHandler(this.btnIndustrial_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 43);
            this.label2.TabIndex = 10;
            this.label2.Text = "Electricity Bill";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Off Peak Input:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOffPeakInput
            // 
            this.txtOffPeakInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtOffPeakInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffPeakInput.Location = new System.Drawing.Point(434, 179);
            this.txtOffPeakInput.Name = "txtOffPeakInput";
            this.txtOffPeakInput.Size = new System.Drawing.Size(154, 34);
            this.txtOffPeakInput.TabIndex = 20;
            this.txtOffPeakInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Result:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(628, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOffPeakInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIndustrial);
            this.Controls.Add(this.btnCommercial);
            this.Controls.Add(this.btnResidential);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCaluculate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCaluculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton btnResidential;
        private System.Windows.Forms.RadioButton btnCommercial;
        private System.Windows.Forms.RadioButton btnIndustrial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOffPeakInput;
        private System.Windows.Forms.Label label1;
    }
}

