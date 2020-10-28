using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Game1
{
    public partial class Form1 : Form
    {
        int i = 5;

        public Form1()
        {
          
            InitializeComponent();
            timer1.Start();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            rectangleShape1.Location = new Point(rectangleShape1.Location.X, rectangleShape1.Location.Y + 5);
            if (rectangleShape1.Location.Y + 100 > this.Height)
            {
                //ovalShape1.Location = new Point(ovalShape1.Location.X,0-ovalShape1.Height);
                rectangleShape1.Location = new Point(573, 1);
            }


            rectangleShape2.Location = new Point(rectangleShape2.Location.X, rectangleShape2.Location.Y + 5);
            if (rectangleShape2.Location.Y + 85 > this.Height)
            {
                //ovalShape2.Location = new Point(ovalShape2.Location.X, 0-ovalShape2.Height);
                rectangleShape2.Location = new Point(564, 16);
            }


            rectangleShape3.Location = new Point(rectangleShape3.Location.X, rectangleShape3.Location.Y + 5);
            if (rectangleShape3.Location.Y + 75 > this.Height)
            {
                //ovalShape3.Location = new Point(ovalShape3.Location.X, 0 - ovalShape3.Height);
                rectangleShape3.Location = new Point(556, 25);
            }


            rectangleShape4.Location = new Point(rectangleShape4.Location.X, rectangleShape4.Location.Y + 5);
            if (rectangleShape4.Location.Y + 65 > this.Height)
            {
                //ovalShape4.Location = new Point(ovalShape4.Location.X, 0 - ovalShape4.Height);
                rectangleShape4.Location = new Point(549, 36);
            }

        }


       

     


        private void button2_Click(object sender, EventArgs e)
        {   
                timer2.Start();
              
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
           

            rectangleShape5.Location = new Point(rectangleShape5.Location.X + 5, rectangleShape5.Location.Y);

            // if (rectangleShape5.Bounds.IntersectsWith(rectangleShape1.Bounds))
            // {
            //rectangleShape5.Location = new Point(70, 143);
            // timer2.Stop();
            //}
            if ((rectangleShape5.Bounds.IntersectsWith(rectangleShape1.Bounds)) || (rectangleShape5.Bounds.IntersectsWith(rectangleShape2.Bounds)) || (rectangleShape5.Bounds.IntersectsWith(rectangleShape3.Bounds)) || (rectangleShape5.Bounds.IntersectsWith(rectangleShape4.Bounds)) || (rectangleShape5.Location.X >this.Width))
            {
                
               
                            timer1.Stop();
                            timer2.Stop();
                            Thread.Sleep(5000);
                            timer1.Start();
                            rectangleShape5.Location = new Point(70, 143);
                            
                            i--;
                            if (i == 4)
                            {
                                
                                rectangleShape6.Hide();
                            }
                            if (i == 3)
                            {
                               
                                rectangleShape7.Hide();
                            }
                            if (i == 2)
                            {
                                
                                rectangleShape8.Hide();
                            }
                            if (i == 1)
                            {
                                
                                rectangleShape9.Hide();
                            }
                            if (i == 0)
                            {

                                rectangleShape5.Hide();
                            }
                            //rectangleShape6.Location = new Point(70, 143);
                            //rectangleShape9.Hide();


                        }

                    }
                
           
        






        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

       

       


    }
}



