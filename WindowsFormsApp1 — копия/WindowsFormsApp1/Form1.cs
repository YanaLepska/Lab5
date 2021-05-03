using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool IntervalIsChecked = false;

        List<Point> Term = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateInfoInDGV()
        {
            table.Rows.Clear();
            for(int row = 0; row < Term.Count; row++)
            {
                table.Rows.Add();
                table.Rows[row].Cells[0].Value = (Term[row].Y.ToString("0.000"));
                table.Rows[row].Cells[1].Value = (Term[row].X1.ToString("0.000"));
                table.Rows[row].Cells[2].Value = (Term[row].X2.ToString("0.000"));
            }
        }
        private void Check_Interval_CheckedChanged(object sender, EventArgs e)
        {
            IntervalIsChecked = Check_Interval.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Point> L_Points = new List<Point>();

            Variable1.Text = Variable1.Text.Replace('.', ',');
            Variable2.Text = Variable2.Text.Replace('.', ',');

            if (IntervalIsChecked)
            {
                Step1.Text = Step1.Text.Replace('.', ',');
                Step2.Text = Step2.Text.Replace('.', ',');
                MaxV1.Text = MaxV1.Text.Replace('.', ',');
                MaxV2.Text = MaxV2.Text.Replace('.', ',');

                double X1 = convertTextToDouble(ref Variable1);
                double X2 = convertTextToDouble(ref Variable2);
                double DX1 = convertTextToDouble(ref Step1);
                double DX2 = convertTextToDouble(ref Step2);
                double MaxX1 = convertTextToDouble(ref MaxV1);
                double MaxX2 = convertTextToDouble(ref MaxV2);

                for (; X1 < MaxX1 || X2 < MaxX2; X1 += DX1, X2 += DX2)
                {
                    L_Points.Add(new Point(X1, X2));
                }
            }
            else
            {
                double X1 = convertTextToDouble(ref Variable1);
                double X2 = convertTextToDouble(ref Variable2);

                L_Points.Add(new Point(X1, X2));
            }

            foreach (Point point in L_Points)
            {
                Term.Add(point);

                Graphic.Series[0].Points.AddXY(point.X1, point.Y);
                Graphic.Series[1].Points.AddXY(point.X2, point.Y);
            }
            UpdateInfoInDGV();
        }
        private double convertTextToDouble(ref TextBox TB)
        {
            double output = 0;

            try
            {
                output = Convert.ToDouble(TB.Text);
            }
            catch
            {
                MessageBox.Show("Can`t convert " + TB.Name + ".Text to double.\n0 is result.");
            }

            return output;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Term.Clear();
            Graphic.Series[0].Points.Clear();
            Graphic.Series[1].Points.Clear();
        }
    }
}
