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
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Image").SetValue(sender, Image.FromFile(@"C:\Repositories\ТТТ\ТТТ\icon\cross1.png"));
                    player = 0;
                    label1.Text = "Ходит игрок 2";

                    break;
                case 0:
                    sender.GetType().GetProperty("Image").SetValue(sender, Image.FromFile(@"C:\Repositories\ТТТ\ТТТ\icon\circle1.png"));
                    player = 1;
                    label1.Text = "Ходит игрок 1";

                    break;
            }
            //sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            Button btn = (Button)sender;
            btn.Click -= new System.EventHandler(this.button1_Click);
            //checkWin();
        }

        //private void checkWin()
        //{
        //    string msg = "Вы победили!";

        //    //Проверка строк
        //    if ((button1.Image == button2.Image && button2.Image == button3.Image) && (button2.Image != null))
        //    {
        //            MessageBox.Show(msg);
        //    }
        //    if ((button4.Image == button5.Image && button5.Image == button6.Image) && (button5.Image != null))
        //    {
        //            MessageBox.Show(msg);
        //    }
        //    if ((button7.Image == button8.Image && button8.Image == button9.Image) && (button8.Image != null))
        //    {
        //            MessageBox.Show(msg);
        //    }


        //    //Проверка столбцов
        //    if ((button1.Image == button4.Image && button4.Image == button7.Image) && (button4.Image != null))
        //    {
        //            MessageBox.Show(msg);
        //    }
        //    if ((button2.Image == button5.Image && button5.Image == button8.Image) && (button5.Image != null))
        //    {
        //            MessageBox.Show(msg);
        //    }
        //    if ((button3.Image == button6.Image && button6.Image == button9.Image) && (button6.Image != null))
        //    {
        //            MessageBox.Show(msg);
        //    }


        //    //Проверка диагоналей
        //    if ((button1.Image == button5.Image && button5.Image == button9.Image) && (button5.Image != null))
        //    {
        //            MessageBox.Show(msg);
        //    }
        //    if ((button3.Image == button5.Image && button5.Image == button7.Image) && (button5.Image != null))
        //    {               
        //            MessageBox.Show(msg);
        //    }      
        //}
    }
}
