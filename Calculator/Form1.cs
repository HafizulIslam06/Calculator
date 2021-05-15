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
        double FirstNum = 0;
        double SecondNum = 0;
        string operation = "";        

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
            label_secondScreen.Text = "";

            FirstNum = 0;
            SecondNum = 0;
            operation = "";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        private void button_Devision_Click(object sender, EventArgs e)
        {
             Operator_operation(sender);                       
        }
        private void Operator_operation(object btn)
        {            
            Button b = (Button)btn;
            label_secondScreen.Text = textBox.Text + b.Text;
            FirstNum = Double.Parse(textBox.Text);
            operation = b.Text;
            textBox.Text = "";            
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            SecondNum = double.Parse(textBox.Text);
            switch (operation)
            {
                case "+":
                    textBox.Text = Convert.ToString(FirstNum + SecondNum);
                    label_secondScreen.Text = textBox.Text;
                    break;
                case "-":
                    textBox.Text = Convert.ToString(FirstNum - SecondNum);
                    label_secondScreen.Text = textBox.Text;
                    break;
                case "×":
                    textBox.Text = Convert.ToString(FirstNum * SecondNum);
                    label_secondScreen.Text = textBox.Text;
                    break;
                case "÷":
                    textBox.Text = Convert.ToString(FirstNum / SecondNum);
                    label_secondScreen.Text = textBox.Text;
                    break;
                default:
                    break;
            }
        }

        private void button_Multiplication_Click(object sender, EventArgs e)
        {
            Operator_operation(sender);
        }

        private void button_subtraction_Click(object sender, EventArgs e)
        {
            Operator_operation(sender);
        }

        private void button_addition_Click(object sender, EventArgs e)
        {
            Operator_operation(sender);
        }

        private void Button_Click(object btn)
        {
            Button b = (Button)btn;
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            if (b.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text = textBox.Text + b.Text;
                }
            }            
            else
            {
                textBox.Text = textBox.Text + b.Text;
            }            
        }
    }
}
