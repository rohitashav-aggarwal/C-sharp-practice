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
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblCommercial = new System.Windows.Forms.Label();
            this.lblIndustrial = new System.Windows.Forms.Label();
            this.lblInputCom = new System.Windows.Forms.Label();
            this.txtInputCom = new System.Windows.Forms.TextBox();
            this.btnCalculateCom = new System.Windows.Forms.Button();
            this.lblResultCom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Residential Bill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(12, 271);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(155, 41);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input:";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(190, 278);
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
            this.btnCaluculate.Location = new System.Drawing.Point(12, 394);
            this.btnCaluculate.Name = "btnCaluculate";
            this.btnCaluculate.Size = new System.Drawing.Size(154, 44);
            this.btnCaluculate.TabIndex = 3;
            this.btnCaluculate.Text = "Calculate:";
            this.btnCaluculate.UseVisualStyleBackColor = false;
            this.btnCaluculate.Click += new System.EventHandler(this.btnCaluculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(190, 398);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(154, 40);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(438, 552);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 54);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(647, 552);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 54);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnResidential
            // 
            this.btnResidential.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResidential.Location = new System.Drawing.Point(90, 65);
            this.btnResidential.Name = "btnResidential";
            this.btnResidential.Size = new System.Drawing.Size(167, 37);
            this.btnResidential.TabIndex = 7;
            this.btnResidential.TabStop = true;
            this.btnResidential.Text = "Residential";
            this.btnResidential.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResidential.UseVisualStyleBackColor = false;
            // 
            // btnCommercial
            // 
            this.btnCommercial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCommercial.Location = new System.Drawing.Point(492, 65);
            this.btnCommercial.Name = "btnCommercial";
            this.btnCommercial.Size = new System.Drawing.Size(204, 37);
            this.btnCommercial.TabIndex = 8;
            this.btnCommercial.TabStop = true;
            this.btnCommercial.Text = "Commercial";
            this.btnCommercial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCommercial.UseVisualStyleBackColor = false;
            // 
            // btnIndustrial
            // 
            this.btnIndustrial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIndustrial.Location = new System.Drawing.Point(889, 65);
            this.btnIndustrial.Name = "btnIndustrial";
            this.btnIndustrial.Size = new System.Drawing.Size(202, 37);
            this.btnIndustrial.TabIndex = 9;
            this.btnIndustrial.TabStop = true;
            this.btnIndustrial.Text = "Industrial";
            this.btnIndustrial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIndustrial.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 43);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer Bill";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCommercial
            // 
            this.lblCommercial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommercial.Location = new System.Drawing.Point(472, 169);
            this.lblCommercial.Name = "lblCommercial";
            this.lblCommercial.Size = new System.Drawing.Size(252, 57);
            this.lblCommercial.TabIndex = 11;
            this.lblCommercial.Text = "Commercial Bill";
            this.lblCommercial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndustrial
            // 
            this.lblIndustrial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIndustrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustrial.Location = new System.Drawing.Point(866, 169);
            this.lblIndustrial.Name = "lblIndustrial";
            this.lblIndustrial.Size = new System.Drawing.Size(252, 57);
            this.lblIndustrial.TabIndex = 12;
            this.lblIndustrial.Text = "Industrial Bill";
            this.lblIndustrial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputCom
            // 
            this.lblInputCom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInputCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputCom.Location = new System.Drawing.Point(433, 271);
            this.lblInputCom.Name = "lblInputCom";
            this.lblInputCom.Size = new System.Drawing.Size(155, 41);
            this.lblInputCom.TabIndex = 13;
            this.lblInputCom.Text = "Input:";
            this.lblInputCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInputCom
            // 
            this.txtInputCom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInputCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputCom.Location = new System.Drawing.Point(621, 274);
            this.txtInputCom.Name = "txtInputCom";
            this.txtInputCom.Size = new System.Drawing.Size(154, 34);
            this.txtInputCom.TabIndex = 14;
            this.txtInputCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculateCom
            // 
            this.btnCalculateCom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculateCom.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCalculateCom.FlatAppearance.BorderSize = 2;
            this.btnCalculateCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCom.Location = new System.Drawing.Point(434, 396);
            this.btnCalculateCom.Name = "btnCalculateCom";
            this.btnCalculateCom.Size = new System.Drawing.Size(154, 44);
            this.btnCalculateCom.TabIndex = 15;
            this.btnCalculateCom.Text = "Calculate:";
            this.btnCalculateCom.UseVisualStyleBackColor = false;
            this.btnCalculateCom.Click += new System.EventHandler(this.btnCalculateCom_Click);
            // 
            // lblResultCom
            // 
            this.lblResultCom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResultCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCom.Location = new System.Drawing.Point(621, 396);
            this.lblResultCom.Name = "lblResultCom";
            this.lblResultCom.Size = new System.Drawing.Size(154, 40);
            this.lblResultCom.TabIndex = 16;
            this.lblResultCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1186, 641);
            this.Controls.Add(this.lblResultCom);
            this.Controls.Add(this.btnCalculateCom);
            this.Controls.Add(this.txtInputCom);
            this.Controls.Add(this.lblInputCom);
            this.Controls.Add(this.lblIndustrial);
            this.Controls.Add(this.lblCommercial);
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
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label lblIndustrial;
        private System.Windows.Forms.Label lblInputCom;
        private System.Windows.Forms.TextBox txtInputCom;
        private System.Windows.Forms.Button btnCalculateCom;
        private System.Windows.Forms.Label lblResultCom;
        protected System.Windows.Forms.Label lblCommercial;
    }
}

