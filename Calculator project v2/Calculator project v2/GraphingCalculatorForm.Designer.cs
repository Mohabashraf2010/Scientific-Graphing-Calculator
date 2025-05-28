namespace Calculator_project_v2
{
    partial class GraphingCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.eqlabel = new System.Windows.Forms.Label();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.controls = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hamburger = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXMin = new System.Windows.Forms.TextBox();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.txtYMin = new System.Windows.Forms.TextBox();
            this.txtYMax = new System.Windows.Forms.TextBox();
            this.buttonclear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(32, 101);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(729, 393);
            this.zedGraphControl1.TabIndex = 1;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl_Load);
            // 
            // eqlabel
            // 
            this.eqlabel.AutoSize = true;
            this.eqlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.eqlabel.ForeColor = System.Drawing.Color.White;
            this.eqlabel.Location = new System.Drawing.Point(29, 41);
            this.eqlabel.Name = "eqlabel";
            this.eqlabel.Size = new System.Drawing.Size(106, 13);
            this.eqlabel.TabIndex = 2;
            this.eqlabel.Text = "Enter Equation F(x) =";
            this.eqlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(141, 38);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(257, 20);
            this.txtEquation.TabIndex = 4;
            this.txtEquation.TextChanged += new System.EventHandler(this.txtEquation_TextChanged);
            // 
            // controls
            // 
            this.controls.AutoSize = true;
            this.controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.controls.ForeColor = System.Drawing.Color.White;
            this.controls.Location = new System.Drawing.Point(51, 71);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(37, 13);
            this.controls.TabIndex = 5;
            this.controls.Text = "X Min:";
            this.controls.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hamburger);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 35);
            this.panel1.TabIndex = 9;
            // 
            // Hamburger
            // 
            this.Hamburger.FlatAppearance.BorderSize = 0;
            this.Hamburger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Hamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hamburger.ForeColor = System.Drawing.Color.White;
            this.Hamburger.Location = new System.Drawing.Point(0, 0);
            this.Hamburger.Margin = new System.Windows.Forms.Padding(0);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.Size = new System.Drawing.Size(72, 31);
            this.Hamburger.TabIndex = 0;
            this.Hamburger.Text = "<---";
            this.Hamburger.UseVisualStyleBackColor = true;
            this.Hamburger.Click += new System.EventHandler(this.back_clk);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGraph.FlatAppearance.BorderSize = 0;
            this.buttonGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraph.ForeColor = System.Drawing.Color.Transparent;
            this.buttonGraph.Location = new System.Drawing.Point(417, 34);
            this.buttonGraph.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(72, 27);
            this.buttonGraph.TabIndex = 0;
            this.buttonGraph.Text = "Graph";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.graph_clk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X Max:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(435, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y Min:";
            this.label2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(602, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y Max:";
            this.label3.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtXMin
            // 
            this.txtXMin.Location = new System.Drawing.Point(94, 68);
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.Size = new System.Drawing.Size(100, 20);
            this.txtXMin.TabIndex = 10;
            this.txtXMin.Text = "-10";
            this.txtXMin.TextChanged += new System.EventHandler(this.txtXMin_TextChanged);
            // 
            // txtXMax
            // 
            this.txtXMax.Location = new System.Drawing.Point(283, 68);
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.Size = new System.Drawing.Size(100, 20);
            this.txtXMax.TabIndex = 10;
            this.txtXMax.Text = "10";
            this.txtXMax.TextChanged += new System.EventHandler(this.txtXMax_TextChanged);
            // 
            // txtYMin
            // 
            this.txtYMin.Location = new System.Drawing.Point(478, 68);
            this.txtYMin.Name = "txtYMin";
            this.txtYMin.Size = new System.Drawing.Size(100, 20);
            this.txtYMin.TabIndex = 10;
            this.txtYMin.Text = "-10";
            this.txtYMin.TextChanged += new System.EventHandler(this.txtYMin_TextChanged);
            // 
            // txtYMax
            // 
            this.txtYMax.Location = new System.Drawing.Point(648, 68);
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.Size = new System.Drawing.Size(100, 20);
            this.txtYMax.TabIndex = 10;
            this.txtYMax.Text = "10";
            this.txtYMax.TextChanged += new System.EventHandler(this.txtYMax_TextChanged);
            // 
            // buttonclear
            // 
            this.buttonclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonclear.FlatAppearance.BorderSize = 0;
            this.buttonclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclear.ForeColor = System.Drawing.Color.Transparent;
            this.buttonclear.Location = new System.Drawing.Point(489, 34);
            this.buttonclear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(72, 27);
            this.buttonclear.TabIndex = 0;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // GraphingCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(811, 495);
            this.Controls.Add(this.txtYMax);
            this.Controls.Add(this.txtYMin);
            this.Controls.Add(this.txtXMax);
            this.Controls.Add(this.txtXMin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.eqlabel);
            this.Controls.Add(this.zedGraphControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraphingCalculatorForm";
            this.Text = "GraphingCalculatorForm";
            this.Load += new System.EventHandler(this.GraphingCalculatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label eqlabel;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Label controls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Hamburger;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXMin;
        private System.Windows.Forms.TextBox txtXMax;
        private System.Windows.Forms.TextBox txtYMin;
        private System.Windows.Forms.TextBox txtYMax;
        private System.Windows.Forms.Button buttonclear;
    }
}