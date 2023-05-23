namespace QLSV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var db = new Database();
            dgvdata.DataSource = db.SelectData(null);
        }
    }
}