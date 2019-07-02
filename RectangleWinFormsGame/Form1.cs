using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RectangleWinFormsGame
{
    public partial class Form1 : Form
    {
        static int StartX = 20;
        static int StartY = 20;
        bool KeyReached = false;
        bool GoalReached = false;
        Rectangle PlayerRectangle = new Rectangle(StartX, StartY, 25, 25);
        Rectangle GoalRectangle = new Rectangle(670, 285, 50, 50);
        Rectangle KeyRectangle = new Rectangle(670, 20, 10, 10);
        Pen GoldPen = new Pen(Color.Gold);
        Pen BluePen = new Pen(Color.Blue);
        Pen RedPen = new Pen(Color.Red);

        Rectangle EWall1 = new Rectangle(60, 275, 25, 75);
        Pen LightBlue = new Pen(Color.LightBlue);
        Rectangle EWall2 = new Rectangle(60, 0, 25, 200);
        Rectangle EWall3 = new Rectangle(600, 60, 125, 20);
        Rectangle EWall4 = new Rectangle(550, 150, 20, 125);
        Rectangle PoisonPond = new Rectangle(200, 175, 300, 150);
        Pen Purple = new Pen(Color.Purple);
        Rectangle Spikes = new Rectangle(700, 0, 25, 275);
        Pen White = new Pen(Color.White);
        Rectangle Spikes2 = new Rectangle(175, 100, 350, 25);
        Rectangle Spikes3 = new Rectangle(175, 0, 350, 25);

        

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to my Rectangle WinForms Game.\n" +
            "\nUse the buttons to move the blue rectangle to the red rectangle goal." +
            "\nRemember to avoid obstacles!" +
            "\nYou must get the key(gold rectangle) to enter the goal." +
            "\nEnjoy!");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawRectangle(BluePen, PlayerRectangle);
            g.DrawRectangle(RedPen, GoalRectangle);
            g.DrawRectangle(GoldPen, KeyRectangle);

            g.DrawRectangle(LightBlue, EWall1);
            g.DrawRectangle(LightBlue, EWall2);
            g.DrawRectangle(LightBlue, EWall3);
            g.DrawRectangle(LightBlue, EWall4);
            g.DrawRectangle(Purple, PoisonPond);
            g.DrawRectangle(White, Spikes);
            g.DrawRectangle(White, Spikes2);
            g.DrawRectangle(White, Spikes3);
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            PlayerRectangle.Y += 25;
            RedrawRectangles();
            CheckKey();
            CheckGoal();
            CheckAlive();
        }

        private void RedrawRectangles()
        {
            Graphics g = panel1.CreateGraphics();
            Refresh();
            g.DrawRectangle(BluePen, PlayerRectangle);
            g.DrawRectangle(RedPen, GoalRectangle);
            g.DrawRectangle(GoldPen, KeyRectangle);

            g.DrawRectangle(LightBlue, EWall1);
            g.DrawRectangle(LightBlue, EWall2);
            g.DrawRectangle(LightBlue, EWall3);
            g.DrawRectangle(LightBlue, EWall4);
            g.DrawRectangle(Purple, PoisonPond);
            g.DrawRectangle(White, Spikes);
            g.DrawRectangle(White, Spikes2);
            g.DrawRectangle(White, Spikes3);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            PlayerRectangle.Y -= 25;
            RedrawRectangles();
            CheckKey();
            CheckGoal();
            CheckAlive();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            PlayerRectangle.X -= 25;
            RedrawRectangles();
            CheckKey();
            CheckGoal();
            CheckAlive();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            PlayerRectangle.X += 25;
            RedrawRectangles();
            CheckKey();
            CheckGoal();
            CheckAlive();
        }

        private void CheckAlive()
        {
            if (PlayerRectangle.IntersectsWith(EWall1))
            {
                MessageBox.Show("You were electrocuted to death.");
                Reset();
            }

            if (PlayerRectangle.IntersectsWith(EWall2))
            {
                MessageBox.Show("You were electrocuted to death.");
                Reset();
            }

            if (PlayerRectangle.IntersectsWith(EWall3))
            {
                MessageBox.Show("You were electrocuted to death.");
                Reset();
            }

            if (PlayerRectangle.IntersectsWith(EWall4))
            {
                MessageBox.Show("You were electrocuted to death.");
                Reset();
            }

            if (PlayerRectangle.IntersectsWith(PoisonPond))
            {
                MessageBox.Show("You fell into the poison and died.");
                Reset();
            }

            if (PlayerRectangle.IntersectsWith(Spikes))
            {
                MessageBox.Show("You fell onto some spikes and died.");
                Reset();
            }

            if (PlayerRectangle.IntersectsWith(Spikes2))
            {
                MessageBox.Show("You fell onto some spikes and died.");
                Reset();
            }

            if (PlayerRectangle.IntersectsWith(Spikes3))
            {
                MessageBox.Show("You fell onto some spikes and died.");
            }
        }
        private void CheckGoal()
        {
            if (KeyReached && !GoalReached && PlayerRectangle.IntersectsWith(GoalRectangle))
            {
                GoalReached = true;
                MessageBox.Show("You Win!");
                Reset();
            }
            else if (!KeyReached && !GoalReached && PlayerRectangle.IntersectsWith(GoalRectangle))
            {
                MessageBox.Show("You need a key to open the goal!");
            }
        }

        private void CheckKey()
        {
            if (!KeyReached && PlayerRectangle.IntersectsWith(KeyRectangle))
            {
                KeyReached = true;
                MessageBox.Show("You got the key!");
            }
        }

        private void Reset()
        {
            //key v goes back
            KeyReached = false;
            //player rec goes back
            PlayerRectangle.X = StartX;
            PlayerRectangle.Y = StartY;
            RedrawRectangles();
            //reset goal reached
            GoalReached = false;
        }
    }
}
