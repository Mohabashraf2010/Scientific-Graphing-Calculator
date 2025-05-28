using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_project_v2
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void DOOSNUMBERS(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtresult.Text == "0")
                txtresult.Text = "";
            
                if (num.Text == ".")
                {
                    if(!txtresult.Text.Contains("."))
                    {
                        txtresult.Text = txtresult.Text + num.Text;
                    }
                }
            else
            {
                txtresult.Text = txtresult.Text + num.Text;
            }

        }

        private void OPERATORS(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstValue = Convert.ToDouble(txtresult.Text);
            op = num.Text;
            txtresult.Text = "";
            
        }

        private void Button_equal(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtresult.Text);

            switch (op)
            {
                case "+":
                    txtresult.Text = (enterFirstValue + enterSecondValue).ToString();

                    break;

                    case "-":
                    txtresult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;

                    case "*":
                    txtresult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;

                case "/":
                    txtresult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;

                case "mod":
                    txtresult.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;

                case "Exp":
                    double i = Convert.ToDouble(txtresult.Text);
                    double j = enterSecondValue;
                    txtresult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;

                default:

                    break;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
        }

        private void ClearE_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";

            String first, second;

            first = Convert.ToString(enterFirstValue);
            second = Convert.ToString(enterSecondValue);

            first = "";
            second = "";
        }

        private void Plusminus_Click(object sender, EventArgs e)
        {
            double plusminus = Convert.ToDouble(txtresult.Text);
            txtresult.Text = Convert.ToString(-1 * plusminus); ;
        }

        private void Backspace(object sender, EventArgs e)
        {
            if (txtresult.Text.Length > 0)
            {
                txtresult.Text = txtresult.Text.Remove(txtresult.Text.Length - 1, 1);
            }

            if (txtresult.Text == "")
            {
                txtresult.Text = "0";
            }
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 797;
            double conv = Convert.ToDouble(txtresult.Width);
            double decimalwidth = 759.9;
            txtresult.Width = (int)decimalwidth;
            
        }

        private void stardardCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 394;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitcalc;

            exitcalc = MessageBox.Show("Are you sure you want to exit?", "Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if ( exitcalc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PIbutton(object sender, EventArgs e)
        {
            txtresult.Text = "3.141";
        }

        private void Logbutton(object sender, EventArgs e)
        {
            double Log = Convert.ToDouble(txtresult.Text);
            Log = Math.Log10(Log);
            txtresult.Text = Convert.ToString(Log);
        }

        private void Square_root(object sender, EventArgs e)
        {
            double square_root = Convert.ToDouble(txtresult.Text);
            square_root = Math.Sqrt(square_root);
            txtresult.Text = Convert.ToString(square_root);
        }

        private void squared(object sender, EventArgs e)
        {
            double x;

            x = Convert.ToDouble(txtresult.Text) * Convert.ToDouble(txtresult.Text);
            txtresult.Text = Convert.ToString(x);
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            double sinh = Convert.ToDouble(txtresult.Text);
            sinh = Math.Sinh(sinh);
            txtresult.Text = Convert.ToString(sinh);
        }

        private void Sine(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtresult.Text);
            sin = Math.Sin(sin);
            txtresult.Text = Convert.ToString(sin);
        }


        private void Cosine(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtresult.Text);
            cos = Math.Cos(cos);
            txtresult.Text = Convert.ToString(cos);
        }

        private void Coshine(object sender, EventArgs e)
        {
            double coshine = Convert.ToDouble(txtresult.Text);
            coshine = Math.Cosh(coshine);
            txtresult.Text = Convert.ToString(coshine);
        }

        private void Tan_h(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txtresult.Text);
            tanh = Math.Tanh(tanh);
            txtresult.Text = Convert.ToString(tanh);
        }

        private void tan_(object sender, EventArgs e)
        {
            double Tan = Convert.ToDouble(txtresult.Text);
            Tan = Math.Tan(Tan);
            txtresult.Text = Convert.ToString(Tan);
        }

        private void divided(object sender, EventArgs e)
        {
            double division;
            division = Convert.ToDouble(1.0 / Convert.ToDouble(txtresult.Text));

            txtresult.Text = Convert.ToString(division);
        }

        private void ln_x(object sender, EventArgs e)
        {
            double ln = Convert.ToDouble(txtresult.Text);
            ln = Math.Log(ln);
            txtresult.Text = Convert.ToString(ln);
        }

        private void percentage(object sender, EventArgs e)
        {

        }

        private void absolute_x(object sender, EventArgs e)
        {
            double abs = Convert.ToDouble(txtresult.Text);
            abs = Math.Abs(abs);
            txtresult.Text = Convert.ToString(abs);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hamburger(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Hamburger, new Point(0, Hamburger.Height));
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphingCalculatorForm graphingCalculator = new GraphingCalculatorForm();
            graphingCalculator.Show();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 394;
        }


    }
}
