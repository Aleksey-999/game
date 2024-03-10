using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaWar
{
    public partial class FormGame : Form
    {
        List<int> myListYou = new List<int>();
        List<int> myListRobots = new List<int>();
        List<int> ListRobots = new List<int>();
        int num = 0;
        int v1, k;
        Random rnd = new Random();
        int n = 0;
        int chislo;
        int p1=0, p2=0;
        int b = 10;
        public FormGame()
        {
            InitializeComponent();
            btnAnew.Enabled = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            int n2 = 0;
            pnlYou.Controls.Clear();
            pnlRobots.Controls.Clear();
            int x1 = 0, y1 = 0;
            int x2 = 0, y2 = 0;
            myListYou.Clear();
            pnlRobots.Enabled = false;
            for (int i1 = 1; i1 <= 10; i1++)
            {
                for (int k1 = 1; k1 <= 10; k1++)
                {
                    Button btn = new Button(); /*Создание поля противника*/
                    n1++;
                    btn.Tag = n1;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Left = x1;
                    btn.Top = y1;
                    pnlYou.Controls.Add(btn);
                    x1 += 30;
                    btn.Click += this.pnlYou_Click;
                }
                x1 = 0;
                y1 += 30;
            }
            for (int i2 = 1; i2 <= 10; i2++)
            {
                for (int k2 = 1; k2 <= 10; k2++)
                {
                   
                    Button btn = new Button(); n2++;/* Создание вашего поля*/
                    btn.Tag = n2;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Left = x2;
                    btn.Top = y2;
                    pnlRobots.Controls.Add(btn);
                    x2 += 30;
                    btn.Click += this.PnlRobots_Click;
                  
                }
                x2 = 0;
                y2 += 30;

            }
            lbl3.Visible = true;
            lbl3.Text = "Расставьте корабли";
        }

        private void Lbl3_Click(object sender, EventArgs e)
        {

        }



        private void pnlYou_Click(object sender, EventArgs e)
        {
            b--;
            n++;/* Расстановка ваших кораблей*/
            Button btn = (Button)sender;
            num = Convert.ToInt32(btn.Tag);
            btn.Image = Properties.Resources.ship;
            myListYou.Add(num);
            MessageBox.Show("Осталось расставить " + b.ToString() + " кораблей");
            if (n == 10) /*Создание ограничения на количество расставляемых кораблей*/
            {
                lbl3.Text = "Расстановка окончена!";
                pnlYou.Enabled = false;
                pnlRobots.Enabled = true;
                k = 0;
            }
        }

        private void LblItog2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStart frm; /*Переход со второй формы на первую*/
            frm = new FormStart();
            frm.ShowDialog();
            frm.Dispose();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myListRobots.Clear();
            ListRobots.Clear();
            int N = 10;
            for (int i = 1; i <= N; i++) /*Создание неповторяющихся элементов списка*/
            {
                do
                {
                    chislo = rnd.Next(1, 100);
                } while (myListRobots.Contains(chislo));
                myListRobots.Add(chislo);
            }
            for (int i = 1; i <= 100; i++)
            {
                ListRobots.Add(i);
            }
            int count = 100;
            for (int i = 0; i < count; i++)
            {
                int x1 = rnd.Next(count - 1);
                int x2 = rnd.Next(count - 1);
                int x3 = (int)ListRobots[x1];
                ListRobots[x1] = ListRobots[x2];
                ListRobots[x2] = x3;
            }
            
        }


        private void PnlRobots_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int number = Convert.ToInt32(btn.Tag);
            if (myListRobots.Contains(number)) /*Создание ваших выстрелов*/
            {
                btn.Image = Properties.Resources.popadanie;
                p1++;
            }
            else
            {
                btn.Image = Properties.Resources.krest;
            }
            v1 = Convert.ToInt32(ListRobots[k]);
            foreach (Button b in pnlYou.Controls) /*Создание выстрелов противника*/
            {
                int v = Convert.ToInt32(b.Tag);
                if (myListYou.Contains(v1) && (v1 == v))
                {

                    b.Image = Properties.Resources.popadanie;
                    p2++;
                }
                else
                {
                    if (v1 == v)
                    {
                        b.Image = Properties.Resources.krest;
                    }
                }
            }
            k++; /*создание счетчика для подсчета очков*/
            lbl1.Visible = true;
            lblItog1.Visible = true;
            lblItog2.Visible = true;
            lblItog1.Text = p1.ToString();
            lblItog2.Text = p2.ToString();
            lbl1.Text = ":";
            if (p1==10)
            {
                lbl3.Text = "Конец игры!Вы победили!";
                MessageBox.Show("Конец игры!Вы победили!");
                pnlRobots.Enabled = false;
                pnlYou.Enabled = false;
                btnStart.Enabled = false;
                btnAnew.Enabled = true;
            }
            if (p2 == 10)
            {
                lbl3.Text = "Конец игры!Вы проиграли!";
               MessageBox.Show("Конец игры!Вы проиграли!");
                pnlRobots.Enabled = false;
                pnlYou.Enabled = false;
                btnStart.Enabled = false;
                btnAnew.Enabled = true;
            }
        }
    }
}    




    

