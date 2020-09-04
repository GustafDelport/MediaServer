using MusicPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        static bool state;
        static bool picState;

        private void Form1_Load(object sender, EventArgs e)
        {
            list.ValueMember = "path";
            list.DisplayMember = "FileName";

            new Thread(new ThreadStart(ticker)).Start();

            DirectoryInfo info = new DirectoryInfo(@"C:\Users\User-PC\Music\MusicServer");
            List<MediaFile> Files = new List<MediaFile>();
            FileInfo[] songs = info.GetFiles("*.mp3");

            foreach (var item in songs)
            {
                Files.Add(new MediaFile() { FileName = item.Name, Path = item.FullName });
            }
            songs = info.GetFiles(".mp4");

            foreach (var item in songs)
            {
                Files.Add(new MediaFile() { FileName = item.Name, Path = item.FullName });
            }
            list.DataSource = Files;
            mpPlayer.Ctlcontrols.play();
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = list.SelectedItem as MediaFile;
            if (file != null)
            {
                mpPlayer.URL = file.Path;
            }
            if (!state)
            {
                mpPlayer.Ctlcontrols.play();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (state)
            {
                picPnP.Image = Resources.pause;
                mpPlayer.Ctlcontrols.play();
                state = false;
            }
            else 
            {
                picPnP.Image = Resources.play;
                mpPlayer.Ctlcontrols.pause();
                state = true;
            }
        }

        private void picNxt_Click(object sender, EventArgs e)
        {
            Skip();
        }

        public void Skip()
        {
            if (list.SelectedIndex == list.Items.Count - 1)
            {
                list.SelectedIndex = 0;
            }
            else list.SelectedIndex++;
            
        }
        private void picPrev_Click(object sender, EventArgs e)
        {
            if (list.SelectedIndex == 0)
            {
                list.SelectedIndex = list.Items.Count-1;
            }
            else list.SelectedIndex--;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        delegate void updateDel();

        public void updatePic()
        {
            if (piclogo.InvokeRequired)
            {
                updateDel del = new updateDel(updatePic);
                this.Invoke(del);
            }
            else
            {
                if (picState)
                {
                    piclogo.Image = Resources.vox;
                    picState = false;
                }
                else
                {
                    piclogo.Image = Resources.vox2;
                    picState = true;
                }
            }
        }

        public void ticker()
        {
            while (true)
            {
                Thread.Sleep(250);
                updatePic();
            } 
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.close2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.close;
        }
    }
}
