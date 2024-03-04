using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String operation = "";
        double result_value = 0;
        bool isOperation = false;

        private void btn_click(object sender, EventArgs e)
        {
            if (tb1.Text == "0" || isOperation) {
                tb1.Clear();
            }
            Button btn = (Button) sender;

            if (btn.Text == ".")
            {
                if (!tb1.Text.Contains(".")) {
                    tb1.Text = tb1.Text + btn.Text;
                }
            }
            else {
                tb1.Text = tb1.Text + btn.Text;
            }
            isOperation = false;
        }

        private void operation_performed(object sender, EventArgs e)
        {
            if (result_value != 0)
            {
                button16.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                result_value = double.Parse(tb1.Text);
                lb1.Text = result_value + operation;
                isOperation = true;
            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                result_value = double.Parse(tb1.Text);
                lb1.Text = result_value + operation;
                isOperation = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            lb1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operation) {
                case "+":
                    tb1.Text = (result_value + double.Parse(tb1.Text)).ToString();
                    break;
                case "-":
                    tb1.Text = (result_value - double.Parse(tb1.Text)).ToString();
                    break;
                case "/":
                    tb1.Text = (result_value / double.Parse(tb1.Text)).ToString();
                    break;
                case "*":
                    tb1.Text = (result_value * double.Parse(tb1.Text)).ToString();
                    break;
            }
        }
    }
}
