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

namespace iOffice10.License.Generator
{
    public partial class MainForm : Form
    {
        private EditLicenseForm editLicenseForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuAddLicense_Click(object sender, EventArgs e)
        {
            if (editLicenseForm==null || editLicenseForm.IsDisposed) {
                editLicenseForm = new EditLicenseForm();
            }
            editLicenseForm.BringToFront();
            editLicenseForm.Show();
        }
    }
}
