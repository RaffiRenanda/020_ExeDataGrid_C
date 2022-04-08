using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe1PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==3)
            {
                e.CellStyle.ForeColor=Color.Aqua;
                e.CellStyle.SelectionBackColor = Color.Blue;
                e.CellStyle.BackColor = Color.Gray;
            }
            else if (e.ColumnIndex == 0)
            {
                e.CellStyle.ForeColor = Color.DeepPink;
                e.CellStyle.SelectionBackColor = Color.HotPink;
            }
            else if (e.ColumnIndex == 1)
            {
                e.CellStyle.ForeColor = Color.Blue;
                e.CellStyle.SelectionBackColor = Color.Orange;
                e.CellStyle.BackColor = Color.Gray;
            }
            else if (e.ColumnIndex == 2)
            {
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.SelectionBackColor = Color.Green;
            }
            else if(e.ColumnIndex == 4)
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.SelectionBackColor = Color.Maroon;
            }
            else
            {
                e.CellStyle.ForeColor = Color.Black;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
