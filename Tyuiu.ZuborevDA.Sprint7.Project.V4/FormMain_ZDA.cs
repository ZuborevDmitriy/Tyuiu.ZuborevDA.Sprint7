using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ZuborevDA.Sprint7.Project.V4
{
    public partial class FormMain_ZDA : Form
    {
        public FormMain_ZDA()
        {
            InitializeComponent();
        }

        private void buttonInfo_ZDA_Click(object sender, EventArgs e)
        {
            FormAbout_ZDA formAbout_ZDA = new FormAbout_ZDA();
            formAbout_ZDA.ShowDialog();
        }

        private void buttonBaza_ZDA_Click(object sender, EventArgs e)
        {
            FormDataBase_ZDA formDataBase_ZDA = new FormDataBase_ZDA();
            formDataBase_ZDA.ShowDialog();
        }

        private void buttonHelp_ZDA_Click(object sender, EventArgs e)
        {
            FormInfo_ZDA formInfo_ZDA = new FormInfo_ZDA();
            formInfo_ZDA.ShowDialog();
        }
    }
}
