
namespace Users_Profile
{
    partial class FP_Amigos
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
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pBorde = new System.Windows.Forms.Panel();
            this.pBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de amigos";
            // 
            // pContenedor
            // 
            this.pContenedor.AutoScroll = true;
            this.pContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(100)))), ((int)(((byte)(125)))));
            this.pContenedor.Location = new System.Drawing.Point(1, 1);
            this.pContenedor.Margin = new System.Windows.Forms.Padding(15, 3, 3, 15);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(550, 350);
            this.pContenedor.TabIndex = 3;
            // 
            // pBorde
            // 
            this.pBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pBorde.Controls.Add(this.pContenedor);
            this.pBorde.Location = new System.Drawing.Point(23, 96);
            this.pBorde.Margin = new System.Windows.Forms.Padding(14, 3, 3, 14);
            this.pBorde.Name = "pBorde";
            this.pBorde.Size = new System.Drawing.Size(552, 352);
            this.pBorde.TabIndex = 4;
            // 
            // FP_Amigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(714, 471);
            this.Controls.Add(this.pBorde);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FP_Amigos";
            this.Text = "FP_Amigos";
            this.Load += new System.EventHandler(this.FP_Amigos_Load);
            this.pBorde.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Panel pBorde;
    }
}