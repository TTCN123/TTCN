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
            if (string.IsNullOrEmpty(masv)) this.Text = "Thêm Mới Sinh Viên";
            else
            {
                this.Text = "Cập Nhật Thông Tin Sinh Viên";
                var r = new Database().Select("selectSV '"+masv+"'");

                txt_ho.Text = r["Ho"].ToString();
                txt_tendem.Text = r["TenDem"].ToString();
                txt_ten.Text = r["Ten"].ToString() ;
                txt_ngaysinh.Text = r["NgaySinh"].ToString();
                if (r["GioiTinh"].ToString() == "Nam")
                {
                    rb_nam.Checked =true;
                }else { rb_nu.Checked =true;}
                txt_diachi.Text = r["DiaChi"].ToString();
                txt_dienthoai.Text = r["DienThoai"].ToString();
                txt_email.Text = r["Email"].ToString();

            }
        }
    }
}
