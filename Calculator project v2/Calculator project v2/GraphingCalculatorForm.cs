using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Calculator_project_v2
{
    public partial class GraphingCalculatorForm : Form
    {
        public GraphingCalculatorForm()
        {
            InitializeComponent();
        }

        private void GraphingCalculatorForm_Load(object sender, EventArgs e)
        {
            SetupGraphPane(); 

            
            if (string.IsNullOrWhiteSpace(txtXMin.Text)) txtXMin.Text = "-10";
            if (string.IsNullOrWhiteSpace(txtXMax.Text)) txtXMax.Text = "10";
            if (string.IsNullOrWhiteSpace(txtYMin.Text)) txtYMin.Text = "-10";
            if (string.IsNullOrWhiteSpace(txtYMax.Text)) txtYMax.Text = "10";
        }

        
        private void SetupGraphPane()
        {
            
            GraphPane myPane = zedGraphControl1.GraphPane;

           
            myPane.Title.Text = "Function Plot";
            myPane.XAxis.Title.Text = "X Value";
            myPane.YAxis.Title.Text = "Y Value (f(x))";

           
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.DashOn = 10;
            myPane.XAxis.MajorGrid.DashOff = 5;
            myPane.YAxis.MajorGrid.DashOn = 10;
            myPane.YAxis.MajorGrid.DashOff = 5;

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        
        private void graph_clk(object sender, EventArgs e)
        {
            
            GraphPane myPane = zedGraphControl1.GraphPane;

            
            myPane.CurveList.Clear();

            string equation = txtEquation.Text.Trim().ToLowerInvariant(); 
            if (string.IsNullOrEmpty(equation))
            {
                MessageBox.Show("Please enter an equation.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            double xMin, xMax, yMinRange, yMaxRange;
            if (!double.TryParse(txtXMin.Text, out xMin) ||
                !double.TryParse(txtXMax.Text, out xMax) ||
                !double.TryParse(txtYMin.Text, out yMinRange) ||
                !double.TryParse(txtYMax.Text, out yMaxRange))
            {
                MessageBox.Show("Invalid range values. Please enter numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (xMin >= xMax)
            {
                MessageBox.Show("X Min value must be less than X Max value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            PointPairList listPoints = new PointPairList();

            
            DataTable dt = new DataTable(); 

            int numPointsToPlot = Math.Max(500, zedGraphControl1.Width); 

            for (int i = 0; i < numPointsToPlot; i++)
            {
               
                double x = xMin + (xMax - xMin) * i / (numPointsToPlot - 1);
                try
                {
                    

                    string expressionToEvaluate = equation.Replace("x", x.ToString(System.Globalization.CultureInfo.InvariantCulture));
                    double y;

                    
                    if (expressionToEvaluate.Contains("sin("))
                        y = Math.Sin(x); 
                    else if (expressionToEvaluate.Contains("cos("))
                        y = Math.Cos(x); 
                    else if (expressionToEvaluate.Contains("tan("))
                        y = Math.Tan(x);
                    else if (expressionToEvaluate.Contains("sqrt("))
                        y = Math.Sqrt(x);
                    else if (expressionToEvaluate.Contains("log10("))
                        y = Math.Log10(x);
                    else if (expressionToEvaluate.Contains("log("))
                        y = Math.Log(x);
                    else if (expressionToEvaluate.Contains("^"))
                    {
                        string[] parts = expressionToEvaluate.Split('^');
                        if (parts.Length == 2)
                        {
                            double baseVal = parts[0].Trim() == "x" ? x : Convert.ToDouble(parts[0].Trim(), System.Globalization.CultureInfo.InvariantCulture);
                            double expVal = parts[1].Trim() == "x" ? x : Convert.ToDouble(parts[1].Trim(), System.Globalization.CultureInfo.InvariantCulture);
                            y = Math.Pow(baseVal, expVal);
                        }
                        else
                        {
                            
                            var resultObj = dt.Compute(expressionToEvaluate.Replace(",", "."), "");
                            y = Convert.ToDouble(resultObj);
                        }
                    }
                    else 
                    {
                        
                        var resultObj = dt.Compute(expressionToEvaluate.Replace(",", "."), "");
                        y = Convert.ToDouble(resultObj);
                    }

                    
                    if (!double.IsNaN(y) && !double.IsInfinity(y))
                    {
                        listPoints.Add(x, y);
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }

            // 
            if (listPoints.Count > 0)
            {
                
                LineItem myCurve = myPane.AddCurve("My Function", listPoints, Color.Blue, SymbolType.None);
                myCurve.Line.Width = 2.0f;
            }
            else
            {
                MessageBox.Show("Could not plot any points for the given equation and range. Check your equation or try different ranges.", "Plotting Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            myPane.XAxis.Scale.Min = xMin;
            myPane.XAxis.Scale.Max = xMax;
            myPane.YAxis.Scale.Min = yMinRange;
            myPane.YAxis.Scale.Max = yMaxRange;
            


            
            zedGraphControl1.AxisChange(); 
            zedGraphControl1.Invalidate();
        }


        
        private void btnClear_Click(object sender, EventArgs e) 
        {
            GraphPane myPane = zedGraphControl1.GraphPane; 
            myPane.CurveList.Clear(); 
            txtEquation.Clear();      

           
            double xMin, xMax, yMin, yMax;
            if (double.TryParse(txtXMin.Text, out xMin) &&
                double.TryParse(txtXMax.Text, out xMax) &&
                double.TryParse(txtYMin.Text, out yMin) &&
                double.TryParse(txtYMax.Text, out yMax))
            {
                myPane.XAxis.Scale.Min = xMin;
                myPane.XAxis.Scale.Max = xMax;
                myPane.YAxis.Scale.Min = yMin;
                myPane.YAxis.Scale.Max = yMax;
            }
            else
            {
                myPane.XAxis.Scale.Min = -10;
                myPane.XAxis.Scale.Max = 10;
                myPane.YAxis.Scale.Min = -10;
                myPane.YAxis.Scale.Max = 10;
            }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        
        private void btnResetZoom_Click(object sender, EventArgs e) 
        {

        }



        private void label1_Click(object sender, EventArgs e) {  }
        private void back_clk(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void exit_clk(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void txtXMin_TextChanged(object sender, EventArgs e) {  }
        private void txtEquation_TextChanged(object sender, EventArgs e) {  }
        private void txtXMax_TextChanged(object sender, EventArgs e) {  }
        private void txtYMin_TextChanged(object sender, EventArgs e) {  }
        private void txtYMax_TextChanged(object sender, EventArgs e) {  }
        private void zedGraphControl_Load(object sender, EventArgs e) {  }
    }
}