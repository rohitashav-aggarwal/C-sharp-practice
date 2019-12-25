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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResidential = new System.Windows.Forms.RadioButton();
            this.btnCommercial = new System.Windows.Forms.RadioButton();
            this.btnIndustrial = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOffPeakInput = new System.Windows.Forms.TextBox();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCustomer = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalCust = new System.Windows.Forms.Label();
            this.lblResCharges = new System.Windows.Forms.Label();
            this.lblComCharges = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.lblIndCharges = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(35, 237);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(182, 34);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input:";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(225, 237);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(337, 34);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(104, 448);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(229, 44);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Charge";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(257, 368);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(305, 37);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(130, 667);
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
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(398, 667);
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
            this.btnResidential.Location = new System.Drawing.Point(267, 171);
            this.btnResidential.Name = "btnResidential";
            this.btnResidential.Size = new System.Drawing.Size(53, 37);
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
            this.btnCommercial.Location = new System.Drawing.Point(351, 171);
            this.btnCommercial.Name = "btnCommercial";
            this.btnCommercial.Size = new System.Drawing.Size(48, 37);
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
            this.btnIndustrial.Location = new System.Drawing.Point(440, 171);
            this.btnIndustrial.Name = "btnIndustrial";
            this.btnIndustrial.Size = new System.Drawing.Size(42, 37);
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
            this.label2.Location = new System.Drawing.Point(505, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 43);
            this.label2.TabIndex = 10;
            this.label2.Text = "Electricity Bill";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Off Peak Input:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOffPeakInput
            // 
            this.txtOffPeakInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOffPeakInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffPeakInput.Location = new System.Drawing.Point(257, 300);
            this.txtOffPeakInput.Name = "txtOffPeakInput";
            this.txtOffPeakInput.Size = new System.Drawing.Size(305, 34);
            this.txtOffPeakInput.TabIndex = 20;
            this.txtOffPeakInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpbox
            // 
            this.grpbox.BackColor = System.Drawing.SystemColors.GrayText;
            this.grpbox.Controls.Add(this.btnAdd);
            this.grpbox.Controls.Add(this.txtAccNo);
            this.grpbox.Controls.Add(this.txtName);
            this.grpbox.Controls.Add(this.label7);
            this.grpbox.Controls.Add(this.label6);
            this.grpbox.Controls.Add(this.label5);
            this.grpbox.Controls.Add(this.label4);
            this.grpbox.Controls.Add(this.btnIndustrial);
            this.grpbox.Controls.Add(this.btnCommercial);
            this.grpbox.Controls.Add(this.btnResidential);
            this.grpbox.Controls.Add(this.lblInput);
            this.grpbox.Controls.Add(this.label3);
            this.grpbox.Controls.Add(this.txtOffPeakInput);
            this.grpbox.Controls.Add(this.txtInput);
            this.grpbox.Controls.Add(this.lblResult);
            this.grpbox.Controls.Add(this.btnCalculate);
            this.grpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox.Location = new System.Drawing.Point(37, 89);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(594, 513);
            this.grpbox.TabIndex = 22;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Customer";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(380, 448);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 44);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(177, 112);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(385, 38);
            this.txtAccNo.TabIndex = 5;
            this.txtAccNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(432, 38);
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(35, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "Charge Amount:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(35, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Customer Type:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(35, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account #:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(35, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstCustomer
            // 
            this.lstCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomer.FullRowSelect = true;
            this.lstCustomer.GridLines = true;
            this.lstCustomer.HideSelection = false;
            this.lstCustomer.Location = new System.Drawing.Point(656, 135);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(586, 301);
            this.lstCustomer.TabIndex = 23;
            this.lstCustomer.UseCompatibleStateImageBehavior = false;
            this.lstCustomer.View = System.Windows.Forms.View.List;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(659, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 33);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total Customers";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(659, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 34);
            this.label9.TabIndex = 25;
            this.label9.Text = "Residential Charges";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(659, 569);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 33);
            this.label10.TabIndex = 26;
            this.label10.Text = "Commerical Charges";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(660, 625);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 33);
            this.label11.TabIndex = 27;
            this.label11.Text = "Industrial Charges";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(660, 678);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(302, 33);
            this.label12.TabIndex = 28;
            this.label12.Text = "Total Charges";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCust
            // 
            this.lblTotalCust.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalCust.Location = new System.Drawing.Point(978, 455);
            this.lblTotalCust.Name = "lblTotalCust";
            this.lblTotalCust.Size = new System.Drawing.Size(264, 33);
            this.lblTotalCust.TabIndex = 29;
            // 
            // lblResCharges
            // 
            this.lblResCharges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResCharges.Location = new System.Drawing.Point(978, 512);
            this.lblResCharges.Name = "lblResCharges";
            this.lblResCharges.Size = new System.Drawing.Size(264, 33);
            this.lblResCharges.TabIndex = 30;
            // 
            // lblComCharges
            // 
            this.lblComCharges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComCharges.Location = new System.Drawing.Point(978, 569);
            this.lblComCharges.Name = "lblComCharges";
            this.lblComCharges.Size = new System.Drawing.Size(264, 33);
            this.lblComCharges.TabIndex = 31;
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalCharges.Location = new System.Drawing.Point(978, 678);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(264, 33);
            this.lblTotalCharges.TabIndex = 32;
            // 
            // lblIndCharges
            // 
            this.lblIndCharges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIndCharges.Location = new System.Drawing.Point(978, 625);
            this.lblIndCharges.Name = "lblIndCharges";
            this.lblIndCharges.Size = new System.Drawing.Size(264, 33);
            this.lblIndCharges.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(657, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(241, 43);
            this.label13.TabIndex = 34;
            this.label13.Text = "Customer List";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1273, 736);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblIndCharges);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.lblComCharges);
            this.Controls.Add(this.lblResCharges);
            this.Controls.Add(this.lblTotalCust);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton btnResidential;
        private System.Windows.Forms.RadioButton btnCommercial;
        private System.Windows.Forms.RadioButton btnIndustrial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOffPeakInput;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalCust;
        private System.Windows.Forms.Label lblResCharges;
        private System.Windows.Forms.Label lblComCharges;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label lblIndCharges;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAdd;
    }
}

