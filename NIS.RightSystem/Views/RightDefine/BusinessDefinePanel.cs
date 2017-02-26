using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NIS.RightSystem.Services.ServiceInterface;
using NIS.RightSystem.Services.ServiceImplement;

namespace NIS.RightSystem.Views.RightDefine
{
    public partial class BusinessDefinePanel : UserControl
    {
        private IBusinessTemplateService BusinessTemplateService = new BusinessTemplateService();
        private EditBusinessDefineForm editBusinessDefineForm;
        public BusinessDefinePanel()
        {
            InitializeComponent();
            Init();
            
        }

        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            if (editBusinessDefineForm == null || editBusinessDefineForm.IsDisposed) {
                editBusinessDefineForm = new EditBusinessDefineForm();
                editBusinessDefineForm.FormClosed += EditBusinessDefineForm_FormClosed;
            }
            editBusinessDefineForm.BringToFront();
            editBusinessDefineForm.Show();
        }

        private void EditBusinessDefineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.gridBusinessDefine.DataSource = BusinessTemplateService.GetAll();
            //this.gridBusinessDefine.Refresh();
        }

        private void Init() {
            var dataSource = BusinessTemplateService.GetAll();
            this.gridBusinessDefine.DataSource = dataSource;
            //new Binding()
            //this.gridBusinessDefine.DataBindings.Add("Name", dataSource, "Name");
            //this.gridBusinessDefine.DataBindings.Add("Code", dataSource, "Code");
            //this.gridBusinessDefine.DataBindings.Add("Remark", dataSource, "Remark");
            
        }

        private void btnAddRight_Click(object sender, EventArgs e)
        {
            if (this.gridBusinessDefine.SelectedRows != null && this.gridBusinessDefine.SelectedRows.Count > 0) {
                var row= this.gridBusinessDefine.SelectedRows[0];
                var id=row.Cells["ID"].Value;
                //new EditRightForm
            } 
        }
    }
}
