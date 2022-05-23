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
    public partial class Тест_частьА : Form
    {
        private bool[] ans_acc = new bool[] { false, false, false, false, false, false, false, false, false, false };
        private int ans_access = 0;
        private int ans_choice;
        private int ques_choice = 0;
        private Color[] backColor = new Color[10];

        public Тест_частьА()
        {
            InitializeComponent();
        }

        private void Тест_частьА_Load(object sender, EventArgs e)
        {
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            switch (Тема.color)
            {
                case 1:
                    this.BackColor = Color.FromArgb(31, 31, 31);
                    this.ForeColor = Color.FromArgb(220, 220, 220);
                    button11.BackColor = Color.FromArgb(102, 102, 102);
                    break;
                case 2:
                    this.BackColor = Color.FromArgb(235, 87, 87);
                    this.ForeColor = Color.FromArgb(255, 255, 255);
                    button11.BackColor = Color.FromArgb(255, 255, 255);
                    Назад.BackColor = button11.BackColor;
                    Ответить.BackColor = button11.BackColor;
                    Далее.BackColor = button11.BackColor;
                    button11.ForeColor = Color.FromArgb(159, 8, 18);
                    Назад.ForeColor = button11.ForeColor;
                    Ответить.ForeColor = button11.ForeColor;
                    Далее.ForeColor = button11.ForeColor;
                    break;
                case 3:
                    this.BackColor = Color.FromArgb(7, 13, 13);
                    this.ForeColor = Color.FromArgb(234, 11, 140);
                    button11.BackColor = Color.FromArgb(234, 11, 140);
                    Назад.BackColor = button11.BackColor;
                    Ответить.BackColor = button11.BackColor;
                    Далее.BackColor = button11.BackColor;
                    button11.ForeColor = Color.FromArgb(240, 240, 240);
                    Назад.ForeColor = button11.ForeColor;
                    Ответить.ForeColor = button11.ForeColor;
                    Далее.ForeColor = button11.ForeColor;
                    break;
            }
            Ответ1.BackColor = BackColor;
            Ответ2.BackColor = BackColor;
            Ответ3.BackColor = BackColor;
            Ответ4.BackColor = BackColor;
            Назад.BackColor = button11.BackColor;
            Ответить.BackColor = button11.BackColor;
            Далее.BackColor = button11.BackColor;
            for (int i = 0; i < 5; i++)
            {
                backColor[i] = Назад.BackColor; 
                buttons[i].ForeColor = button11.ForeColor;
                buttons[i].BackColor = Назад.BackColor;
                backColor[i+5] = Назад.BackColor;
                buttons[i+5].ForeColor = button11.ForeColor;
                buttons[i+5].BackColor = Назад.BackColor;
            }
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            ques_choice = 0;
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            ques_choice = 1;
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void yt_Button3_Click(object sender, EventArgs e)
        {
            ques_choice = 2;
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            ques_choice = 3;
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void yt_Button5_Click(object sender, EventArgs e)
        {
            ques_choice = 4;
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void yt_Button6_Click(object sender, EventArgs e)
        {
            ques_choice = 5;
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void yt_Button7_Click(object sender, EventArgs e)
        {
            ques_choice = 6;
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void yt_Button8_Click(object sender, EventArgs e)
        {
            ques_choice = 7;
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void yt_Button9_Click(object sender, EventArgs e)
        {
            ques_choice = 8;
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void yt_Button10_Click(object sender, EventArgs e)
        {
            ques_choice = 9;
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Ответ1_CheckedChanged(object sender, EventArgs e)
        {
            ans_choice = 1;
        }

        private void Ответ2_CheckedChanged(object sender, EventArgs e)
        {
            ans_choice = 2;
        }

        private void Ответ3_CheckedChanged(object sender, EventArgs e)
        {
            ans_choice = 3;
        }

        private void Ответ4_CheckedChanged(object sender, EventArgs e)
        {
            ans_choice = 4;
        }

        private void Далее_Click(object sender, EventArgs e)
        {
            Form this_ТестВ = new Тест_частьВ();
            this_ТестВ.Show();
            Hide();
            if (ans_access == 10)
            {
            }
        }

        private void Ответить_Click(object sender, EventArgs e)
        {
            switch (ques_choice)
            {
                case 0:
                    if (ans_acc[ques_choice]) break;
                    ans_acc[ques_choice] = true;
                    backColor[ques_choice] = (ans_choice == 1) ? Color.FromArgb(111, 207, 151): Color.FromArgb(228, 0, 43);
                    ans_access++;
                    break;
                case 1:
                    if (ans_acc[ques_choice]) break;
                    ans_acc[ques_choice] = true;
                    backColor[ques_choice] = (ans_choice == 1) ? Color.FromArgb(111, 207, 151) : Color.FromArgb(228, 0, 43);
                    ans_access++;
                    break;
                case 2:
                    if (ans_acc[ques_choice]) break;
                    ans_acc[ques_choice] = true;
                    backColor[ques_choice] = (ans_choice == 1) ? Color.FromArgb(111, 207, 151) : Color.FromArgb(228, 0, 43);
                    ans_access++;
                    break;
                case 3:
                    if (ans_acc[ques_choice]) break;
                    ans_acc[ques_choice] = true;
                    backColor[ques_choice] = (ans_choice == 1) ? Color.FromArgb(111, 207, 151) : Color.FromArgb(228, 0, 43);
                    ans_access++;
                    break;
                case 4:
                    if (ans_acc[ques_choice]) break;
                    ans_acc[ques_choice] = true;
                    backColor[ques_choice] = (ans_choice == 1) ? Color.FromArgb(111, 207, 151) : Color.FromArgb(228, 0, 43);
                    ans_access++;
                    break;
                case 5:
                    if (ans_acc[ques_choice]) break;
                    ans_acc[ques_choice] = true;
                    backColor[ques_choice] = (ans_choice == 1) ? Color.FromArgb(111, 207, 151) : Color.FromArgb(228, 0, 43);
                    ans_access++;
                    break;
                case 6:
                    if (ans_acc[ques_choice]) break;
                    ans_acc[ques_choice] = true;
                    backColor[ques_choice] = (ans_choice == 1) ? Color.FromArgb(111, 207, 151) : Color.FromArgb(228, 0, 43);
                    ans_access++;
                    break;
                case 7:
                    if (ans_acc[ques_choice]) break;
                    ans_acc[ques_choice] = true;
                    backColor[ques_choice] = (ans_choice == 1) ? Color.FromArgb(111, 207, 151) : Color.FromArgb(228, 0, 43);
                    ans_access++;
                    break;
                case 8:
                    if (ans_acc[ques_choice]) break;
                    ans_acc[ques_choice] = true;
                    backColor[ques_choice] = (ans_choice == 1) ? Color.FromArgb(111, 207, 151) : Color.FromArgb(228, 0, 43);
                    ans_access++;
                    break;
                case 9:
                    if (ans_acc[ques_choice]) break;
                    ans_acc[ques_choice] = true;
                    backColor[ques_choice] = (ans_choice == 1) ? Color.FromArgb(111, 207, 151) : Color.FromArgb(228, 0, 43);
                    ans_access++;
                    break;
            }
            Button[] buttons = new Button[] { yt_Button1, yt_Button2, yt_Button3, yt_Button4, yt_Button5, yt_Button6, yt_Button7, yt_Button8, yt_Button9, yt_Button10 };
            for (int i = 0; i < 10; i++) buttons[i].BackColor = backColor[i];
            buttons[ques_choice].BackColor = Color.FromArgb(150, backColor[ques_choice]);
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            if (ques_choice == 0) Close();
        }

        private void Тест_частьА_Close(object sender, FormClosingEventArgs e)
        {
            Form this_Логин = Application.OpenForms[1];
            this_Логин.Show();
        }
    }
}
