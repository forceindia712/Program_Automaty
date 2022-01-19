using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatProgram
{


    public partial class Form1 : Form
    {

        Boolean a = true;
        Boolean b = false;
        Boolean c = false;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        protected override void OnPaint(PaintEventArgs e)
        {

            Color ColorOn = Color.Red;
            Color ColorOff = Color.Black;


            Pen pen1 = new Pen(Color.Black, 6);
            pen1.StartCap = LineCap.RoundAnchor;
            pen1.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen1, 50, 175, 100, 175);

            if (a == false)
            {
                Pen circle1 = new Pen(Color.Black, 3);
                Rectangle rect = new Rectangle(110, 150, 50, 50);
                e.Graphics.DrawEllipse(circle1, rect);
            }
            else
            {
                Pen circle1 = new Pen(Color.Red, 3);
                Rectangle rect = new Rectangle(110, 150, 50, 50);
                e.Graphics.DrawEllipse(circle1, rect);
            }

            Pen pen2 = new Pen(Color.Black, 6);
            pen2.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen2, 175, 175, 230, 175);

            if (b == false)
            { 
                Pen circle2 = new Pen(Color.Black, 3);
                Rectangle rect2 = new Rectangle(245, 150, 50, 50);
                e.Graphics.DrawEllipse(circle2, rect2);
            }
            else
            {
                Pen circle2 = new Pen(Color.Red, 3);
                Rectangle rect2 = new Rectangle(245, 150, 50, 50);
                e.Graphics.DrawEllipse(circle2, rect2);
            }

            Pen pen3 = new Pen(Color.Black, 6);
            pen3.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen3, 310, 175, 360, 175);


            if(c == false)
            {
                Pen circle3 = new Pen(Color.Black, 3);
                Rectangle rect3 = new Rectangle(380, 150, 50, 50);
                e.Graphics.DrawEllipse(circle3, rect3);

                Pen circle4 = new Pen(Color.Black, 3);
                Rectangle rect4 = new Rectangle(370, 140, 70, 70);
                e.Graphics.DrawEllipse(circle4, rect4);
            }
            else
            {
                Pen circle3 = new Pen(Color.Red, 3);
                Rectangle rect3 = new Rectangle(380, 150, 50, 50);
                e.Graphics.DrawEllipse(circle3, rect3);

                Pen circle4 = new Pen(Color.Red, 3);
                Rectangle rect4 = new Rectangle(370, 140, 70, 70);
                e.Graphics.DrawEllipse(circle4, rect4);
            }



        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Invalidate();

        }

        private void Check_Click(object sender, EventArgs e)
        {
            Boolean accept = false;
            string input = textBox1.Text;

            char[] characters = input.ToCharArray();

            int licznik = 0;


            for (int i = 0; i < input.Length; i++)
            {


                if (a == true && b == false && c == false)
                {

                    if(characters[i] == '1')
                    {
                        pictureBox3.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\LoppedRed.png");
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\curved arrow2.png");
                        a = true;
                        b = false;
                        c = false;
                    }
                    
                    else if(characters[i] == '0')
                    {
                        pictureBox3.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\curved arrow2.png");
                        a = false;
                        b = true;
                        c = false;
                        Invalidate();
                    }
                    
                    else
                    {
                        pictureBox3.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\curved arrow2.png");

                        a = false;
                        b = false;
                        c = false;
                        
                    }

                    licznik++;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    Invalidate();


                    if (licznik == input.Length)
                    {
                        Thread.Sleep(1000);
                        pictureBox3.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\curved arrow2.png");

                        a = true;
                        b = false;
                        c = false;

                        characters = null;

                        Invalidate();

                        break;
                    }

                    continue;

                }



                if (b == true && a == false && c == false)
                {

                    if (characters[i] == '1')
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\curvedArrowPic1Red.png");
                        a = true;
                        b = false;
                        c = false;
                    }

                    else if (characters[i] == '0')
                    {
                        pictureBox3.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        a = false;
                        b = false;
                        c = true;

                        accept = true;
                    }

                    else
                    {
                        pictureBox3.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\curved arrow2.png");

                        a = false;
                        b = false;
                        c = false;
                    }
                    licznik++;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    Invalidate();



                    if (licznik == input.Length)
                    {
                        pictureBox3.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\curved arrow2.png");

                        a = true;
                        b = false;
                        c = false;

                        characters = null;

                        Invalidate();

                        break;
                    }

                    continue;

                }


                if (c == true && b == false && a == false)
                {


                    if (characters[i] == '1')
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\LoppedRed.png");
                        a = false;
                        b = false;
                        c = true;
                    }

                    else if (characters[i] == '0')
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\LoppedRed.png");
                        a = false;
                        b = false;
                        c = true;

                    }

                    else
                    {
                        pictureBox3.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox2.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\curved arrow2.png");

                        a = false;
                        b = false;
                        c = false;
                    }



                    accept = true;
                    licznik++;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    Invalidate();




                    continue;
                }

            }

            if (accept == true && licznik == input.Length)
            {
                pictureBox3.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                pictureBox2.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\Lopped2.png");
                pictureBox1.Image = Image.FromFile(@"C:\Users\Albert\Desktop\AutomatProgram\curved arrow2.png");

                a = true;
                b = false;
                c = false;

                characters = null;


                MessageBox.Show("Program zaakceptował słowo", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Invalidate();

            }

        }
    }
}
