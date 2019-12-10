namespace Conversions
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.txtCm = new System.Windows.Forms.TextBox();
            this.btnToMetric = new System.Windows.Forms.Button();
            this.btnToImperial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feet: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inches:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Centimeters";
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(137, 65);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(125, 22);
            this.txtFeet.TabIndex = 3;
            // 
            // txtInch
            // 
            this.txtInch.Location = new System.Drawing.Point(135, 202);
            this.txtInch.Name = "txtInch";
            this.txtInch.Size = new System.Drawing.Size(125, 22);
            this.txtInch.TabIndex = 4;
            // 
            // txtCm
            // 
            this.txtCm.Location = new System.Drawing.Point(640, 128);
            this.txtCm.Name = "txtCm";
            this.txtCm.Size = new System.Drawing.Size(131, 22);
            this.txtCm.TabIndex = 5;
            // 
            // btnToMetric
            // 
            this.btnToMetric.Location = new System.Drawing.Point(322, 65);
            this.btnToMetric.Name = "btnToMetric";
            this.btnToMetric.Size = new System.Drawing.Size(84, 46);
            this.btnToMetric.TabIndex = 6;
            this.btnToMetric.Text = ">>";
            this.btnToMetric.UseVisualStyleBackColor = true;
            this.btnToMetric.Click += new System.EventHandler(this.btnToMetric_Click);
            // 
            // btnToImperial
            // 
            this.btnToImperial.Location = new System.Drawing.Point(322, 165);
            this.btnToImperial.Name = "btnToImperial";
            this.btnToImperial.Size = new System.Drawing.Size(84, 41);
            this.btnToImperial.TabIndex = 7;
            this.btnToImperial.Text = "<<";
            this.btnToImperial.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToImperial);
            this.Controls.Add(this.btnToMetric);
            this.Controls.Add(this.txtCm);
            this.Controls.Add(this.txtInch);
            this.Controls.Add(this.txtFeet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtInch;
        private System.Windows.Forms.TextBox txtCm;
        private System.Windows.Forms.Button btnToMetric;
        private System.Windows.Forms.Button btnToImperial;
    }
}

