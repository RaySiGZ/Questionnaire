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
    public partial class Логин : Form
    {
        public Логин()
        {
            InitializeComponent();
        }

        private void Логин_Load(object sender, EventArgs e)
        {
            switch (Тема.color)
            {
                case 1:
                    this.BackColor = Color.FromArgb(31, 31, 31);
                    this.ForeColor = Color.FromArgb(220, 220, 220);
                    Фамилия_ввод.BackColor = Color.FromArgb(230, 230, 230);
                    Ввод.BackColor = Color.FromArgb(102, 102, 102);
                    break;
                case 2:
                    this.BackColor = Color.FromArgb(235, 87, 87);
                    this.ForeColor = Color.FromArgb(255, 255, 255);
                    Ввод.BackColor = Color.FromArgb(245, 245, 245);
                    Ввод.ForeColor = Color.FromArgb(159, 8, 18);
                    Назад.ForeColor = Ввод.ForeColor;
                    break;
                case 3:
                    this.BackColor = Color.FromArgb(7, 13, 13);
                    this.ForeColor = Color.FromArgb(240, 240, 240);
                    Фамилия_ввод.BackColor = Color.FromArgb(230, 230, 230);
                    Ввод.BackColor = Color.FromArgb(234, 11, 140);
                    break;
            }
            Имя_ввод.BackColor = Фамилия_ввод.BackColor;
            Назад.BackColor = Ввод.BackColor;
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ввод_Click(object sender, EventArgs e)
        {
            Form this_ТестА= new Тест_частьА();
            this_ТестА.Show();
            Hide();
        }

        private void Логин_Close(object sender, FormClosingEventArgs e)
        {
            Form this_Меню = Application.OpenForms[0];
            this_Меню.Show();
        }
    }
}
