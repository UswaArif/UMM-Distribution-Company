
namespace Email
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
            this.Totxt = new System.Windows.Forms.TextBox();
            this.Subjecttxt = new System.Windows.Forms.TextBox();
            this.Bodytxt = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Totxt
            // 
            this.Totxt.Location = new System.Drawing.Point(144, 45);
            this.Totxt.Multiline = true;
            this.Totxt.Name = "Totxt";
            this.Totxt.Size = new System.Drawing.Size(621, 57);
            this.Totxt.TabIndex = 0;
            // 
            // Subjecttxt
            // 
            this.Subjecttxt.Location = new System.Drawing.Point(144, 150);
            this.Subjecttxt.Multiline = true;
            this.Subjecttxt.Name = "Subjecttxt";
            this.Subjecttxt.Size = new System.Drawing.Size(621, 57);
            this.Subjecttxt.TabIndex = 1;
            // 
            // Bodytxt
            // 
            this.Bodytxt.Location = new System.Drawing.Point(144, 268);
            this.Bodytxt.Multiline = true;
            this.Bodytxt.Name = "Bodytxt";
            this.Bodytxt.Size = new System.Drawing.Size(768, 225);
            this.Bodytxt.TabIndex = 2;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(713, 527);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(199, 62);
            this.sendbtn.TabIndex = 3;
            this.sendbtn.Text = "button1";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 619);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.Bodytxt);
            this.Controls.Add(this.Subjecttxt);
            this.Controls.Add(this.Totxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Totxt;
        private System.Windows.Forms.TextBox Subjecttxt;
        private System.Windows.Forms.TextBox Bodytxt;
        private System.Windows.Forms.Button sendbtn;
    }
}

