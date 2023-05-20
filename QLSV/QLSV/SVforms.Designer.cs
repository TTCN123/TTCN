namespace QLSV
{
    partial class SVforms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSV = new DataGridView();
            label1 = new Label();
            txt_search = new TextBox();
            btn_search = new Button();
            btn_them = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSV).BeginInit();
            SuspendLayout();
            // 
            // dgvSV
            // 
            dgvSV.AllowUserToAddRows = false;
            dgvSV.AllowUserToDeleteRows = false;
            dgvSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSV.Dock = DockStyle.Bottom;
            dgvSV.Location = new Point(0, 115);
            dgvSV.MultiSelect = false;
            dgvSV.Name = "dgvSV";
            dgvSV.ReadOnly = true;
            dgvSV.RowTemplate.Height = 25;
            dgvSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSV.Size = new Size(896, 335);
            dgvSV.TabIndex = 0;
            dgvSV.CellContentClick += dgvSV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 46);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Từ khóa";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(497, 43);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(199, 23);
            txt_search.TabIndex = 2;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(711, 43);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(75, 23);
            btn_search.TabIndex = 3;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(792, 43);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(75, 23);
            btn_them.TabIndex = 4;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // SVforms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 450);
            Controls.Add(btn_them);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(label1);
            Controls.Add(dgvSV);
            Name = "SVforms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DSSV";
            Load += SVforms_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSV;
        private Label label1;
        private TextBox txt_search;
        private Button btn_search;
        private Button btn_them;
    }
}