using BioMetrixCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodesLankaZKTecoReader
{
    public partial class Form1 : Form
    {
        ZKTecoDAL device;
        bool isDeviceConnected = true;

        public Form1()
        {
            InitializeComponent();

            device = new ZKTecoDAL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void buConnect_Click(object sender, EventArgs e)
        {
            try
            {
                lastatus.Text = "Trying To Connect";

                for (int i = 0; i < 100; i++)
                {
                    pbconnection.Value = i;

                    await Task.Delay(40);
                }

                string ret = device.connectDevice(tip.Text,tport.Text);                               

                if (ret == "Connected - Serial No: CGCA222960794,")
                {
                    pbconnection.Value = 99;
                    rtdeviceinfo.ForeColor = Color.Black;
                    lastatus.ForeColor = Color.White;
                    lastatus.Text = "Device Online";
                    isDeviceConnected = true;
                }
                else
                {
                    pbconnection.Value = 0;
                    rtdeviceinfo.ForeColor = Color.DarkRed;
                    lastatus.ForeColor = Color.DarkRed;
                    lastatus.Text = "Device Offline";
                    isDeviceConnected = false;
                }

                rtdeviceinfo.Text = ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                isDeviceConnected = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (isDeviceConnected)
                {
                    device.beepDevice();
                }
                else
                {
                    MessageBox.Show(this, "Device not connected. Please check the connection.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (isDeviceConnected)
                {
                    ICollection<MachineInfo> users = device.getLogData();

                    device.bindToGridView(gridalldata, users);
                }
                else
                {
                    MessageBox.Show(this, "Device not connected. Please check the connection.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (isDeviceConnected)
                {
                    ICollection<UserInfo> users = device.getAllUsers();

                    device.bindToGridView(gridalldata, users);
                }
                else
                {
                    MessageBox.Show(this, "Device not connected. Please check the connection.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (isDeviceConnected)
                {
                    rtdeviceinfo.Text = device.pingDevice(tip.Text);
                }
                else
                {
                    MessageBox.Show(this, "Device not connected. Please check the connection.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
