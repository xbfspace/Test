using NIS.RightSystem.Views.RightDefine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIS.RightSystem.Views
{
    public partial class MainForm : Form
    {
        private BusinessDefinePanel businessDefinePanel;
        public MainForm()
        {
            InitializeComponent();
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (businessDefinePanel==null || businessDefinePanel.IsDisposed) {
                businessDefinePanel = new BusinessDefinePanel();
            }
            this.mainContainer.Controls.Clear();
            this.mainContainer.Controls.Add(businessDefinePanel);
            businessDefinePanel.Dock = DockStyle.Fill;
            businessDefinePanel.Show();
        }
    }
}
