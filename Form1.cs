﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        int speed;
        int movex;
        int movey;
        public Form1()
        {
            InitializeComponent();
            speed = 3;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pictureBox1.Top -= speed;
            movey = -speed;
            movex = 0;
            //this.timer1_Tick();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //pictureBox1.Top += speed;
            movey = speed;
            movex = 0;
            //this.timer1_Tick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pictureBox1.Left += speed;
            movex = speed;
            movey = 0;
            //this.timer1_Tick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //pictureBox1.Left -= speed;
            movex = -speed;
            movey = 0;
           // this.timer1_Tick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += movex;
            pictureBox1.Top += movey;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                movey = -speed;
                //movex = 0;
            }else if (e.KeyCode == Keys.Down)
            {
                movey = speed;
                //movex = 0;
            }else if (e.KeyCode == Keys.Right)
            {
                movex = speed;
                //movey = 0;
            }else if (e.KeyCode == Keys.Left)
            {
                movex = -speed;
                //movey = 0;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                movey = 0;
                //movex = 0;
            }
            else if (e.KeyCode == Keys.Down)
            {
                movey = 0;
                //movex = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                movex = 0;
                //movey = 0;
            }
            else if (e.KeyCode == Keys.Left)
            {
                movex = 0;
                //movey = 0;
            }
        }
    }
}
