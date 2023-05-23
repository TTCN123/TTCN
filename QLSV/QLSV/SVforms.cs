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
    public partial class SVforms : Form
    {
        public SVforms()
        {
            InitializeComponent();
        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
               var masv = dgvSV.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
                new them_sua_SVForms(masv).ShowDialog();
            }
        }

        private void SVforms_Load(object sender, EventArgs e)
        {
            dgvSV.DataSource = new Database().SelectData("exec SelectAllSinhVien");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            new them_sua_SVForms(null).ShowDialog();
        }
    }
}
