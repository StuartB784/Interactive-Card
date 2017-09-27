using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace Interactive_Card
{
    public partial class InteractiveCard : Form
    {
        public InteractiveCard()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //Setting Pen and brush
            Pen drawPen = new Pen(Color.White, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            BackgroundImage = null; //Clear screen
            Refresh();
            ScutumTitle.Visible = false;
            Refresh();
            Scutum.Visible = false;
            Refresh();

            formGraphics.FillEllipse(drawBrush, 25, 25, 10, 10); //Draw Constellation
            SoundPlayer player = new SoundPlayer(Properties.Resources.Ding);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 45, 115, 10, 10);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 100, 115, 10, 10);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 50, 135, 10, 10);
            player.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 120, 265, 10, 10);
            player.Play();
            Thread.Sleep(1000);

            formGraphics.FillEllipse(drawBrush, 250, 152, 2, 2); //Random Stars
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 60, 143, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 345, 380, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 95, 200, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 23, 234, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 274, 97, 2, 2); 
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 21, 346, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 321, 380, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 290, 200, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 170, 234, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 250, 50, 2, 2); 
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 60, 190, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 345, 330, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 95, 295, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 23, 140, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 120, 50, 2, 2); 
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 143, 190, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 100, 110, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 95, 130, 2, 2);
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 60, 130, 2, 2);
            Thread.Sleep(100);

            Pen drawPen1 = new Pen(Color.Teal, 3); //Change pen color
            drawBrush.Color = Color.Teal;

            formGraphics.FillEllipse(drawBrush, 25, 25, 10, 10); //Re-Draw Constellation
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 45, 115, 10, 10);
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 100, 115, 10, 10);
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 50, 135, 10, 10);
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 120, 265, 10, 10);
            Thread.Sleep(350);

            formGraphics.DrawLine(drawPen1, 29, 29, 48, 118); //Connect Constellation
            formGraphics.DrawLine(drawPen1, 29, 29, 103, 118);
            formGraphics.DrawLine(drawPen1, 104, 119, 123, 268);
            formGraphics.DrawLine(drawPen1, 54, 139, 48, 118);
            formGraphics.DrawLine(drawPen1, 124, 269, 53, 138);

            Pen drawPen2 = new Pen(Color.BurlyWood, 3); //Change Constellation Color
            drawBrush.Color = Color.BurlyWood;

            formGraphics.FillEllipse(drawBrush, 25, 25, 10, 10); //Redraw with new color
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 45, 115, 10, 10);
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 100, 115, 10, 10);
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 50, 135, 10, 10);
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 120, 265, 10, 10);
            Thread.Sleep(350);
            formGraphics.DrawLine(drawPen2, 29, 29, 48, 118); 
            formGraphics.DrawLine(drawPen2, 29, 29, 103, 118);
            formGraphics.DrawLine(drawPen2, 104, 119, 123, 268);
            formGraphics.DrawLine(drawPen2, 54, 139, 48, 118);
            formGraphics.DrawLine(drawPen2, 124, 269, 53, 138);

            Pen drawPen3 = new Pen(Color.Fuchsia, 3); //Change Constellation Color
            drawBrush.Color = Color.Fuchsia;

            formGraphics.FillEllipse(drawBrush, 25, 25, 10, 10); //Redraw with new color
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 45, 115, 10, 10);
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 100, 115, 10, 10);
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 50, 135, 10, 10);
            Thread.Sleep(350);
            formGraphics.FillEllipse(drawBrush, 120, 265, 10, 10);
            Thread.Sleep(350);
            formGraphics.DrawLine(drawPen3, 29, 29, 48, 118);
            formGraphics.DrawLine(drawPen3, 29, 29, 103, 118);
            formGraphics.DrawLine(drawPen3, 104, 119, 123, 268);
            formGraphics.DrawLine(drawPen3, 54, 139, 48, 118);
            formGraphics.DrawLine(drawPen3, 124, 269, 53, 138);

            Graphics fg = this.CreateGraphics(); //Create Text about the sheild
            Font drawFont = new Font("Mistral", 24, FontStyle.Bold);
            SolidBrush drawBrush1 = new SolidBrush(Color.Maroon);
            fg.DrawString("Scutum", drawFont, drawBrush1, 200, 230);
            Font drawFont1 = new Font("Hobo STD", 12, FontStyle.Bold);
            fg.DrawString("The Roman Sheild.", drawFont1, drawBrush1, 150, 260);
            SoundPlayer player1 = new SoundPlayer(Properties.Resources.Cheer);
            player1.Play();
        }
    }
}