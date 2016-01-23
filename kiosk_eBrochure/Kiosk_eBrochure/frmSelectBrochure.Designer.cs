namespace Kiosk_eBrochure
{
    partial class frmSelectBrochure
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
            this.label11 = new System.Windows.Forms.Label();
            this.pictureEmail = new System.Windows.Forms.PictureBox();
            this.PictureClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(197, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(392, 31);
            this.label11.TabIndex = 19;
            this.label11.Text = "กรุณาเลือก Solutions ที่ท่านสนใจ";
            // 
            // pictureEmail
            // 
            this.pictureEmail.Image = global::Kiosk_eBrochure.Properties.Resources.iconEmail;
            this.pictureEmail.Location = new System.Drawing.Point(300, 607);
            this.pictureEmail.Name = "pictureEmail";
            this.pictureEmail.Size = new System.Drawing.Size(113, 109);
            this.pictureEmail.TabIndex = 30;
            this.pictureEmail.TabStop = false;
            this.pictureEmail.Click += new System.EventHandler(this.pictureEmail_Click);
            // 
            // PictureClose
            // 
            this.PictureClose.Image = global::Kiosk_eBrochure.Properties.Resources.close;
            this.PictureClose.Location = new System.Drawing.Point(12, 12);
            this.PictureClose.Name = "PictureClose";
            this.PictureClose.Size = new System.Drawing.Size(37, 36);
            this.PictureClose.TabIndex = 29;
            this.PictureClose.TabStop = false;
            this.PictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(45, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 408);
            this.panel1.TabIndex = 31;
            // 
            // frmSelectBrochure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(735, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureEmail);
            this.Controls.Add(this.PictureClose);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelectBrochure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelectBrochure";
            this.Load += new System.EventHandler(this.frmSelectBrochure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox PictureClose;
        private System.Windows.Forms.PictureBox pictureEmail;
        private System.Windows.Forms.Panel panel1;

    }
}