using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace NatauSolution
{
    public partial class Form1 : Form
    {
        private List<int> values = new List<int>();
        private bool incrementing = true;
        private int currentValueChart = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayNumber();
        }

        private void DisplayNumber()
        {
            numberLabel.Text = currentValueChart.ToString();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonUpDown(object sender, EventArgs e)
        {
            if (incrementing)
            {
                currentValueChart += 10;

                if (currentValueChart >= 100)
                {
                    incrementing = false;
                }
            }
            else
            {
                currentValueChart -= 10;

                if (currentValueChart <= 0)
                {
                    incrementing = true;
                }
            }

            UpdateChart();
            DisplayNumber();
        }

        private void UpdateChart()
        {
            values.Add(currentValueChart);

            if (values.Count > 60)
            {
                values.RemoveAt(0);
            }

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < values.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i, values[i]);
            }

            chart1.Invalidate();
        }

        private void Reset(object sender, EventArgs e)
        {
            incrementing = true;
            currentValueChart = 0;
            values.Clear();

            chart1.Series[0].Points.Clear();

            chart1.Invalidate();
            DisplayNumber();

        }
    }

}
