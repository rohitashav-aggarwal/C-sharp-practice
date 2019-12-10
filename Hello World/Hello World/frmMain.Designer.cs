using System;

namespace Hello_World
{
    partial class frmMain
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGreetMe = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGreeting.Location = new System.Drawing.Point(505, 87);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(124, 25);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello World";
            this.lblGreeting.Click += new System.EventHandler(this.lblGreeting_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(160, 171);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(207, 25);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "What is your Name?";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(391, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 30);
            this.txtName.TabIndex = 2;
            // 
            // btnGreetMe
            // 
            this.btnGreetMe.Location = new System.Drawing.Point(822, 156);
            this.btnGreetMe.Name = "btnGreetMe";
            this.btnGreetMe.Size = new System.Drawing.Size(232, 40);
            this.btnGreetMe.TabIndex = 3;
            this.btnGreetMe.Text = "&Greet Me";
            this.btnGreetMe.UseVisualStyleBackColor = true;
            this.btnGreetMe.Click += new System.EventHandler(this.lblGreeting_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(822, 238);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 444);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGreetMe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblGreeting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "My First C# App";
            this.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGreetMe;
        private System.Windows.Forms.Button btnClear;
    }
}

