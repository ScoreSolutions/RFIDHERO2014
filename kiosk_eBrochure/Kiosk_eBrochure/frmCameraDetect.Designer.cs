namespace Kiosk_eBrochure
{
    partial class frmCameraDetect
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureClose = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureSearch = new System.Windows.Forms.PictureBox();
            this.pictureClose2 = new System.Windows.Forms.PictureBox();
            this.pictureCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // PictureClose
            // 
            this.PictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureClose.Image = global::Kiosk_eBrochure.Properties.Resources.Exit_Btn;
            this.PictureClose.Location = new System.Drawing.Point(746, 20);
            this.PictureClose.Name = "PictureClose";
            this.PictureClose.Size = new System.Drawing.Size(53, 37);
            this.PictureClose.TabIndex = 32;
            this.PictureClose.TabStop = false;
            this.PictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPercent.ForeColor = System.Drawing.Color.Black;
            this.lblPercent.Location = new System.Drawing.Point(372, 703);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(412, 54);
            this.lblPercent.TabIndex = 36;
            this.lblPercent.Text = "เริ่มค้นหา";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPercent.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(265, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 28);
            this.progressBar1.TabIndex = 35;
            this.progressBar1.Visible = false;
            // 
            // pictureSearch
            // 
            this.pictureSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureSearch.BackColor = System.Drawing.Color.Transparent;
            this.pictureSearch.BackgroundImage = global::Kiosk_eBrochure.Properties.Resources.search;
            this.pictureSearch.Location = new System.Drawing.Point(222, 54);
            this.pictureSearch.Name = "pictureSearch";
            this.pictureSearch.Size = new System.Drawing.Size(389, 128);
            this.pictureSearch.TabIndex = 37;
            this.pictureSearch.TabStop = false;
            this.pictureSearch.Click += new System.EventHandler(this.pictureSearch_Click);
            // 
            // pictureClose2
            // 
            this.pictureClose2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose2.BackColor = System.Drawing.Color.Transparent;
            this.pictureClose2.BackgroundImage = global::Kiosk_eBrochure.Properties.Resources.Exit_Btn;
            this.pictureClose2.Location = new System.Drawing.Point(746, 20);
            this.pictureClose2.Name = "pictureClose2";
            this.pictureClose2.Size = new System.Drawing.Size(38, 40);
            this.pictureClose2.TabIndex = 38;
            this.pictureClose2.TabStop = false;
            this.pictureClose2.Visible = false;
            this.pictureClose2.Click += new System.EventHandler(this.pictureClose2_Click);
            // 
            // pictureCancel
            // 
            this.pictureCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureCancel.BackColor = System.Drawing.Color.Transparent;
            this.pictureCancel.BackgroundImage = global::Kiosk_eBrochure.Properties.Resources.Exit_Btn;
            this.pictureCancel.Location = new System.Drawing.Point(746, 20);
            this.pictureCancel.Name = "pictureCancel";
            this.pictureCancel.Size = new System.Drawing.Size(38, 40);
            this.pictureCancel.TabIndex = 39;
            this.pictureCancel.TabStop = false;
            this.pictureCancel.Visible = false;
            this.pictureCancel.Click += new System.EventHandler(this.pictureCancel_Click);
            // 
            // frmCameraDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::Kiosk_eBrochure.Properties.Resources.BG_011;
            this.ClientSize = new System.Drawing.Size(801, 788);
            this.Controls.Add(this.pictureCancel);
            this.Controls.Add(this.pictureClose2);
            this.Controls.Add(this.pictureSearch);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PictureClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCameraDetect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCameraDetect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCameraDetect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PictureClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureSearch;
        private System.Windows.Forms.PictureBox pictureClose2;
        private System.Windows.Forms.PictureBox pictureCancel;
    }
}