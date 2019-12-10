namespace Chicken_or_Egg
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radChicken = new System.Windows.Forms.RadioButton();
            this.radEgg = new System.Windows.Forms.RadioButton();
            this.picAnswer = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "What was First?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEgg);
            this.groupBox1.Controls.Add(this.radChicken);
            this.groupBox1.Location = new System.Drawing.Point(90, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick your Answer";
            // 
            // radChicken
            // 
            this.radChicken.AutoSize = true;
            this.radChicken.Location = new System.Drawing.Point(43, 58);
            this.radChicken.Name = "radChicken";
            this.radChicken.Size = new System.Drawing.Size(128, 33);
            this.radChicken.TabIndex = 0;
            this.radChicken.TabStop = true;
            this.radChicken.Text = "Chicken";
            this.radChicken.UseVisualStyleBackColor = true;
            this.radChicken.CheckedChanged += new System.EventHandler(this.radChicken_CheckedChanged);
            // 
            // radEgg
            // 
            this.radEgg.AutoSize = true;
            this.radEgg.Location = new System.Drawing.Point(66, 116);
            this.radEgg.Name = "radEgg";
            this.radEgg.Size = new System.Drawing.Size(81, 33);
            this.radEgg.TabIndex = 1;
            this.radEgg.TabStop = true;
            this.radEgg.Text = "Egg";
            this.radEgg.UseVisualStyleBackColor = true;
            this.radEgg.CheckedChanged += new System.EventHandler(this.radEgg_CheckedChanged);
            // 
            // picAnswer
            // 
            this.picAnswer.Location = new System.Drawing.Point(402, 139);
            this.picAnswer.Name = "picAnswer";
            this.picAnswer.Size = new System.Drawing.Size(614, 304);
            this.picAnswer.TabIndex = 2;
            this.picAnswer.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1149, 510);
            this.Controls.Add(this.picAnswer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEgg;
        private System.Windows.Forms.RadioButton radChicken;
        private System.Windows.Forms.PictureBox picAnswer;
    }
}

