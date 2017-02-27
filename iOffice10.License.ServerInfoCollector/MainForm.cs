using iOffice10.License.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iOffice10.License.ServerInfoCollector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGetServerInfo_Click(object sender, EventArgs e)
        {
            this.txbServerInfo.Text = string.Empty;
            this.txbServerInfo.Text ="硬盘号："+ MachineInfoHelper.GetHardDiskNumber()+"\r\n";
            this.txbServerInfo.Text += "内存编号:" + MachineInfoHelper.GetMemoryNumber() + "\r\n";
            this.txbServerInfo.Text += "cpu编号:"+MachineInfoHelper.GetCPUNumber()+"\r\n";
            this.txbServerInfo.Text += "cpu:"+MachineInfoHelper.CpuInfo()+"\r\n";
            this.txbServerInfo.Text += "操作系统信息：" + MachineInfoHelper.OSInfo() + "\r\n";

        }

        private void btnGetMachineFingerprint_Click(object sender, EventArgs e)
        {
           this.txbMachineFingerprint.Text =  MachineInfoHelper.GetMachineFingerprint();
        }
    }
}
