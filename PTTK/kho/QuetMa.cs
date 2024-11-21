using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace PTTK
{
    public partial class QuetMa : Form
    {
        public QuetMa()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Formkho k = new Formkho();
            k.Show();
            this.Hide();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void btn_start_Click(object sender, EventArgs e)
        {
            //khoi tao thiet bi video, dua tren tb ddc chon tu cbbox
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[CbCamera.SelectedIndex].MonikerString);
            //dang ki nhan su kiem frame moi tu camera
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //nha frame tu hinh anh camera
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();// tao doi tuong doc barcode
            var result = reader.Decode(bitmap);// doc qr code/ barcode tu hinh anh
            if (result != null)
            {
                txt_macode.Invoke(new MethodInvoker(delegate ()
                {
                    txt_macode.Text = result.ToString();//hienthi kq len texrbox
                }));

            }
            pictureBox1.Image = bitmap;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if(videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    pictureBox1.Image = null;
                }
            }
        }

        private void QuetMa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    pictureBox1.Image = null;
                }
            }
        }

        private void QuetMa_Load(object sender, EventArgs e)
        {
            // lay ds cac thiet bi video dang duoc knoi voi maytinh
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // them ten cua cac thiet bij vaof cb box
            foreach (FilterInfo device in filterInfoCollection)
                CbCamera.Items.Add(device.Name);
            CbCamera.SelectedIndex = 0;//chon tbi co chi so dau tien trong dsach
        }
    }
}
