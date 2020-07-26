using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZAudioSwitcher
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public CoreAudioController Controller;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            thisNotifyIcon.Click += ThisNotifyIcon_Click;
            this.FormBorderStyle = FormBorderStyle.None;
            Controller = new CoreAudioController();

            var defaultInputDevice = Controller.GetDefaultDevice(DeviceType.Capture, Role.Multimedia);
            var defaultInputComDevice = Controller.GetDefaultDevice(DeviceType.Capture, Role.Communications);
            var defaultOutputDevice = Controller.GetDefaultDevice(DeviceType.Playback, Role.Multimedia);
            var defaultOutputComDevice = Controller.GetDefaultDevice(DeviceType.Playback, Role.Communications);

            DefaultInputLabel.Text = defaultInputComDevice.FullName;
            DefaultInputComLabel.Text = defaultInputDevice.FullName;
            DefaultOutputComLabel.Text = defaultOutputComDevice.FullName;
            DefaultOutputLabel.Text = defaultOutputDevice.FullName;

            /*
            var Outputdevices = Controller.GetPlaybackDevices(DeviceState.Active);

            var Inputdevices = Controller.GetCaptureDevices(DeviceState.Active);

            //Console.WriteLine("These are input devices");
            foreach (var endpoint in Inputdevices)
            {
                InputDropdown.Items.Add(endpoint.FullName);
                //Console.WriteLine(endpoint.Fullname);
            }

            //Console.WriteLine("These are output devices");
            foreach (var endpoint in Outputdevices)
            {
                OutputDropdown.Items.Add(endpoint.FullName);
                //Console.WriteLine(endpoint.FullName);
            }
            */

           
            OutputDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
           
            InputDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateDropdowns();

        }

        private void UpdateDropdowns()
        {
            var Outputdevices = Controller.GetPlaybackDevices(DeviceState.Active);
            var Inputdevices = Controller.GetCaptureDevices(DeviceState.Active);

            InputDropdown.Items.Clear();
            OutputDropdown.Items.Clear();

            foreach (var endpoint in Inputdevices)
            {
                InputDropdown.Items.Add(endpoint.FullName);
                //Console.WriteLine(endpoint.Fullname);
            }

            //Console.WriteLine("These are output devices");
            foreach (var endpoint in Outputdevices)
            {
                OutputDropdown.Items.Add(endpoint.FullName);
                //Console.WriteLine(endpoint.FullName);
            }

            var defaultInputDevice = Controller.GetDefaultDevice(DeviceType.Capture, Role.Multimedia);
            var defaultOutputDevice = Controller.GetDefaultDevice(DeviceType.Playback, Role.Multimedia);

            OutputDropdown.SelectedItem = defaultOutputDevice;
            OutputDropdown.Text = defaultOutputDevice.FullName;

            InputDropdown.SelectedItem = defaultInputDevice;
            InputDropdown.Text = defaultInputDevice.FullName;
        }


        #region WindowMods

        private void ThisNotifyIcon_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            thisNotifyIcon.Visible = false;
            UpdateDropdowns();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void MinimizeToTray_Click(object sender, EventArgs e)
        {
            thisNotifyIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        #endregion

        private void OutputSetDefault_Click(object sender, EventArgs e)
        {
            var devices = Controller.GetPlaybackDevices(DeviceState.Active);


            foreach (var endpoint in devices)
            {

                if (endpoint.FullName == OutputDropdown.SelectedItem.ToString())
                {
                    Controller.DefaultPlaybackDevice = endpoint;
                }
            }
            DefaultOutputLabel.Text = Controller.DefaultPlaybackDevice.FullName;
            
        }


        private void OutputSetComDefault_Click(object sender, EventArgs e)
        {
            var devices = Controller.GetPlaybackDevices(DeviceState.Active);


            foreach (var endpoint in devices)
            {

                if (endpoint.FullName == OutputDropdown.SelectedItem.ToString())
                {
                    Controller.DefaultPlaybackCommunicationsDevice = endpoint;
                }
            }
            DefaultOutputComLabel.Text = Controller.DefaultPlaybackCommunicationsDevice.FullName;
        }

        private void InputSetDefault_Click(object sender, EventArgs e)
        {
            var devices = Controller.GetCaptureDevices(DeviceState.Active);


            foreach (var endpoint in devices)
            {
                if (endpoint.FullName == InputDropdown.SelectedItem.ToString())
                {
                    Controller.DefaultCaptureDevice = endpoint;
                }
            }
            DefaultInputLabel.Text = Controller.DefaultCaptureDevice.FullName;
        }

        private void InputSetComDefault_Click(object sender, EventArgs e)
        {
            var devices = Controller.GetCaptureDevices(DeviceState.Active);


            foreach (var endpoint in devices)
            {
                if (endpoint.FullName == InputDropdown.SelectedItem.ToString())
                {
                    Controller.DefaultCaptureCommunicationsDevice = endpoint;
                }
            }
            DefaultInputComLabel.Text = Controller.DefaultCaptureCommunicationsDevice.FullName;
        }
    }
}
