using System;
using System.Windows.Forms;

namespace _20190503
{
    public partial class Form1 : Form
    {
        public double number; // 현재 입력한 숫자
        public double preNumber; // 이전에 입력한 숫자
        public string cal=""; // 입력한 연산자
        public Boolean btnCalBool; // 마지막으로 연산자를 입력했는지 여부

        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate()
        {
            switch (cal)
            {
                case "Div":
                    number = preNumber / number;
                    break;

                case "Mul":
                    number = preNumber * number;
                    break;

                case "Sub":
                    number = preNumber - number;
                    break;

                case "Add":
                    number = preNumber + number;
                    break;

                default:
                    break;
            }
            tbNumber.Text = number.ToString();
            preNumber = number;
            btnCalBool = true;
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if(tbNumber.Text.Equals("0"))
            {
                tbCals.Text = "";
                tbNumber.Text = "0";
                cal = "";
            }
            else if(btnCalBool == false)
            {
                number = double.Parse(tbNumber.Text);
                tbCals.Text = tbCals.Text + number + " / ";
                Calculate();
                cal = "Div";
            }
            else
            {
                tbCals.Text = tbCals.Text.Substring(0, tbCals.Text.Length - 3) + " / ";
                cal = "Div";
            }
        }
        private void BtnMul_Click(object sender, EventArgs e)
        {
            if (btnCalBool == false)
            {
                number = double.Parse(tbNumber.Text);
                tbCals.Text = tbCals.Text + number + " * ";
                Calculate();
                cal = "Mul";
            }
            else
            {
                tbCals.Text = tbCals.Text.Substring(0, tbCals.Text.Length - 3) + " * ";
                cal = "Mul";
            }
        }
        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (btnCalBool == false)
            {
                number = double.Parse(tbNumber.Text);
                tbCals.Text = tbCals.Text + number + " - ";
                Calculate();
                cal = "Sub";
            }
            else
            {
                tbCals.Text = tbCals.Text.Substring(0, tbCals.Text.Length - 3) + " - ";
                cal = "Sub";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (btnCalBool == false)
            {
                number = double.Parse(tbNumber.Text);
                tbCals.Text = tbCals.Text + number + " + ";
                Calculate();
                cal = "Add";
            }
            else
            {
                tbCals.Text = tbCals.Text.Substring(0, tbCals.Text.Length - 3) + " + ";
                cal = "Add";
            }
        }

        private void BtnEq_Click(object sender, EventArgs e)
        {
            if(cal.Equals(""))
            {
                number = double.Parse(tbNumber.Text);
            }
            else{
                number = double.Parse(tbNumber.Text);
                Calculate();
                number = 0;
                tbCals.Text = "";
            }
            btnCalBool = false;
            cal = "";
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            tbCals.Text = "";
            tbNumber.Text = "0";
            number = 0;
            cal = "";
        }

        private void Number_click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            // 이미 0이 입력되어 있거나, 직전에 연산자가 입력되었던 경우
            if (tbNumber.Text.Equals("0") || btnCalBool == true)
            {
                tbNumber.Text = btn.Text;
                btnCalBool = false;
            }
            else
            {
                tbNumber.Text = tbNumber.Text + btn.Text;
            }
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            // 한 number에 소수점은 하나만 입력할 수 있음
            if (!tbNumber.Text.Contains("."))
            {
                tbNumber.Text = tbNumber.Text + ".";
            }
        }
    }
}
