using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CSharp_Sample
{
    public partial class Form1 : Form
    {
        [DllImport("gdi32.dll")]
        static extern bool DeleteObject(IntPtr hObject);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #if ! __DEBUG
            Error: please request the evaluation license key from Luxand, Inc., comment these lines and assign the key to LicenseKey.
            Please visit http://www.luxand.com/facecrop/ to request the key
            #endif
            string LicenseKey = "";
            
            if (0 != Luxand.fc.Activate(LicenseKey))
            {
                MessageBox.Show("Error activating FaceCrop library");
                Application.Exit();
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Windows bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|All files|*.*";
            dlg.Multiselect = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = dlg.FileNames[0];
                    IntPtr face_bitmap = (IntPtr)0;

                    int height = pictureBox1.Height;
                    int width = pictureBox1.Width;
                    
                    int result = Luxand.fc.FaceCrop_FileToHBITMAP(filename, ref face_bitmap, width, height);

                    Image img;
                    if (Luxand.fc.fcErrorOk == result)
                    {
                        img = Image.FromHbitmap(face_bitmap);
                        pictureBox1.Image = img;
                        DeleteObject(face_bitmap);
                        GC.Collect();
                    }
                    else if (Luxand.fc.fcErrorFaceNotFound == result)
                        MessageBox.Show("Error: face not found");
                    else
                        MessageBox.Show("Error: can't open image");
             
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't open image(s) with error: " + ex.Message.ToString(), "Error");
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
