
namespace RegularExpressions
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
            this.BtnGec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGec
            // 
            this.BtnGec.Location = new System.Drawing.Point(545, 176);
            this.BtnGec.Name = "BtnGec";
            this.BtnGec.Size = new System.Drawing.Size(154, 70);
            this.BtnGec.TabIndex = 0;
            this.BtnGec.Text = ">>>";
            this.BtnGec.UseVisualStyleBackColor = true;
            this.BtnGec.Click += new System.EventHandler(this.BtnGec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGec;
    }
}

