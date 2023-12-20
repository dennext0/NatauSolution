

namespace NatauSolution
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ButtonExit = new Button();
            numberLabel = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // ButtonExit
            // 
            ButtonExit.Location = new Point(812, 511);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(114, 41);
            ButtonExit.TabIndex = 1;
            ButtonExit.Text = "Exit";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.BackColor = Color.White;
            numberLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberLabel.ForeColor = Color.Red;
            numberLabel.Location = new Point(812, 149);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(74, 26);
            numberLabel.TabIndex = 2;
            numberLabel.Text = "label1";
            // 
            // chart1
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(-1, -1);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series3";
            chart1.Series.Add(series1);
            chart1.Size = new Size(807, 605);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            // 
            // button1
            // 
            button1.Location = new Point(812, 62);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 4;
            button1.Text = "Up/Down";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonUpDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(812, 123);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 5;
            label2.Text = "Current number";
            // 
            // button2
            // 
            button2.Location = new Point(812, 276);
            button2.Name = "button2";
            button2.Size = new Size(114, 41);
            button2.TabIndex = 6;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Reset;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(948, 603);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(numberLabel);
            Controls.Add(button1);
            Controls.Add(ButtonExit);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonExit;
        private Label numberLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button1;
        private Label label2;
        private Button button2;
    }
}
