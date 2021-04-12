using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yacht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int D1R = 0;
        int D2R = 0;
        int D3R = 0;
        int D4R = 0;
        int D5R = 0;

        int D1T = 1;
        int D2T = 1;
        int D3T = 1;
        int D4T = 1;
        int D5T = 1;

        int D1D = 400;
        int D2D = 400;
        int D3D = 400;
        int D4D = 400;
        int D5D = 400;

        bool BA = true;
        bool BD = true;
        bool BT = true;
        bool BFo = true;
        bool BFi = true;
        bool BSi = true;
        bool BC = true;
        bool B4 = true;
        bool BFH = true;
        bool BSS = true;
        bool BLS = true;
        bool BY = true;

        int LR = 3;

        int Score = 0;
        int BonusT = 0;
        bool Bonus = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;

            all_button_disable();
        }

        private void checkJokbo()
        {
            int[] a = { D1T, D2T, D3T, D4T, D5T };
            string fmt = "00";

            int AC = a.Count(n => n == 1);
            int DC = a.Count(n => n == 2);
            int TC = a.Count(n => n == 3);
            int FoC = a.Count(n => n == 4);
            int FiC = a.Count(n => n == 5);
            int SC = a.Count(n => n == 6);

            if (BA)
                label2.Text = a.Count(n => n == 1).ToString(fmt);
            if(BD)
                label3.Text = (a.Count(n => n == 2) * 2).ToString(fmt);
            if(BT)
                label4.Text = (a.Count(n => n == 3) * 3).ToString(fmt);
            if(BFo)
                label5.Text = (a.Count(n => n == 4) * 4).ToString(fmt);
            if(BFi)
                label6.Text = (a.Count(n => n == 5) * 5).ToString(fmt);
            if(BSi)
                label7.Text = (a.Count(n => n == 6) * 6).ToString(fmt);
            if(BC)
                label8.Text = (a[0] + a[1] + a[2] + a[3] + a[4]).ToString(fmt);
            if (B4)
            {
                if ((AC >= 4) || (DC >= 4) || (TC >= 4) || (FoC >= 4) || (FiC >= 4) || (SC >= 4))
                    label9.Text = (a[0] + a[1] + a[2] + a[3] + a[4]).ToString(fmt);
                else
                    label9.Text = "00";
            }
            if (BFH)
            {
                if (((AC == 3) || (DC == 3) || (TC == 3) || (FoC == 3) || (FiC == 3) || (SC == 3)) && ((AC == 2) || (DC == 2) || (TC == 2) || (FoC == 2) || (FiC == 2) || (SC == 2)))
                    label10.Text = (a[0] + a[1] + a[2] + a[3] + a[4]).ToString(fmt);
                else
                    label10.Text = "00";
            }
            if (BSS)
            {
                if (((AC >= 1) && (DC >= 1) && (TC >= 1) && (FoC >= 1)) || ((DC >= 1) && (TC >= 1) && (FoC >= 1) && (FiC >= 1)) || ((TC >= 1) && (FoC >= 1) && (FiC >= 1) && (SC >= 1)))
                    label11.Text = 15.ToString(fmt);
                else
                    label11.Text = "00";
            }
            if (BLS)
            {
                if (((AC == 1) && (DC == 1) && (TC == 1) && (FoC == 1) && (FiC == 1)) || ((DC == 1) && (TC == 1) && (FoC == 1) && (FiC == 1) && (SC == 1)))
                    label12.Text = 30.ToString(fmt);
                else
                    label12.Text = "00";
            }
            if (BY)
            {
                if ((AC == 5) || (DC == 5) || (TC == 5) || (FoC == 5) || (FiC == 5) || (SC == 5))
                    label13.Text = 50.ToString(fmt);
                else
                    label13.Text = "00";
            }
        }

        private void all_button_disable()
        {
            button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = button13.Enabled = false;
        }
        private void button_activate()
        {
            button2.Enabled = BA;
            button3.Enabled = BD;
            button4.Enabled = BT;
            button5.Enabled = BFo;
            button6.Enabled = BFi;
            button7.Enabled = BSi;
            button8.Enabled = BC;
            button9.Enabled = B4;
            button10.Enabled = BFH;
            button11.Enabled = BSS;
            button12.Enabled = BLS;
            button13.Enabled = BY;
        }

        void label_empty()
        {
            if (BA)
                label2.Text = "00";
            if (BD)
                label3.Text = "00";
            if (BT)
                label4.Text = "00";
            if (BFo)
                label5.Text = "00";
            if (BFi)
                label6.Text = "00";
            if (BSi)
                label7.Text = "00";
            if (BC)
                label8.Text = "00";
            if (B4)
                label9.Text = "00";
            if (BFH)
                label10.Text = "00";
            if (BSS)
                label11.Text = "00";
            if (BLS)
                label12.Text = "00";
            if (BY)
                label13.Text = "00";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;



            Random a = new Random();
            if (LR != 0)
            {
                if (LR == 3)
                {
                    label_empty();
                }
                button1.Enabled = false;
                all_button_disable();
                timer6.Start();
                LR--;
                label1.Text = "Left Rolls : " + LR;
                if (!checkBox1.Checked)
                {
                    D1T = 1;
                    D1R = a.Next(6, 18);
                    //D1R = 6 + 3;
                    timer1.Interval = a.Next(100, 150);
                    timer1.Start();
                }
                if (!checkBox2.Checked)
                {
                    D2T = 1;
                    D2R = a.Next(6, 18);
                    //D2R = 6 + 5;
                    timer2.Interval = a.Next(100, 150);
                    timer2.Start();
                }
                if (!checkBox3.Checked)
                {
                    D3T = 1;
                    D3R = a.Next(6, 18);
                    //D3R = 6 + 4;
                    timer3.Interval = a.Next(100, 150);
                    timer3.Start();
                }
                if (!checkBox4.Checked)
                {
                    D4T = 1;
                    D4R = a.Next(6, 18);
                    //D4R = 6 + 2;
                    timer4.Interval = a.Next(100, 150);
                    timer4.Start();
                }
                if (!checkBox5.Checked)
                {
                    D5T = 1;
                    D5R = a.Next(6, 18);
                    timer5.Interval = a.Next(100, 150);
                    timer5.Start();
                }

                
            }
            
        }

        private void DiceRoll(ref int DR, ref int DT, ref Timer targetT, ref PictureBox targetPB)
        {
            if (DR == 0)
            {
                targetT.Stop();
                return;
            }

            if (DT == 6)
                DT = 1;
            else
                DT++;

            switch (DT)
            {
                case 1:
                    targetPB.BackgroundImage = Properties.Resources.dice_1;
                    break;
                case 2:
                    targetPB.BackgroundImage = Properties.Resources.dice_2;
                    break;
                case 3:
                    targetPB.BackgroundImage = Properties.Resources.dice_3;
                    break;
                case 4:
                    targetPB.BackgroundImage = Properties.Resources.dice_4;
                    break;
                case 5:
                    targetPB.BackgroundImage = Properties.Resources.dice_5;
                    break;
                case 6:
                    targetPB.BackgroundImage = Properties.Resources.dice_6;
                    break;
            }

            DR--;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiceRoll(ref D1R, ref D1T, ref timer1, ref pictureBox1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DiceRoll(ref D2R, ref D2T, ref timer2, ref pictureBox2);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            DiceRoll(ref D3R, ref D3T, ref timer3, ref pictureBox3);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            DiceRoll(ref D4R, ref D4T, ref timer4, ref pictureBox4);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            DiceRoll(ref D5R, ref D5T, ref timer5, ref pictureBox5);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if(D1R == 0 && D2R == 0 && D3R == 0 && D4R == 0 && D5R == 0)
            {
                if (LR !=0)
                    button1.Enabled = true;
                timer6.Stop();
                button_activate();
                MessageBox.Show(D1T + ", " + D2T + ", " + D3T + ", " + D4T + ", " + D5T);
                checkJokbo();
            }
        }

        private void buttons_Click(bool isBonus, ref Label l, ref bool b)
        {
            LR = 3;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;

            button1.Enabled = true;

            label1.Text = "Left Rolls : 3";

            Score += int.Parse(l.Text);
            label15.Text = "Score : " + Score.ToString();
            if (isBonus)
            {
                if (!Bonus)
                {
                    BonusT += int.Parse(l.Text);
                    label14.Text = "Bonus : " + BonusT + " / 63";
                    if (BonusT >= 63)
                    {
                        label14.Text = "Bonus : Get!";
                        Bonus = true;
                    }

                }
            }
            b = false;
            all_button_disable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttons_Click(true, ref label2, ref BA);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttons_Click(true, ref label3, ref BD);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttons_Click(true, ref label4, ref BT);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttons_Click(true, ref label5, ref BFo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttons_Click(true, ref label6, ref BFi);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttons_Click(true, ref label7, ref BSi);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttons_Click(false, ref label8, ref BC);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttons_Click(false, ref label9, ref B4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttons_Click(false, ref label10, ref BFH);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttons_Click(false, ref label11, ref BSS);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttons_Click(false, ref label12, ref BLS);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttons_Click(false, ref label13, ref BY);
        }
    }
}
