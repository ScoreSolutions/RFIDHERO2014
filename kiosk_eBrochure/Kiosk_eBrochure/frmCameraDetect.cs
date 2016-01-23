using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Luxand;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using AxSHDocVw;
using AxDIRECTORSHOCKWAVELib;

namespace Kiosk_eBrochure
{
    public struct TFaceRecord
    {
        public byte[] Template; //Face Template;
        public FSDK.TFacePosition FacePosition;
        public FSDK.TPoint[] FacialFeatures; //Facial Features;

        public string ImageFileName;

        public FSDK.CImage image;
        public FSDK.CImage faceImage;
    }


    public partial class frmCameraDetect : Form
    {
        bool status;
        BackgroundWorker bgw = new BackgroundWorker();
        public static float FARValue = 100;
        // program states: whether we recognize faces, or user has clicked a face
        enum ProgramState { psRemember, psRecognize }
        ProgramState programState = ProgramState.psRecognize;
        int cnt = 0;
        String cameraName;
        bool needClose = false;
        string userName;
        string IsDetect;
        String TrackerMemoryFile = "tracker.dat";
        int mouseX = 0;
        DoWorkEventArgs evt;
        int mouseY = 0;
        static ImageList imageList1;
        public static List<TFaceRecord> FaceList;
        public static List<TFaceRecord> FaceListCompare;
        TFaceRecord frCompare = new TFaceRecord();
        // WinAPI procedure to release HBITMAP handles returned by FSDKCam.GrabFrame
        [DllImport("gdi32.dll")]
        static extern bool DeleteObject(IntPtr hObject);
        int timmercout = 1;
        public frmCameraDetect()
        {
            InitializeComponent();
        }

        private void frmCameraDetect_Load(object sender, EventArgs e)
        {
            try {
                    PopulateData();
            }
            catch (Exception exload) {
 
            }
           
        }

        public void Progresss() {
            try {
            pictureCancel.Visible = true;
            PictureClose.Visible = false;
            lblPercent.Visible = true;
            pictureBox1.Visible = false;
            this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-01.jpg");
            //lblPercent.Top = this.Height / 2;
            //lblPercent.Left = this.Width/2 -100;
            this.Width = 800;
            this.Height = 1280;
            //label1.Left = (this.Width / 2) - (this.Width / 2);

            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.RunWorkerAsync();
             
            }
            catch (Exception exProgress)
               {

               }
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            //int total = 100; //some number (this is your variable to change)!!

            //for (int i = 0; i <= total; i++) //some number (total)
            //{
            //    //100 ms= 1 s
            //    //System.Threading.Thread.Sleep(100);
            //    //int percents = (i * 100) / total;
            //    //bgw.ReportProgress(percents, i);
            //    //2 arguments:
            //    //1. procenteges (from 0 t0 100) - i do a calcumation 
            //    //2. some current value!
            //}

            //frmCameraDetect f = new frmCameraDetect();
            //f.PopulateAllImage();
            //f.ImageDetect();
           // evt = e;
           // if (status == true)
           // {

           //     return; // abort work, if it's cancelled
           // }
           // else {
           //     if (cnt == 0) { 
           //  try {
           //PopulateAllImage();
           //cnt = 1;
           //  }
           //  catch (Exception exDoWork)
           //  {

           //  }
           //     }
           // }

            try
            {
                PopulateAllImage();
            }
            catch (Exception exDoWork)
            {
            }


          
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {


            if (status == true)
            {
                return;
            }


            try
            {
                //timmercout = e.ProgressPercentage;
                
                if (e.ProgressPercentage <= 10)
                {
                    this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-01.jpg");
                }
                else if (e.ProgressPercentage <= 20)
                {
                    this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-02.jpg");
                }
                else if (e.ProgressPercentage <= 30)
                {
                    this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-04.jpg");
                }
                else if (e.ProgressPercentage <= 40)
                {
                    this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-03.jpg");
                }
                else if (e.ProgressPercentage <= 50)
                {
                    this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-01.jpg");
                }
                else if (e.ProgressPercentage <= 60)
                {
                    this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-02.jpg");
                }
                else if (e.ProgressPercentage <= 70)
                {
                    this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-04.jpg");
                }
                else if (e.ProgressPercentage <= 80)
                {
                    this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-03.jpg");
                }
                else if (e.ProgressPercentage <= 90)
                {
                    this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-01.jpg");
                }
                else if (e.ProgressPercentage <= 100)
                {
                    this.BackgroundImage = Image.FromFile(LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_File\\waiting-02.jpg");
                }
          
                //if (timmercout <= 10)
                //{
                //    this.BackgroundImage = Image.FromFile("D:\\Kiosk_File\\waiting-01.jpg");
                //}
                //else if (timmercout <= 20)
                //{
                //    this.BackgroundImage = Image.FromFile("D:\\Kiosk_File\\waiting-02.jpg");
                //}
                //else if (timmercout <= 30)
                //{
                //    this.BackgroundImage = Image.FromFile("D:\\Kiosk_File\\waiting-04.jpg");
                //}
                //else if (timmercout <= 40)
                //{
                //    this.BackgroundImage = Image.FromFile("D:\\Kiosk_File\\waiting-03.jpg");
                //}

                //if (timmercout == 40)
                //{
                //    timmercout = 0;
                //}
                //timmercout += 1;


                progressBar1.Value = e.ProgressPercentage;
                //if (e.ProgressPercentage >= 99)
                //{
                // //   lblPercent.Text = "ไม่พบข้อมูล";
                // //   PictureClose.Visible = true;
                // //   lblPercent.Visible = false;
                // //   pictureBox1.Visible = true;
                // //   string strpath = Application.StartupPath;
                // //   strpath = strpath + "\\images\\BG-01.jpg";
                // //   this.BackgroundImage = Image.FromFile(strpath);
                // //System.Threading.Thread.Sleep(10000);
                //}
                //else {
                lblPercent.Text = String.Format("ค้นหา: {0} %", e.ProgressPercentage);
                //}


                //  label2.Text = String.Format("Total items transfered: {0}", e.UserState);
            }
            catch (Exception exProgressChanged)
            {

            }

        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (status == true)
            {
                return;
            }

               try
            {

            //System.Threading.Thread.Sleep(10000);
            if (frCompare.ImageFileName != null)
            {
                //do the code when bgv completes its work
                // this.Close();
                this.Visible = false;
                this.Close();
                frmCameraResult Detect = new frmCameraResult();
                Detect.StartPosition = FormStartPosition.CenterScreen;
                Detect.ShowImage(frCompare);
                Detect.ShowDialog();
                // MessageBox.Show(Similarities * 100 + "");
            }
            else {
                lblPercent.Text = "ไม่พบข้อมูล";
                
                pictureClose2.Visible = true;
                this.Visible = false;
                this.Close();
                frmSearchMobile f = new frmSearchMobile();
                f.ShowDialog();

                //needClose = false;
                //PopulateData();
            }
           
           //lblPercent.Text = "ไม่พบข้อมูล";
            }
               catch (Exception exRunWorkerCompleted)
               {

               }

          
        }
        public void PopulateData()
        {
            //if (FSDK.FSDKE_OK != FSDK.ActivateLibrary("eLDwg+IxLV+w/pfOUzvf7OhNDgnO4M0ZSQZzy7Os2hUn0z3b1driMrhlq+r/eFjkQkjIL4Men2VLH29plmHC/ojpfhyrk6v0tzfc96TD72U4yqYeq4l0VR7phnG1EeFTIPzuXPRKAwtefblB7DmM6uYUrcgGZ5r8R04EdMsJl/k="))
            //{
            //    MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
            //}

            //FSDK.InitializeLibrary();
            //FSDKCam.InitializeCapturing();

        
            //int count;
            //cameraName = LiveFaceScan.CameraSetting.CameraName;
            //FSDKCam.VideoFormatInfo[] formatList;
            //FSDKCam.GetVideoFormatList(ref cameraName, out formatList, out count);

           
            //formatList[0].Height = 600;
            //formatList[0].Width = 800;
           // FSDKCam.SetVideoFormat(ref cameraName, formatList[0]);


            //int VideoFormat = LiveFaceScan.CameraSetting.VideoFormat;//0; // choose a video format
            //pictureBox1.Height = formatList[VideoFormat].Height;
            //pictureBox1.Width = formatList[VideoFormat].Width;
            //this.Height = formatList[VideoFormat].Height + 48;
            //this.Width = formatList[VideoFormat].Width + 96;

          //  777, 592
            //int screenWidth;
            //int screenHeight;

            //// grabs the resolution of the monitor
            //Screen screen = Screen.PrimaryScreen;
            //screenWidth = 777;//screen.Bounds.Width;
            //screenHeight = 570;//screen.Bounds.Height;
            //// MessageBox.Show("height = " + screenHeight + "\n" + "Width = " + screenWidth);
            //// grabs the resolution of the monitor


            //// sets the size of the window of Pictureviewer
            //this.ClientSize = new Size(screenWidth, screenHeight);
            //// sets the size of the window of Pictureviewer

            //pictureBox1.Size = new Size(screenWidth, screenHeight);

            //pictureBox1.Location = new Point((ClientSize.Width / 2) - (pictureBox1.Width / 2), (ClientSize.Height / 2) - (pictureBox1.Height / 2));

                 try
            {


            if (FSDK.FSDKE_OK != FSDK.ActivateLibrary("J98H0OOSi4gGwMxLZ0daeM5sCGAFl4wyClviJFdPlYpa48vaFm46LvwLq9T9L0W3vMjimMsBOFFSuTmn8S7nsWoLdS0GLiwGXHuXDJxlgYMo4ufYFVraAPrJfiDeKWaLLoxlR4ZbMIMnujLnM+t/NjixxITVxO522C0Sh8BcbAU="))
            {
                MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            FSDK.InitializeLibrary();
            FSDKCam.InitializeCapturing();

            string[] cameraList;
            int count;
            FSDKCam.GetCameraList(out cameraList, out count);

            if (0 == count)
            {
                MessageBox.Show("Please attach a camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            cameraName = LiveFaceScan.CameraSetting.CameraName;

            FSDKCam.VideoFormatInfo[] formatList;
            FSDKCam.GetVideoFormatList(ref cameraName, out formatList, out count);

            int VideoFormat = LiveFaceScan.CameraSetting.VideoFormat; // choose a video format
            //pictureBox1.Width = formatList[VideoFormat].Width;
            //pictureBox1.Height = formatList[VideoFormat].Height;
            //this.Width = formatList[VideoFormat].Width + 48;
            //this.Height = formatList[VideoFormat].Height + 96;
            pictureBox1.Location = new Point(0, 188);
           pictureBox1.Width = 800;
           pictureBox1.Height = 800;
            this.Width = 800;
            this.Height = 1224;

           pictureSearch.Location = new Point(222,800+260);
        


            int cameraHandle = 0;

            int r = FSDKCam.OpenVideoCamera(ref cameraName, ref cameraHandle);
            if (r != FSDK.FSDKE_OK)
            {
                MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            int tracker = 0; 	// creating a Tracker
            if (FSDK.FSDKE_OK != FSDK.LoadTrackerMemoryFromFile(ref tracker, TrackerMemoryFile)) // try to load saved tracker state
                FSDK.CreateTracker(ref tracker); // if could not be loaded, create a new tracker


            int err = 0; // set realtime face detection parameters
            FSDK.SetTrackerMultipleParameters(tracker, "HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=100; FaceDetectionThreshold=5;", ref err);
            string IsDetect;
            while (!needClose)
            {

                Int32 imageHandle = 0;
                if (FSDK.FSDKE_OK != FSDKCam.GrabFrame(cameraHandle, ref imageHandle)) // grab the current frame from the camera
                {
                    Application.DoEvents();
                    continue;
                }
                FSDK.CImage image = new FSDK.CImage(imageHandle);

                long[] IDs;
                long faceCount = 0;
                FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256); // maximum of 256 faces detected
                Array.Resize(ref IDs, (int)faceCount);

                // make UI controls accessible (to find if the user clicked on a face)
                Application.DoEvents();

                Image frameImage = image.ToCLRImage();
                Graphics gr = Graphics.FromImage(frameImage);
                IsDetect = "False";
                for (int i = 0; i < IDs.Length; ++i)
                {
                    IsDetect = "True";
                    //pictureBox1.Image = frameImage;
                    //string strapppath = "D:\\Kiosk_Image_Search\\imagecompare.jpg";// System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\imagesearch\\imagecompare.jpg";
                    //if (System.IO.File.Exists(strapppath.Replace("\\", "/")))
                    //{
                    //    System.IO.File.Delete(strapppath.Replace("\\", "/"));
                    //}
                    //pictureBox1.Image.Save(strapppath.Replace("\\", "/"), ImageFormat.Jpeg);

                    FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
                    FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);

                    int left = facePosition.xc - (int)(facePosition.w * 0.6);
                    int top = facePosition.yc - (int)(facePosition.w * 0.5);
                    int w = (int)(facePosition.w * 1.2);

                    String name;
                    int res = FSDK.GetAllNames(tracker, IDs[i], out name, 65536); // maximum of 65536 characters

                    if (FSDK.FSDKE_OK == res && name.Length > 0)
                    { // draw name
                        StringFormat format = new StringFormat();
                        format.Alignment = StringAlignment.Center;

                        gr.DrawString(name, new System.Drawing.Font("Arial", 16),
                            new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen),
                            facePosition.xc, top + w + 5, format);
                    }

                    Pen pen = Pens.LightGreen;
                    if (mouseX >= left && mouseX <= left + w && mouseY >= top && mouseY <= top + w)
                    {
                        pen = Pens.Blue;
                        if (ProgramState.psRemember == programState)
                        {
                            if (FSDK.FSDKE_OK == FSDK.LockID(tracker, IDs[i]))
                            {

                            }
                        }
                    }
                    gr.DrawRectangle(pen, left, top, w, w);
                }
                programState = ProgramState.psRecognize;

                // display current frame
               pictureBox1.Image = frameImage;
                GC.Collect(); // collect the garbage after the deletion
                if (IsDetect == "True")
                {
                    //string strapppath = "D:\\Kiosk_Image_Search\\imagecompare.jpg";// System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\imagesearch\\imagecompare.jpg";
                    ////if (System.IO.File.Exists(strapppath.Replace("\\", "/")))
                    ////{
                    ////    System.IO.File.Delete(strapppath.Replace("\\", "/"));
                    ////}
                   
                    ////pictureBox1.Image.Save(strapppath.Replace("\\", "/"), ImageFormat.Jpeg);
                    ////pictureBox1.Dispose();
                    ////pictureBox1.Refresh();

                    //Image img;
                    //string file = @"D:\Kiosk_Image_Search\imagecompare.jpg";
                    //using (Bitmap bmp = new Bitmap(file))
                    //{
                    //    img = new Bitmap(bmp);
                    //   // pictureBox1.Image = img;
                    //}
                    //if (System.IO.File.Exists(file))
                    //{
                    //    System.IO.File.Delete(file);
                    //    pictureBox1.Image.Save(file, ImageFormat.Jpeg);
                    //}
                    //else
                    //    pictureBox1.Image.Save(file, ImageFormat.Jpeg);

                  // needClose = true;

                    //frCompare.ImageFileName = "imaggecompre";
                    //frCompare.FacePosition = new FSDK.TFacePosition();
                    //frCompare.FacialFeatures = new FSDK.TPoint[2];
                    //frCompare.Template = new byte[FSDK.TemplateSize];
                    //frCompare.image = new FSDK.CImage(pictureBox1.Image);

                    //int images;
                    //int img1;

                    
                    //FSDK.LoadImageFromFile(ref img1, strapppath);
                    //FSDK.SaveImageToFile(img1, strapppath.Replace("\\", "/"));
                    //  ImageDetect();
                   // PopulateAllImage();
                    //if (FaceList.Count > 0)
                    //{
                    //    ImageDetect();
                    //}
                

                   // MessageBox.Show(FaceList.Count + "");
                    //MessageBox.Show("Face");
                    //FaceList = new List<TFaceRecord>();
                    //string strapppathTemp = "D:\\Kiosk_Image";
                    //String[] filenames = System.IO.Directory.GetFiles(strapppathTemp, "*.jpg");
                    ////MessageBox.Show(filenames.Length + "");
                    //for (int i = 0; i <= filenames.Length-1; i++)
                    //{

                    //    string strpath = filenames[i].Replace("\\", "/");

                    //    MessageBox.Show(strpath);
                    //    TFaceRecord fr = new TFaceRecord();
                    //    fr.ImageFileName = strpath;
                    //    fr.FacePosition = new FSDK.TFacePosition();
                    //    fr.FacialFeatures = new FSDK.TPoint[2];
                    //    fr.Template = new byte[FSDK.TemplateSize];
                    //    fr.image = new FSDK.CImage(strpath);

                    //    try 
                    //    {
                    //        fr.FacePosition = fr.image.DetectFace(); 
                    //        if (0 != fr.FacePosition.w)
                    //        {
                    //            MessageBox.Show(fr.FacePosition.w + "");
                    //            fr.faceImage = fr.image.CopyRect((int)(fr.FacePosition.xc - Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.yc - Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.xc + Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.yc + Math.Round(fr.FacePosition.w * 0.5)));

                    //            try
                    //            {
                    //                fr.FacialFeatures = fr.image.DetectEyesInRegion(ref fr.FacePosition);
                    //            }
                    //            catch (Exception ex2)
                    //            {
                    //                MessageBox.Show(ex2.Message, "Error detecting eyes.");
                    //            }

                    //            try
                    //            {
                    //                fr.Template = fr.image.GetFaceTemplateInRegion(ref fr.FacePosition); // get template with higher precision
                    //            }
                    //            catch (Exception ex2)
                    //            {
                    //                MessageBox.Show(ex2.Message, "Error retrieving face template.");
                    //            }

                    //            FaceList.Add(fr);
                    //            //imageList1.Images.Add(fr2.faceImage.ToCLRImage());
                    //            //lvRegister.Items.Add((imageList1.Images.Count - 1).ToString(), strpath, imageList1.Images.Count - 1);
                    //        }
                    //    }
                    //    catch (Exception exMain)
                    //    {
                    //        MessageBox.Show(exMain.Message, "Error retrieving face template. Main");
                    //    }
 

                    //    }

                    //MessageBox.Show(FaceList.Count + "");

                   // needClose = true;
                
                }
                }
            FSDK.SaveTrackerMemoryToFile(tracker, TrackerMemoryFile);
            FSDK.FreeTracker(tracker);

            FSDKCam.CloseVideoCamera(cameraHandle);
            FSDKCam.FinalizeCapturing();
            //if (needClose == true)
            //{
            //    Progresss();
            //}

            }
                 catch (Exception exPopulateData)
                 {

                 }
        
        }

  
        public void PopulateAllImage()
        {
            try {
                int percents;
            FaceList = new List<TFaceRecord>();
            string strapppath = LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_Image";// System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
           // strapppath = strapppath + "\\images";
            String[] filenames = System.IO.Directory.GetFiles(strapppath, "*.jpg");


            //imageList1 = new ImageList();
            //Size sizeCustom = new Size();
            //sizeCustom.Height = 50;
            //sizeCustom.Width = 50;
            //imageList1.ImageSize = sizeCustom;
            //imageList1.ColorDepth = ColorDepth.Depth24Bit;



            for (int i = 0; i < filenames.Length; ++i)
            {

                if (status == true)
                {
                    percents = (filenames.Length * 100) / filenames.Length;
                    bgw.ReportProgress(percents, filenames.Length-1);
                    return;
                }

                try
                {
                    string strpath = filenames[i].Replace("\\", "/");

                    Image img = Image.FromFile(strpath);
                TFaceRecord fr2 = new TFaceRecord();
                fr2.ImageFileName =strpath;
                fr2.FacePosition = new FSDK.TFacePosition();
                fr2.FacialFeatures = new FSDK.TPoint[2];
                fr2.Template = new byte[FSDK.TemplateSize];
                fr2.image = new FSDK.CImage(img);

                fr2.FacePosition = fr2.image.DetectFace();
                if (0 != fr2.FacePosition.w)
                //    if (strpath.Length <= 1)
                //        MessageBox.Show("No faces found. Try to lower the Minimal Face Quality parameter in the Options dialog box.", "Enrollment error");
                //    else
                //        strpath = strpath;   //this.txtDetect.Text += (fn + ": No faces found. Try to lower the Minimal Face Quality parameter in the Options dialog box.\r\n");
                //else
                {
                    fr2.faceImage = fr2.image.CopyRect((int)(fr2.FacePosition.xc - Math.Round(fr2.FacePosition.w * 0.5)), (int)(fr2.FacePosition.yc - Math.Round(fr2.FacePosition.w * 0.5)), (int)(fr2.FacePosition.xc + Math.Round(fr2.FacePosition.w * 0.5)), (int)(fr2.FacePosition.yc + Math.Round(fr2.FacePosition.w * 0.5)));

                    try
                    {
                        fr2.FacialFeatures = fr2.image.DetectEyesInRegion(ref fr2.FacePosition);
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message, "Error detecting eyes.");
                    }

                    try
                    {
                        fr2.Template = fr2.image.GetFaceTemplateInRegion(ref fr2.FacePosition); // get template with higher precision
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message, "Error retrieving face template.");
                    }

                    FaceList.Add(fr2);

                    string strpath2 = LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_Image_Search\\imagecompare.jpg"; //"D:\\Kiosk_Image\\9999.jpg";
                    strpath2 = strpath2.Replace("\\", "/");
                    string fn = strpath2;//dlg.FileNames[0];
                    TFaceRecord fr = new TFaceRecord();
                    fr.ImageFileName = fn;
                    fr.FacePosition = new FSDK.TFacePosition();
                    fr.FacialFeatures = new FSDK.TPoint[FSDK.FSDK_FACIAL_FEATURE_COUNT];
                    fr.Template = new byte[FSDK.TemplateSize];

                    try
                    {
                        Image imgSerach = Image.FromFile(strpath2); //pictureBox1.Image;//
                        fr.image = new FSDK.CImage(imgSerach);
                        //fr.image = new FSDK.CImage(fn);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error loading file");
                    }


                    fr.FacePosition = fr.image.DetectFace();
                    if (0 != fr.FacePosition.w)
                    //    1 = 1;
                    //// MessageBox.Show("No faces found. Try to lower the Minimal Face Quality parameter in the Options dialog box.", "Enrollment error");
                    //else
                    {
                        fr.faceImage = fr.image.CopyRect((int)(fr.FacePosition.xc - Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.yc - Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.xc + Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.yc + Math.Round(fr.FacePosition.w * 0.5)));

                        bool eyesDetected = false;
                        try
                        {
                            fr.FacialFeatures = fr.image.DetectEyesInRegion(ref fr.FacePosition);
                            eyesDetected = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error detecting eyes.");
                        }

                        if (eyesDetected)
                        {
                            fr.Template = fr.image.GetFaceTemplateInRegion(ref fr.FacePosition); // get template with higher precision
                        }
                    }
                    else
                    {
                       // MessageBox.Show("No faces found. Try to lower the Minimal Face Quality parameter in the Options dialog box.", "Enrollment error");
                        //MessageBox.Show("กรุณาถ่ายใหม่ค่ะ");
                        //needClose = false;
                        //PopulateData();
                        //return;
                    }



                    float Threshold = 0.0f;
                    FSDK.GetMatchingThresholdAtFAR(frmCameraDetect.FARValue / 100, ref Threshold);
                    int MatchedCount = 0;
                    //int FaceCount = frmCameraDetect.FaceList.Count; //frmCameraDetect.FaceList.Count;
                    //float[] Similarities = new float[FaceCount];
                    //int[] Numbers = new int[FaceCount];
                    float Similarities = 0.0f;
                    float Similarity = 0.0f;
                   // TFaceRecord CurrentFace = FaceList[i];
                    FSDK.MatchFaces(ref fr.Template, ref fr2.Template, ref Similarity);
                    if (Similarity >= Threshold)
                    {
                        Similarities = Similarity;
                        ++MatchedCount;
                    }
                    int icount;
                    icount = i + 1;

                    if (icount == 128) {

                      //  lblPercent.Text = "รุปที่ " + icount + " ความเหมือน=" + (Similarities * 100) + "%";
                    }


                  //  lblPercent.Text = "รุปที่ " + icount + " ความเหมือน=" + (Similarities * 100) + "%";
                    if (Similarities * 100 >= 85)
                    {

                        frCompare = fr2;

                        //FSDKCam.CloseVideoCamera(0);
                        needClose = true;
                        //// this.Close();

                        //this.Visible = false;
                        //this.Close();
                        //frmCameraResult Detect = new frmCameraResult();
                        //Detect.StartPosition = FormStartPosition.CenterScreen;
                        //Detect.ShowImage(fr2);
                        //Detect.ShowDialog();
                        //MessageBox.Show(Similarities * 100 + "");
                        return;



                    }
                    //imageList1.Images.Add(fr2.faceImage.ToCLRImage());
                    //lvRegister.Items.Add((imageList1.Images.Count - 1).ToString(), strpath, imageList1.Images.Count - 1);
                }
                }
                catch (Exception exfor)
                {

                }



                //System.Threading.Thread.Sleep(100);
                percents = (i * 100) / filenames.Length;
                bgw.ReportProgress(percents, i);

            }





            //lvRegister.OwnerDraw = false;
            //lvRegister.View = View.LargeIcon;
            //lvRegister.Dock = DockStyle.Right;
            //lvRegister.LargeImageList = imageList1;

            }
            catch (Exception exPopulateAllImage)
            {

            }
        }

        public void ShowDetect()
        {
            {
                int cameraHandle = 0;

                int r = FSDKCam.OpenVideoCamera(ref cameraName, ref cameraHandle);
                if (r != FSDK.FSDKE_OK)
                {
                    MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                int tracker = 0; 	// creating a Tracker
                if (FSDK.FSDKE_OK != FSDK.LoadTrackerMemoryFromFile(ref tracker, TrackerMemoryFile)) // try to load saved tracker state
                    FSDK.CreateTracker(ref tracker); // if could not be loaded, create a new tracker


                int err = 0; // set realtime face detection parameters
                FSDK.SetTrackerMultipleParameters(tracker, "HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=100; FaceDetectionThreshold=5;", ref err);

                while (!needClose)
                {

                    Int32 imageHandle = 0;
                    if (FSDK.FSDKE_OK != FSDKCam.GrabFrame(cameraHandle, ref imageHandle)) // grab the current frame from the camera
                    {
                        Application.DoEvents();
                        continue;
                    }
                    FSDK.CImage image = new FSDK.CImage(imageHandle);

                    long[] IDs;
                    long faceCount = 0;
                    FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256); // maximum of 256 faces detected
                    Array.Resize(ref IDs, (int)faceCount);

                    // make UI controls accessible (to find if the user clicked on a face)
                    Application.DoEvents();

                    Image frameImage = image.ToCLRImage();
                    Graphics gr = Graphics.FromImage(frameImage);
                    
                    IsDetect= "False";
                    //txtDetect.Text = "ไม่เจอ";
                    for (int i = 0; i < IDs.Length; ++i)
                    {
                        //txtDetect.Text = "เจอ";
                        IsDetect = "True";


                        FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
                        FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);

                        int left = facePosition.xc - (int)(facePosition.w * 0.6);
                        int top = facePosition.yc - (int)(facePosition.w * 0.5);
                        int w = (int)(facePosition.w * 1.2);

                        String name;
                        int res = FSDK.GetAllNames(tracker, IDs[i], out name, 65536); // maximum of 65536 characters

                        if (FSDK.FSDKE_OK == res && name.Length > 0)
                        { // draw name
                            StringFormat format = new StringFormat();
                            format.Alignment = StringAlignment.Center;

                            gr.DrawString(name, new System.Drawing.Font("Arial", 16),
                                new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen),
                                facePosition.xc, top + w + 5, format);
                        }

                        Pen pen = Pens.LightGreen;
                        if (mouseX >= left && mouseX <= left + w && mouseY >= top && mouseY <= top + w)
                        {
                            pen = Pens.Blue;
                            if (ProgramState.psRemember == programState)
                            {
                                if (FSDK.FSDKE_OK == FSDK.LockID(tracker, IDs[i]))
                                {
                                    // get the user name
                                    //frmInputBox inputName = new frmInputBox();
                                    //if (DialogResult.OK == inputName.ShowDialog())
                                    //{
                                    //    userName = inputName.userName;
                                    //    FSDK.SetName(tracker, IDs[i], userName);
                                    //    FSDK.UnlockID(tracker, IDs[i]);
                                    //}
                                }
                            }
                        }
                        gr.DrawRectangle(pen, left, top, w, w);
                    }
                    programState = ProgramState.psRecognize;

                    // display current frame
                    pictureBox1.Image = frameImage;

                    GC.Collect(); // collect the garbage after the deletion
                    if (IsDetect == "True") {
                    string strapppath = LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_Image_Search\\imagecompare.jpg";// System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\imagesearch\\imagecompare.jpg";
                    if (System.IO.File.Exists(strapppath.Replace("\\", "/")))
                    {
                        System.IO.File.Delete(strapppath.Replace("\\", "/"));
                    }
                          pictureBox1.Image.Save(strapppath.Replace("\\", "/"),ImageFormat.Jpeg);

                        //ImageDetect();
                    }
         

                }
                FSDK.SaveTrackerMemoryToFile(tracker, TrackerMemoryFile);
                FSDK.FreeTracker(tracker);

                FSDKCam.CloseVideoCamera(cameraHandle);
                FSDKCam.FinalizeCapturing();
                //if (needClose == true) {


                //    if (frmCameraDetect.FaceList.Count == 0)
                //    {
                //     MessageBox.Show("Please enroll faces first", "Error");
                //    }
                //    else { 


                //    }

                
                //}
            }
        }



        public void ImageDetect()
        {
           


            if (frmCameraDetect.FaceList.Count == 0)
                MessageBox.Show("Please enroll faces first", "Error");
            else
            {
               // string strapppath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\imagesearch\\imagecompare.jpg";
                string strapppath = LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_Image_Search\\imagecompare.jpg";
                strapppath = strapppath.Replace("\\", "/");
                string fn = strapppath;//dlg.FileNames[0];
                TFaceRecord fr = new TFaceRecord();
                fr.ImageFileName = fn;
                fr.FacePosition = new FSDK.TFacePosition();
                fr.FacialFeatures = new FSDK.TPoint[FSDK.FSDK_FACIAL_FEATURE_COUNT];
                fr.Template = new byte[FSDK.TemplateSize];

                try
                {
                    fr.image = new FSDK.CImage(fn);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error loading file");
                }


                fr.FacePosition = fr.image.DetectFace();
                if (0 != fr.FacePosition.w)
                //    1 = 1;
                //// MessageBox.Show("No faces found. Try to lower the Minimal Face Quality parameter in the Options dialog box.", "Enrollment error");
                //else
                {
                    fr.faceImage = fr.image.CopyRect((int)(fr.FacePosition.xc - Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.yc - Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.xc + Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.yc + Math.Round(fr.FacePosition.w * 0.5)));

                    bool eyesDetected = false;
                    try
                    {
                        fr.FacialFeatures = fr.image.DetectEyesInRegion(ref fr.FacePosition);
                        eyesDetected = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error detecting eyes.");
                    }

                    if (eyesDetected)
                    {
                        fr.Template = fr.image.GetFaceTemplateInRegion(ref fr.FacePosition); // get template with higher precision
                    }
                }
                else
                {
                    //MessageBox.Show("No faces found. Try to lower the Minimal Face Quality parameter in the Options dialog box.", "Enrollment error");
                }





                float Threshold = 0.0f;
                FSDK.GetMatchingThresholdAtFAR(frmCameraDetect.FARValue / 100, ref Threshold);
                int MatchedCount = 0;
                int FaceCount = frmCameraDetect.FaceList.Count; //frmCameraDetect.FaceList.Count;
                float[] Similarities = new float[FaceCount];
                int[] Numbers = new int[FaceCount];
                for (int i = 0; i < frmCameraDetect.FaceList.Count; i++)
                {
                    float Similarity = 0.0f;
                    TFaceRecord CurrentFace = frmCameraDetect.FaceList[i];
                    FSDK.MatchFaces(ref fr.Template, ref CurrentFace.Template, ref Similarity);
                    if (Similarity >= Threshold)
                    {
                        Similarities[MatchedCount] = Similarity;
                        Numbers[MatchedCount] = i;
                        ++MatchedCount;
                    }

                    if (Similarities[i] * 100 >= 90)
                    {

                        FSDKCam.CloseVideoCamera(0);
                        needClose = true;
                        // this.Close();
                       
                        this.Visible = false;
                        this.Close();
                        frmCameraResult Detect = new frmCameraResult();
                        Detect.StartPosition = FormStartPosition.CenterScreen;
                        Detect.ShowImage(CurrentFace);
                        Detect.ShowDialog();
                        return;

                    

                    }
                }


            }



        }



        private void frmCameraDetect_FormClosing(object sender, FormClosingEventArgs e)
        {
            needClose = true;
            this.Close();
        }

        //private void btnStart_Click(object sender, EventArgs e)
        //{
        //    int cameraHandle = 0;

        //    int r = FSDKCam.OpenVideoCamera(ref cameraName, ref cameraHandle);
        //    if (r != FSDK.FSDKE_OK)
        //    {
        //        MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Application.Exit();
        //    }

        //    int tracker = 0; 	// creating a Tracker
        //    if (FSDK.FSDKE_OK != FSDK.LoadTrackerMemoryFromFile(ref tracker, TrackerMemoryFile)) // try to load saved tracker state
        //        FSDK.CreateTracker(ref tracker); // if could not be loaded, create a new tracker


        //    int err = 0; // set realtime face detection parameters
        //    FSDK.SetTrackerMultipleParameters(tracker, "HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=100; FaceDetectionThreshold=5;", ref err);

        //    while (!needClose)
        //    {

        //        Int32 imageHandle = 0;
        //        if (FSDK.FSDKE_OK != FSDKCam.GrabFrame(cameraHandle, ref imageHandle)) // grab the current frame from the camera
        //        {
        //            Application.DoEvents();
        //            continue;
        //        }
        //        FSDK.CImage image = new FSDK.CImage(imageHandle);

        //        long[] IDs;
        //        long faceCount = 0;
        //        FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256); // maximum of 256 faces detected
        //        Array.Resize(ref IDs, (int)faceCount);

        //        // make UI controls accessible (to find if the user clicked on a face)
        //        Application.DoEvents();

        //        Image frameImage = image.ToCLRImage();
        //        Graphics gr = Graphics.FromImage(frameImage);
        //        // txtDetect.Text = "ไม่เจอ";
        //        for (int i = 0; i < IDs.Length; ++i)
        //        {
        //            // txtDetect.Text = "เจอ";
        //            FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
        //            FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);

        //            int left = facePosition.xc - (int)(facePosition.w * 0.6);
        //            int top = facePosition.yc - (int)(facePosition.w * 0.5);
        //            int w = (int)(facePosition.w * 1.2);

        //            String name;
        //            int res = FSDK.GetAllNames(tracker, IDs[i], out name, 65536); // maximum of 65536 characters

        //            if (FSDK.FSDKE_OK == res && name.Length > 0)
        //            { // draw name
        //                StringFormat format = new StringFormat();
        //                format.Alignment = StringAlignment.Center;

        //                gr.DrawString(name, new System.Drawing.Font("Arial", 16),
        //                    new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen),
        //                    facePosition.xc, top + w + 5, format);
        //            }

        //            Pen pen = Pens.LightGreen;
        //            if (mouseX >= left && mouseX <= left + w && mouseY >= top && mouseY <= top + w)
        //            {
        //                pen = Pens.Blue;
        //                if (ProgramState.psRemember == programState)
        //                {
        //                    if (FSDK.FSDKE_OK == FSDK.LockID(tracker, IDs[i]))
        //                    {
        //                        // get the user name
        //                        frmInputBox inputName = new frmInputBox();
        //                        if (DialogResult.OK == inputName.ShowDialog())
        //                        {
        //                            userName = inputName.userName;
        //                            FSDK.SetName(tracker, IDs[i], userName);
        //                            FSDK.UnlockID(tracker, IDs[i]);
        //                        }
        //                    }
        //                }
        //            }
        //            gr.DrawRectangle(pen, left, top, w, w);
        //        }
        //        programState = ProgramState.psRecognize;

        //        // display current frame
        //        pictureBox1.Image = frameImage;
        //        GC.Collect(); // collect the garbage after the deletion
        //    }
        //    FSDK.SaveTrackerMemoryToFile(tracker, TrackerMemoryFile);
        //    FSDK.FreeTracker(tracker);

        //    FSDKCam.CloseVideoCamera(cameraHandle);
        //    FSDKCam.FinalizeCapturing();
        //}

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            programState = ProgramState.psRemember;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            mouseX = 0;
            mouseY = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            needClose = true;
            Application.Exit();
            this.Close();
            //frmCameraConfig f = new frmCameraConfig();
            //f.Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            needClose = true;
            Application.Exit();
            this.Close();
        }

        private void PictureClose_Click(object sender, EventArgs e)
        {
            needClose = true;
             this.Visible = false;
            this.Close();
            frmCameraConfig f = new frmCameraConfig();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Image img;
            //string file = @"D:\Kiosk_Image_Search\imagecompare.jpg";
            //using (Bitmap bmp = new Bitmap(file))
            //{
            //    img = new Bitmap(bmp);
            //    // pictureBox1.Image = img;
            //}
            //if (System.IO.File.Exists(file))
            //{
            //    System.IO.File.Delete(file);
            //    pictureBox1.Image.Save(file, ImageFormat.Jpeg);
            //}
            //else
            //    pictureBox1.Image.Save(file, ImageFormat.Jpeg);

            //if (CheckFile() == true)
            //{
            //    pictureSearch.Visible = false;

            //    Progresss();

            //}
            //else
            //{
            //    MessageBox.Show("กรุณาถ่ายรูปใหม่ค่ะ");
            //    //needClose = false;
            //    //PopulateData();
            //    this.Visible = false;
            //    this.Close();
            //    frmCameraDetect f = new frmCameraDetect();
            //    f.ShowDialog();
            //}

            needClose = true;
            Image img;
            string file = LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_Image_Search\\imagecompare.jpg";
            using (Bitmap bmp = new Bitmap(file))
            {
                img = new Bitmap(bmp);
                // pictureBox1.Image = img;
            }
            if (System.IO.File.Exists(file))
            {
                System.IO.File.Delete(file);
                pictureBox1.Image.Save(file, ImageFormat.Jpeg);
            }
            else
                pictureBox1.Image.Save(file, ImageFormat.Jpeg);

            if (CheckFile() == true)
            {
                pictureSearch.Visible = false;

                Progresss();

            }
            else
            {
                Dialog.frmDialogMsg msg = new Dialog.frmDialogMsg();
                msg.lblText.Text = "ไม่พบข้อมูล";
                msg.ShowDialog();
                //needClose = false;
                //PopulateData();
                this.Visible = false;
                this.Close();
                frmCameraDetect f = new frmCameraDetect();
                f.ShowDialog();
            }

        }

        private void pictureSearch_Click(object sender, EventArgs e)
        {
            //string strapppath = "D:\\Kiosk_Image_Search\\imagecompare.jpg";// System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\imagesearch\\imagecompare.jpg";
            //if (System.IO.File.Exists(strapppath.Replace("\\", "/")))
            //{
            //    System.IO.File.Delete(strapppath.Replace("\\", "/"));
            //}

            //pictureBox1.Image.Save(strapppath.Replace("\\", "/"), ImageFormat.Jpeg);
            //pictureBox1.Dispose();
            //pictureBox1.Refresh();
            needClose = true;
            Image img;
            string file = LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_Image_Search\\imagecompare.jpg";
            using (Bitmap bmp = new Bitmap(file))
            {
                img = new Bitmap(bmp);
                // pictureBox1.Image = img;
            }
            if (System.IO.File.Exists(file))
            {
                System.IO.File.Delete(file);
                pictureBox1.Image.Save(file, ImageFormat.Jpeg);
            }
            else
            pictureBox1.Image.Save(file, ImageFormat.Jpeg);

            if (CheckFile() == true)
            {
                pictureSearch.Visible = false;

                Progresss();

            }
            else {
                Dialog.frmDialogMsg msg = new Dialog.frmDialogMsg();
                msg.lblText.Text = "ไม่พบข้อมูล";
                msg.ShowDialog();
                //needClose = false;
                //PopulateData();
                this.Visible = false;
                this.Close();
                frmCameraDetect f = new frmCameraDetect();
                f.ShowDialog();
            }
        
        }

        public Boolean CheckFile() {
            Boolean ret;
            ret = true;
            string strpath2 = LiveFaceScan.CameraSetting.Drive + ":\\Kiosk_Image_Search\\imagecompare.jpg"; //"D:\\Kiosk_Image\\9999.jpg";
            strpath2 = strpath2.Replace("\\", "/");
            string fn = strpath2;//dlg.FileNames[0];
            TFaceRecord fr = new TFaceRecord();
            fr.ImageFileName = fn;
            fr.FacePosition = new FSDK.TFacePosition();
            fr.FacialFeatures = new FSDK.TPoint[FSDK.FSDK_FACIAL_FEATURE_COUNT];
            fr.Template = new byte[FSDK.TemplateSize];

            try
            {
                Image imgSerach = Image.FromFile(strpath2); //pictureBox1.Image;//
                fr.image = new FSDK.CImage(imgSerach);
                //fr.image = new FSDK.CImage(fn);

            }
            catch (Exception ex)
            {
                ret =  false;
            }


            fr.FacePosition = fr.image.DetectFace();
            if (0 != fr.FacePosition.w)
            //    1 = 1;
            //// MessageBox.Show("No faces found. Try to lower the Minimal Face Quality parameter in the Options dialog box.", "Enrollment error");
            //else
            {
                fr.faceImage = fr.image.CopyRect((int)(fr.FacePosition.xc - Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.yc - Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.xc + Math.Round(fr.FacePosition.w * 0.5)), (int)(fr.FacePosition.yc + Math.Round(fr.FacePosition.w * 0.5)));

                bool eyesDetected = false;
                try
                {
                    fr.FacialFeatures = fr.image.DetectEyesInRegion(ref fr.FacePosition);
                    eyesDetected = true;
                }
                catch (Exception ex)
                {
                    ret = false;
                }

                if (eyesDetected)
                {
                    fr.Template = fr.image.GetFaceTemplateInRegion(ref fr.FacePosition); // get template with higher precision
                }
            }
            else
            {
                // MessageBox.Show("No faces found. Try to lower the Minimal Face Quality parameter in the Options dialog box.", "Enrollment error");
                //MessageBox.Show("กรุณาถ่ายใหม่ค่ะ");
                //needClose = false;
                //PopulateData();
                ret = false;
            }
           
            return ret;

        
        }

        private void pictureClose2_Click(object sender, EventArgs e)
        {
           needClose = true;
            this.Visible = false;
            this.Close();
            frmCameraDetect f = new frmCameraDetect();
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timmercout == 4) {
                timmercout = 0;
            }
            timmercout += 1;

         
        }

        private void pictureCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bgw.CancellationPending)
                {
                    try
                    {
                        status = true;
                        bgw.CancelAsync();
                        this.Visible = false;
                        this.Close();
                        //System.Diagnostics.Process.Start(Application.StartupPath + @"/Kiosk_eBrochure_M.exe");
                        //System.Environment.Exit(0);
                        frmSearchMobile f = new frmSearchMobile();
                        f.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
               
            }
      
        }

        private void bgw2_DoWork(object sender, DoWorkEventArgs e)
        {

        }







    }
}
