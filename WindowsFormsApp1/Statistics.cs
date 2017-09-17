using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Statistics : MetroFramework.Forms.MetroForm
    {
        // Mainform instance
        mainForm m;

        // Initializing components
        public Statistics()
        {
            InitializeComponent();
        }

        String STATT = "stat.txt";
        String AMOUNTT = "amount.txt";
        String NAMEST = "names.txt";
        String SALARYT = "Salary";

        // Form load
        private void Statistics_Load(object sender, EventArgs e)
        {
            // Clearing the chart
            cHart.Series.Clear();

            // Adding the salary chart
            cHart.Series.Add(SALARYT);
            StreamReader swr = new StreamReader(STATT);
            int amount = 0;
            StreamReader swa = new StreamReader(AMOUNTT);
            amount = Int32.Parse(swa.ReadLine());
            StreamReader swn = new StreamReader(NAMEST);
            double[] salary = new double[500];
            String[] names = new String[500];
            //TAKING THE DATA FROM TXT FILE AND FILLING THE CHART
            double maxval = 0;
            for (int i = 0; i < amount; i++)
            {
                names[i] = swn.ReadLine();
                salary[i] = Double.Parse(swr.ReadLine());
                if (salary[i] > maxval) maxval = salary[i];
                cHart.Series[SALARYT].Points.AddXY(names[i], salary[i]);
            }
            //CLOSING THE FILES
            swa.Close();
            swn.Close();
            swr.Close();
            //DELETING THE FILE
            if (File.Exists(STATT)) File.Delete(STATT);
            if (File.Exists(NAMEST)) File.Delete(NAMEST);
            if (File.Exists(AMOUNTT)) File.Delete(AMOUNTT);
        }

        // Pie
        private void PIE_Click(object sender, EventArgs e)
        {
            if (cHart.Series[SALARYT].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie) return;
            cHart.Series[SALARYT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            cHart.Series[SALARYT]["PieLabelStyle"] = "Disabled";
        }

        // Column
        private void button1_Click(object sender, EventArgs e)
        {
            if (cHart.Series[SALARYT].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column) return;
            cHart.Series[SALARYT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        // Bubble
        private void button2_Click(object sender, EventArgs e)
        {
            if (cHart.Series[SALARYT].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble) return;
            cHart.Series[SALARYT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
        }

        // Bar
        private void button3_Click(object sender, EventArgs e)
        {
            if (cHart.Series[SALARYT].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar) return;
            cHart.Series[SALARYT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }

        // Line
        private void button4_Click(object sender, EventArgs e)
        {
            if (cHart.Series[SALARYT].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line) return;
            cHart.Series[SALARYT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        // Funnel
        private void button5_Click(object sender, EventArgs e)
        {
            if (cHart.Series[SALARYT].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel) return;
            cHart.Series[SALARYT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
        }

        // Area
        private void button6_Click(object sender, EventArgs e)
        {
            if (cHart.Series[SALARYT].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area) return;
            cHart.Series[SALARYT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
        }

        // CandleStick
        private void button7_Click(object sender, EventArgs e)
        {
            if (cHart.Series[SALARYT].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick) return;
            cHart.Series[SALARYT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
        }

        // Doughnut
        private void button8_Click(object sender, EventArgs e)
        {
            if (cHart.Series[SALARYT].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut) return;
            cHart.Series[SALARYT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            cHart.Series[SALARYT]["DoughnutLabelStyle"] = "Disabled";
        }
    }
}