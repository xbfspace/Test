using NIS.RightSystem.Data.Entities;
using NIS.RightSystem.Services.ServiceImplement;
using NIS.RightSystem.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIS.RightSystem.Views.RightDefine
{
    public partial class EditBusinessDefineForm : Form
    {
        private readonly IBusinessTemplateService BusinessTemplateService=new BusinessTemplateService();
        public EditBusinessDefineForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BusinessTemplateService.Add(new BusinessTemplate
            {
                Name = this.txbName.Text,
                Code = this.txbCode.Text,
                Remark = this.txbRemark.Text
            });
            this.Close();
        }
    }
}
