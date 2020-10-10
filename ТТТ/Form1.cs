using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТТТ
{
    public partial class Form1 : Form
    {        
        private int player;
        public Form1()
        {
            InitializeComponent();
            player = 1;
            label1.Text = "Ходит игрок 1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (player)
            {
                
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    //sender.GetType().GetProperty("Image").SetValue(sender, Image.FromFile(@"C:\Repositories\ТТТ\ТТТ\icon\cross1.png"));
                    player = 0;
                    btn.GetType().GetProperty("Tag").SetValue(sender, "1");
                    label1.Text = "Ходит игрок 2";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "○");
                    //sender.GetType().GetProperty("Image").SetValue(sender, Image.FromFile(@"C:\Repositories\ТТТ\ТТТ\icon\circle1.png"));
                    player = 1;
                    btn.GetType().GetProperty("Tag").SetValue(sender, "0");
                    label1.Text = "Ходит игрок 1";
                    break;
            }
            
            btn.Click -= new EventHandler(this.button1_Click);
            
            checkWin();
        }

        private void Clear()
        {
            button1.Tag = null;
            button2.Tag = null;
            button3.Tag = null;
            button4.Tag = null;
            button5.Tag = null;
            button6.Tag = null;
            button7.Tag = null;
            button8.Tag = null;
            button9.Tag = null;

            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;

            button1.Text = null;
            button2.Text = null;
            button3.Text = null;
            button4.Text = null;
            button5.Text = null;
            button6.Text = null;
            button7.Text = null;
            button8.Text = null;
            button9.Text = null;

            button1.Click += this.button1_Click;
            button2.Click += this.button1_Click;
            button3.Click += this.button1_Click;
            button4.Click += this.button1_Click;
            button5.Click += this.button1_Click;
            button6.Click += this.button1_Click;
            button7.Click += this.button1_Click;
            button8.Click += this.button1_Click;
            button9.Click += this.button1_Click;
        }
        private void checkWin()
        {

            

            void winMsg(Button btn1)
            {
                string q = btn1.Tag.ToString();
                int i = int.Parse(q);
                if (i == 1)
                {
                    MessageBox.Show("Победил Игрок 1!");
                }
                else if (i == 0)
                {
                    MessageBox.Show("Победил Игрок 2!");
                }

            }

            
                
                //Проверка строк              
                if ((button1.Tag == button2.Tag && button2.Tag == button3.Tag) &&
                    button1.Tag != null && button2.Tag != null && button3.Tag != null)
                {
                    winMsg(button2);
                    Clear();
                }
                if ((button4.Tag == button5.Tag && button5.Tag == button6.Tag) &&
                    button4.Tag != null && button5.Tag != null && button6.Tag != null)
                {
                    winMsg(button5);
                    Clear();
                }
                if ((button7.Tag == button8.Tag && button8.Tag == button9.Tag) &&
                    button7.Tag != null && button8.Tag != null && button9.Tag != null)
                {
                    winMsg(button8);
                    Clear();
                }



                //Проверка столбцов
                if ((button1.Tag == button4.Tag && button4.Tag == button7.Tag) &&
                    button1.Tag != null && button4.Tag != null && button7.Tag != null)
                {
                    winMsg(button4);
                    Clear();
                }
                if ((button2.Tag == button5.Tag && button5.Tag == button8.Tag) &&
                    button2.Tag != null && button5.Tag != null && button8.Tag != null)
                {
                    winMsg(button5);
                    Clear();
                }
                if ((button3.Tag == button6.Tag && button6.Tag == button9.Tag) &&
                    button3.Tag != null && button6.Tag != null && button9.Tag != null)
                {
                    winMsg(button6);
                    Clear();
                }


                //Проверка диагоналей
                if ((button1.Tag == button5.Tag && button5.Tag == button9.Tag) &&
                    button1.Tag != null && button5.Tag != null && button9.Tag != null)
                {
                    winMsg(button5);
                    Clear();
                }
                if ((button3.Tag == button5.Tag && button5.Tag == button7.Tag) &&
                    button1.Tag != null && button5.Tag != null && button7.Tag != null)
                {
                    winMsg(button5);
                    Clear();
                }


            


        }
    }
}
