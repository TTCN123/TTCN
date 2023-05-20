using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class them_sua_SVForms : Form
    {
        private string masv;
        public them_sua_SVForms(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        private void them_sua_SVForms_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ma sinh vien nhan dc la: " + masv);
        }
    }
}
