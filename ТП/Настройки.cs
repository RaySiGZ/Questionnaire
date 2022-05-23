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
    public partial class Настройки : Form
    {
        public Настройки()
        {
            InitializeComponent();
        }

        private void Настройки_Load(object sender, EventArgs e)
        {
            switch (Тема.color)
            {
                case 1:
                    this.BackColor = Color.FromArgb(31, 31, 31);
                    this.ForeColor = Color.FromArgb(220, 220, 220);
                    Светлая_тема.BackColor = Color.FromArgb(102, 102, 102);
                    break;
                case 2:
                    this.BackColor = Color.FromArgb(235, 87, 87);
                    this.ForeColor = Color.FromArgb(159, 8, 18);
                    Светлая_тема.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 3:
                    this.BackColor = Color.FromArgb(7, 13, 13);
                    this.ForeColor = Color.FromArgb(240, 240, 240);
                    Светлая_тема.BackColor = Color.FromArgb(234, 11, 140);
                    break;
            }
            Темная_тема.BackColor = Светлая_тема.BackColor;
            Черно_розовая_тема.BackColor = Светлая_тема.BackColor;
            Красно_белая_тема.BackColor = Светлая_тема.BackColor;
            Назад.BackColor = Светлая_тема.BackColor;
        }

        private void Светлая_тема_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(238, 238, 238);
            this.ForeColor = Color.FromArgb(0, 0, 0);
            Светлая_тема.BackColor = Color.FromArgb(224, 224, 224);
            Темная_тема.BackColor = Светлая_тема.BackColor;
            Черно_розовая_тема.BackColor = Светлая_тема.BackColor;
            Красно_белая_тема.BackColor = Светлая_тема.BackColor;
            Назад.BackColor = Светлая_тема.BackColor;
            Тема.color = 0;
        }

        private void Темная_тема_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(31, 31, 31);
            this.ForeColor = Color.FromArgb(220, 220, 220);
            Светлая_тема.BackColor = Color.FromArgb(102, 102, 102);
            Темная_тема.BackColor = Светлая_тема.BackColor;
            Черно_розовая_тема.BackColor = Светлая_тема.BackColor;
            Красно_белая_тема.BackColor = Светлая_тема.BackColor;
            Назад.BackColor = Светлая_тема.BackColor;
            Тема.color = 1;
        }

        private void Красно_белая_тема_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(235, 87, 87);
            this.ForeColor = Color.FromArgb(107, 15, 36);
            Светлая_тема.BackColor = Color.FromArgb(255, 255, 255);
            Темная_тема.BackColor = Светлая_тема.BackColor;
            Черно_розовая_тема.BackColor = Светлая_тема.BackColor;
            Красно_белая_тема.BackColor = Светлая_тема.BackColor;
            Назад.BackColor = Светлая_тема.BackColor;
            Тема.color = 2;
        }

        private void Черно_розовая_тема_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(7, 13, 13);
            this.ForeColor = Color.FromArgb(240, 240, 240);
            Светлая_тема.BackColor = Color.FromArgb(234, 11, 140);
            Темная_тема.BackColor = Светлая_тема.BackColor;
            Черно_розовая_тема.BackColor = Светлая_тема.BackColor;
            Красно_белая_тема.BackColor = Светлая_тема.BackColor;
            Назад.BackColor = Светлая_тема.BackColor;
            Тема.color = 3;
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Настройки_Close(object sender, FormClosingEventArgs e)
        {
            Form this_Меню = Application.OpenForms[0];
            this_Меню.Show();
        }
    }
}