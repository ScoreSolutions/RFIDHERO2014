namespace Kiosk_eBrochure
{
    partial class frmEmailSend
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
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblLine3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureOK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLine1
            // 
            this.lblLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine1.AutoSize = true;
            this.lblLine1.BackColor = System.Drawing.Color.Transparent;
            this.lblLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblLine1.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblLine1.Location = new System.Drawing.Point(135, 487);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(556, 39);
            this.lblLine1.TabIndex = 25;
            this.lblLine1.Text = "ระบบได้ส่ง eBrochure ไปยังที่อยู่อีเมล์ ";
            this.lblLine1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine2
            // 
            this.lblLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine2.BackColor = System.Drawing.Color.Transparent;
            this.lblLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblLine2.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblLine2.Location = new System.Drawing.Point(88, 588);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(631, 39);
            this.lblLine2.TabIndex = 26;
            this.lblLine2.Text = "xxxxxxxxxxxx@yyy.com";
            this.lblLine2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine3
            // 
            this.lblLine3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine3.AutoSize = true;
            this.lblLine3.BackColor = System.Drawing.Color.Transparent;
            this.lblLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblLine3.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblLine3.Location = new System.Drawing.Point(231, 688);
            this.lblLine3.Name = "lblLine3";
            this.lblLine3.Size = new System.Drawing.Size(345, 39);
            this.lblLine3.TabIndex = 27;
            this.lblLine3.Text = "เรียบร้อยแล้ว ขอบคุณค่ะ";
            this.lblLine3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox1.BackgroundImage = global::Kiosk_eBrochure.Properties.Resources.BG_04;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 900);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kiosk_eBrochure.Properties.Resources.Exit_Btn;
            this.pictureBox2.Location = new System.Drawing.Point(735, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 37);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureOK
            // 
            this.pictureOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureOK.BackColor = System.Drawing.Color.Transparent;
            this.pictureOK.BackgroundImage = global::Kiosk_eBrochure.Properties.Resources.OK_Btn1;
            this.pictureOK.Location = new System.Drawing.Point(217, 538);
            this.pictureOK.Name = "pictureOK";
            this.pictureOK.Size = new System.Drawing.Size(389, 131);
            this.pictureOK.TabIndex = 36;
            this.pictureOK.TabStop = false;
            this.pictureOK.Click += new System.EventHandler(this.pictureOK_Click);
            // 
            // frmEmailSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Kiosk_eBrochure.Properties.Resources.BG_04;
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.pictureOK);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblLine3);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmailSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmailSend";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmailSend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblLine3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureOK;
    }
}