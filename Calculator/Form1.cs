using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        double Value = 0;
        string operation = "";
        bool operation_pressed = false;

        private void panel_Border_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel_Border_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel_Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            Button_Click(sender);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }                

        private void Button_Click(object btn)
        {
            if (textBox.Text == "0" || (operation_pressed))
            {
                textBox.Clear();
            }
            Button b = (Button)btn;
            textBox.Text = textBox.Text + b.Text;
        }

    }
}
