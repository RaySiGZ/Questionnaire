using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТП
{
    public partial class Журнал : Form
    {
        public Журнал()
        {
            InitializeComponent();
        }

        private void Журнал_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Игорь" + ' ' + "Во", "100/20", "10000"); 
            dataGridView1.Rows.Add("Игорь" + ' ' + "НеВо", "7/20", "3.5"); 
            switch (Тема.color)
            {
                case 1:
                    BackColor = Color.FromArgb(31, 31, 31);
                    ForeColor = Color.FromArgb(220, 220, 220);
                    Выбрать.BackColor = Color.FromArgb(102, 102, 102);
                    break;
                case 2:
                    BackColor = Color.FromArgb(235, 87, 87);
                    ForeColor = Color.FromArgb(159, 8, 18);
                    Выбрать.BackColor = Color.FromArgb(245, 245, 245);
                    break;
                case 3:
                    BackColor = Color.FromArgb(7, 13, 13);
                    ForeColor = Color.FromArgb(240, 240, 240);
                    Выбрать.BackColor = Color.FromArgb(234, 11, 140);
                    break;
            }
            Назад.BackColor = Выбрать.BackColor;
            dataGridView1.RowsDefaultCellStyle.BackColor = Выбрать.BackColor;
            dataGridView1.BackgroundColor = BackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = ForeColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = dataGridView1.RowsDefaultCellStyle.BackColor;
        }

        private void Выбрать_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            Console.WriteLine(dataGridView1.Rows[index].Cells[0].Value.ToString());
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Журнал_Close(object sender, FormClosingEventArgs e)
        {
            Form this_Меню = Application.OpenForms[0];
            this_Меню.Show();
        }
    }
}
