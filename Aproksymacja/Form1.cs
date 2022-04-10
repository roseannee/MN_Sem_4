using System;
using System.Windows.Forms;

namespace Aproksymacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            string[] pointsArray = points_rtxb.Text.Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            double[] xArray = new double[pointsArray.Length];
            double[] yArray = new double[pointsArray.Length];

            for (int i = 0; i < pointsArray.Length; i++)
            {
                string[] elements = pointsArray[i].Split(' ');
                xArray[i] = double.Parse(elements[0]);
                yArray[i] = double.Parse(elements[1]);
            }

            Approximation approximation = new Approximation(xArray, yArray);
            res_lbl.Text = approximation.ToString();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            points_rtxb.Text = "";
            res_lbl.Text = "";
        }
    }
}
