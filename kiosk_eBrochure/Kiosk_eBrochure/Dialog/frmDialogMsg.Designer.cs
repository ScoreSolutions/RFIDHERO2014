namespace Kiosk_eBrochure.Dialog
{
    partial class frmDialogMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDialogMsg));
            this.PanelMsg = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.PanelMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMsg
            // 
            this.PanelMsg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMsg.BackgroundImage")));
            this.PanelMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMsg.Controls.Add(this.btnOK);
            this.PanelMsg.Controls.Add(this.lblText);
            this.PanelMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMsg.Location = new System.Drawing.Point(0, 0);
            this.PanelMsg.Name = "PanelMsg";
            this.PanelMsg.Size = new System.Drawing.Size(383, 266);
            this.PanelMsg.TabIndex = 55;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(163, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 58);
            this.btnOK.TabIndex = 27;
            this.btnOK.Text = "ตกลง";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblText.Location = new System.Drawing.Point(46, 40);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(293, 132);
            this.lblText.TabIndex = 16;
            this.lblText.Text = "lblText\r\nffffffffffffffffff\r\nffffffffffffffffffff";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDialogMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 266);
            this.Controls.Add(this.PanelMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDialogMsg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDialogMsg";
            this.PanelMsg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Panel PanelMsg;
        internal System.Windows.Forms.Label lblText;
    }
}