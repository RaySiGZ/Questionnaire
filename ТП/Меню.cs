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
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void Меню_Load(object sender, EventArgs e)
        {
            switch (Тема.color)
            {
                case 1:
                    this.BackColor = Color.FromArgb(31, 31, 31);
                    this.ForeColor = Color.FromArgb(240, 240, 240);
                    Начать_Тестирование.BackColor = Color.FromArgb(102, 102, 102);
                    Начать_Тестирование.ForeColor = ForeColor;
                    break;
                case 2:
                    this.BackColor = Color.FromArgb(235, 87, 87);
                    this.ForeColor = Color.FromArgb(255, 255, 255);
                    Начать_Тестирование.BackColor = Color.FromArgb(245, 245, 245);
                    Начать_Тестирование.ForeColor = Color.FromArgb(159, 8, 18);
                    break;
                case 3:
                    this.BackColor = Color.FromArgb(7, 13, 13);
                    this.ForeColor = Color.FromArgb(240, 240, 240);
                    Начать_Тестирование.BackColor = Color.FromArgb(234, 11, 140);
                    Начать_Тестирование.ForeColor = ForeColor;
                    break;
            }
            Посмотреть_результы.BackColor = Начать_Тестирование.BackColor;
            Инструкция_по_использованию.BackColor = Начать_Тестирование.BackColor;
            Настройки.BackColor = Начать_Тестирование.BackColor;
            Посмотреть_результы.ForeColor = Начать_Тестирование.ForeColor;
            Инструкция_по_использованию.ForeColor = Начать_Тестирование.ForeColor;
            Настройки.ForeColor = Начать_Тестирование.ForeColor;
        }

        private void Начать_Тестирование_Click(object sender, EventArgs e)
        {
            Form this_Логин = new Логин();
            Hide();
            this_Логин.Show();
        }

        private void Посмотреть_результы_Click(object sender, EventArgs e)
        {
            Form this_Журнал = new Журнал();
            Hide();
            this_Журнал.ShowDialog();
        }

        private void Инструкция_по_использованию_Click(object sender, EventArgs e)
        {

        }

        private void Настройки_Click(object sender, EventArgs e)
        {
            Form this_Настройки = new Настройки();
            Hide();
            this_Настройки.ShowDialog();
            switch (Тема.color)
            {
                case 0:
                    this.BackColor = Color.FromArgb(238, 238, 238);
                    this.ForeColor = Color.FromArgb(0, 0, 0);
                    Начать_Тестирование.BackColor = Color.FromArgb(224, 224, 224);
                    Начать_Тестирование.ForeColor = ForeColor;
                    break;
                case 1:
                    this.BackColor = Color.FromArgb(31, 31, 31);
                    this.ForeColor = Color.FromArgb(240, 240, 240);
                    Начать_Тестирование.BackColor = Color.FromArgb(102, 102, 102);
                    Начать_Тестирование.ForeColor = ForeColor;
                    break;
                case 2:
                    this.BackColor = Color.FromArgb(235, 87, 87);
                    this.ForeColor = Color.FromArgb(255, 255, 255);
                    Начать_Тестирование.BackColor = Color.FromArgb(245, 245, 245);
                    Начать_Тестирование.ForeColor = Color.FromArgb(159, 8, 18);
                    break;
                case 3:
                    this.BackColor = Color.FromArgb(7, 13, 13);
                    this.ForeColor = Color.FromArgb(240, 240, 240);
                    Начать_Тестирование.BackColor = Color.FromArgb(234, 11, 140);
                    Начать_Тестирование.ForeColor = ForeColor;
                    break;
            }
            Посмотреть_результы.BackColor = Начать_Тестирование.BackColor;
            Инструкция_по_использованию.BackColor = Начать_Тестирование.BackColor;
            Настройки.BackColor = Начать_Тестирование.BackColor;
            Посмотреть_результы.ForeColor = Начать_Тестирование.ForeColor;
            Инструкция_по_использованию.ForeColor = Начать_Тестирование.ForeColor;
            Настройки.ForeColor = Начать_Тестирование.ForeColor;
        }
    }
}
