using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9_Snake
{
    public partial class Form1 : Form
    {
        Rectangle rect = new Rectangle(0, 0, 20, 20);
        
        int x = 20;
        int y = 20;
        int xy = 0;
        int incret;

        int timertick;
        int colourChoice = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();
            timertick++;

            if (xy == 1)
            {
                x = x + incret;
            }

            else if (xy == 2)
            {
                y = y + incret;
            }

            DrawIt(x, y);
        }

        private void DrawIt(int x, int y)
        {
            int[] snake;
            int currentPosX = 1;
            int currentPosY = 1;
            int lastPosX;
            int lastPosY;

                
            System.Drawing.Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.Teal);
            graphics.FillRectangle(new SolidBrush(Color.Red), rect);

            

            for (int i = 0; i <= 2; i++)
            {
                if (i == 1)
                {
                    currentPosX = rect.X;
                    currentPosY = rect.Y;
                    rect.X = x;
                    rect.Y = y;
                }
                else
                {
                    graphics.FillRectangle(new SolidBrush(Color.Yellow), currentPosX, currentPosY, 20,20);
                }

            }





        }

      

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {


                incret = +20;
                xy = 2;


            }
            if (e.KeyCode == Keys.Up)
            {

                incret = -20;
                xy = 2;

            }
            if (e.KeyCode == Keys.Left)
            {


                incret = -20;
                xy = 1;

            }
            if (e.KeyCode == Keys.Right)
            {


                incret = +20;
                xy = 1;

            }

        }

       
    }
}
