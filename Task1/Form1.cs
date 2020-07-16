using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Task1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayTime();
            
        }
      

      

        private void DisplayTime()
        {
            var hour = System.DateTime.Now.Hour;

            if (hour > 0 && hour <= 6)
            {
                this.Text = $"Доброй ночи ! Время {System.DateTime.Now.ToString()}";
            }
            else if (hour > 6 && hour <= 12)
            {
                this.Text = $"Доброе утро ! Время {System.DateTime.Now.ToString()}";
            }
            else if (hour > 12 && hour <= 18)
            {
                this.Text = $"Доброе день ! Время {System.DateTime.Now.ToString()}";
            }
            else
            {
                this.Text = $"Добрый вечер ! Время {System.DateTime.Now.ToString()}";
            }

        }

      

       

        

       

        private void ButtonClick(object sender, MouseEventArgs e)
        {
            var button = (FlowLayoutPanel)sender;
            label1.Text = $"{button.Tag.ToString()} X={e.X} Y={e.Y}";
            
        }
        private void DefineButton(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label2.Text = "ЛКМ";
            }
            else if (e.Button == MouseButtons.Right)
            {
                label2.Text = "ПКМ";
            }
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonClick(sender,e);
            DefineButton(e);
        }

        private void flowLayoutPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            ButtonClick(sender,e);
            DefineButton(e);
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            DefineButton(e);
            
        }
    }
}
