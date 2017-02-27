using iOffice10.License.Generator.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iOffice10.License.Generator.Views
{
    public partial class EditLicenseForm : Form
    {
        private NormalLicenseConfigPanel normalLicenseConfigPanel;
        private TrialLicenseConfigPanel trialLicenseConfigPanel;
        private DevelopLicenseConfigPanel developLicenseConfigPanel;
        public EditLicenseForm()
        {
            InitializeComponent();
            this.normalLicenseConfigPanel = new NormalLicenseConfigPanel();
            this.normalLicenseConfigPanel.Dock = DockStyle.Fill;
            this.containerConfig.Controls.Add(this.normalLicenseConfigPanel);

            this.Init();
        }

        private void btnGenerateLicense_Click(object sender, EventArgs e)
        {
            if (this.rdoNomal.Checked) {
                MessageBox.Show("生成正式license");
                return;
            }
            if (this.rdoTrial.Checked) {
                MessageBox.Show("生成试用license");
                return;
            }
            if (this.rdoDevelop.Checked) {
                MessageBox.Show("生成开发license");
            }

        }

        private void Init() {
            this.rdoNomal.CheckedChanged += RdoNomal_CheckedChanged;
            this.rdoTrial.CheckedChanged += RdoTrial_CheckedChanged;
            this.rdoDevelop.CheckedChanged += RdoDevelop_CheckedChanged;
        }

        private void RdoNomal_CheckedChanged(object sender, EventArgs e)
        {
            var rdoBtn = sender as RadioButton;
            if (rdoBtn.Checked) {
                SwitchConfigPanel("Normal");
            }
        }

        private void RdoDevelop_CheckedChanged(object sender, EventArgs e)
        {
            var rdoBtn = sender as RadioButton;
            if (rdoBtn.Checked)
            {
                SwitchConfigPanel("Develop");
            }
        }

        private void RdoTrial_CheckedChanged(object sender, EventArgs e)
        {
            var rdoBtn = sender as RadioButton;
            if (rdoBtn.Checked)
            {
                SwitchConfigPanel("Trial");
            }
        }

        private void SwitchConfigPanel(string configType) {
            Control configPanel;
            switch (configType) {
                case "Normal":
                    configPanel = this.normalLicenseConfigPanel;
                    if (configPanel==null || configPanel.IsDisposed) {
                        configPanel = new NormalLicenseConfigPanel();
                        this.containerConfig.Controls.Add(configPanel);
                    }
                    break;
                case "Trial":
                    configPanel = this.trialLicenseConfigPanel;
                    if (configPanel == null || configPanel.IsDisposed)
                    {
                        configPanel = new TrialLicenseConfigPanel();
                        this.containerConfig.Controls.Add(configPanel);
                    }
                    break;
                case "Develop":
                    configPanel = this.developLicenseConfigPanel;
                    if (configPanel == null || configPanel.IsDisposed)
                    {
                        configPanel = new DevelopLicenseConfigPanel();
                        this.containerConfig.Controls.Add(configPanel);
                    }
                    break;
                default:
                    throw new Exception("unsurport configType");

            }
            configPanel.Dock = DockStyle.Fill;
            foreach (Control control in this.containerConfig.Controls) {
                control.Hide();
            }
            this.containerConfig.Controls[configPanel.Name].Show();
        }
    }
}
