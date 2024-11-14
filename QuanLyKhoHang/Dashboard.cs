using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tìmKiếmVàLọcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView taskDataGridView = new DataGridView();
            taskDataGridView.Location = new Point(10, 10);
            taskDataGridView.Size = new Size(600, 200);
            taskDataGridView.Columns.Add("TaskName", "Task Name");
            taskDataGridView.Columns.Add("Owner", "Owner");
            taskDataGridView.Columns.Add("Status", "Status");
            taskDataGridView.Columns.Add("StartDate", "Start Date");
            taskDataGridView.Columns.Add("CompletionDate", "Completion Date");
            taskDataGridView.Columns.Add("Days", "Days");
            grbQuanLySanPham.Controls.Add(taskDataGridView);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView taskDataGridView = new DataGridView
            {
                Location = new Point(10, 10),
                Size = new Size(600, 200)
            };
            taskDataGridView.Columns.Add("TaskName", "Task Name");
            taskDataGridView.Columns.Add("Owner", "Owner");
            taskDataGridView.Columns.Add("Status", "Status");
            taskDataGridView.Columns.Add("StartDate", "Start Date");
            taskDataGridView.Columns.Add("CompletionDate", "Completion Date");
            taskDataGridView.Columns.Add("Days", "Days");
            grbQuanLySanPham.Controls.Add(taskDataGridView);
        }
    }
}
