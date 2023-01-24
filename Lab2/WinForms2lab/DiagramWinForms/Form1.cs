using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DiagramWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int generation = int.Parse(textbox11.Text);
            int maxnumber = int.Parse(textbox22.Text);
            int testnumber = int.Parse(textbox33.Text);
            int[] massiv = new int[maxnumber];
            int interval = generation / maxnumber;
            int intervalElements = interval;
            int[] array = new int[testnumber];

            int[] intervalArray = new int[maxnumber];

            RandomMethod(array, massiv, intervalArray, generation, maxnumber, intervalElements, interval);
            SquareMethod(array, massiv, intervalArray, generation, maxnumber, intervalElements, interval);           
            LinearMethod(array, massiv, intervalArray, generation, maxnumber, intervalElements, interval);
        }

        private void RandomMethod(int[] array, int[] jaggedArray, int[] intervalArray, int generationRange, int numberOfRanges, int intervalElements, int interval)
        {
            listboxOutPutFirst.Items.Clear();     
            foreach (var clear in chart1.Series)
            {
                clear.Points.Clear();
            }
            int[] massiv = new int[array.Length];
            int[] rndArrays = new int[jaggedArray.Length];
            int[] intervArray = new int[intervalArray.Length];
            int generation = generationRange;
            int maxnumber = numberOfRanges;
            int intervals = intervalElements;
            int _interval = interval;

            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = rnd.Next(0, generation);
                listboxOutPutFirst.Items.Add(massiv[i]);
            }

            BarChartBuild(massiv, rndArrays, intervArray, maxnumber, intervals, _interval);
            for (int i = 0; i < intervArray.Length; i++)
            {
                Series series = new Series();
                chart1.Series.Add(series);
                series.Points.AddXY(i, intervArray[i]);
            }
        }

        public void SquareMethod(int[] array, int[] jaggedArray, int[] intervalArray, int generationRange, int numberOfRanges, int intervalElements, int interval)
        {
            listboxOutPutSecond.Items.Clear();
            
            foreach (var clear in chart2.Series)
            {
                clear.Points.Clear();
            }

            int[] massiv = new int[array.Length];
            int[] rndArray = new int[jaggedArray.Length];
            int[] intervArray = new int[intervalArray.Length];
            int generation = generationRange;
            int maxnumber = numberOfRanges;
            int intervals = intervalElements;
            int _interval = interval;
            double number = rnd.Next(1000, 9999);

            for (int i = 0; i < massiv.Length; i++) {
                number *= number;
                string stringStartNumber = number.ToString();
                while (stringStartNumber.Length < 8)
                {
                    stringStartNumber = stringStartNumber.Insert(0, "0");
                }
                number = double.Parse(stringStartNumber.Substring(2, 4));
                massiv[i] = (int)((number/10000.0) * generation);
                listboxOutPutSecond.Items.Add(massiv[i]);
            }
            BarChartBuild(massiv, rndArray, intervArray, maxnumber, intervals, _interval);
            for (int i = 0; i < intervArray.Length; i++)
            {
                Series series = new Series();
                chart2.Series.Add(series);
                series.Points.AddXY(i, intervArray[i]);
            }
        }
        public void LinearMethod(int[] array, int[] jaggedArray, int[] intervalArray, int generationRange, int numberOfRanges, int intervalElements, int interval)
        {
            listboxOutPutThird.Items.Clear();
            foreach (var clear in chart3.Series)
            {
                clear.Points.Clear();
            }
            int[] massiv = new int[array.Length];
            int[] rndArray = new int[jaggedArray.Length];
            int[] intervArray = new int[intervalArray.Length];
            int generation = generationRange;
            int maxnumber = numberOfRanges;
            int intervals = intervalElements;
            int _interval = interval;
            int k = rnd.Next(0, generation);
            int c = rnd.Next(0, generation);
            int x = rnd.Next(0, generation);
            massiv[0] = x;

            for (int i = 1; i < massiv.Length; i++)
            {
                massiv[i] = ((massiv[i - 1] * k) + c) % generation;
                listboxOutPutThird.Items.Add(massiv[i]);
            }
            BarChartBuild(massiv, rndArray, intervArray, maxnumber, intervals, _interval);
            for (int i = 0; i < intervArray.Length; i++)
            {
                Series series = new Series();
                chart3.Series.Add(series);
                series.Points.AddXY(i, intervArray[i]);
            }
        }

        public void BarChartBuild(int[] array, int[] jaggedArray, int[] intervalArray, int numberOfRanges, int intervalElements, int interval)
        {
            for (int i = 0; i < numberOfRanges; i++)
            {
                jaggedArray[i] = intervalElements;
                intervalElements += interval;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = jaggedArray.Length - 1; j >= 0; j--)
                {
                    if (j != 0)
                    {
                        if (array[i] <= jaggedArray[j] && array[i] > jaggedArray[j - 1])
                        {
                            intervalArray[j] += 1;
                            break;
                        }
                    }
                    else if (array[i] <= jaggedArray[j])
                    {
                        intervalArray[j] += 1;
                    }
                }
            }
            
        }

        private void comboBoxRandomOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
