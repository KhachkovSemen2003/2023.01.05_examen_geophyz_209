using _2022._12._13_examen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _2022._12._14_ekz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        number1 file1;
        number2 file2;
        number3 file3;
        number4 file4;
        double a4;
        number5 file5;
        double a5;
        number6 file6;
        double [,]a6;
        double [,]a7;
        number8 file8;
        number8 file88;
        double a8;
        Magnumber9 file9;
        DateTime num10;
        DateTime numb10;
        TimeSpan razni10;
        DateTime num11;
        number11 numbe11;
        double[,] parabola;
        private void button1_Click(object sender, EventArgs e)
        {
            file1 = new number1("file2.txt");
            double[] res1 = new double[file1.data1.Count];
            res1 = number1.reverse(file1.data1);
            func.saver(res1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            file2 = new number2("file2.txt");
            double[] res2 = new double[file2.data2.Count];
            res2 = func.assign(file2.data2);
            func.saver(res2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            file3 = new number3("file2.txt");
            double[] res3 = new double[file3.data3.Count];
            res3 = func.assign(file3.data3);
            func.Draw(res3, chart_run);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            file4 = new number4("file_2ms.txt");
            a4 = number4.sum(file4.data4);
            label4.Text = a4.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            file5 = new number5("file_2ms.txt");
            a5 = number5.maxx(file5.data5);
            label4.Text = a5.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = Int16.Parse(textBox_a.Text);
            int b = Int16.Parse(textBox_b.Text);
            file6 = new number6("file_2ms.txt");
            a6 = number6.obmen(file6.data6, a-1, b-1);
            number6.saverr(a6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxa.Text);
            double b = double.Parse(textBoxb.Text);
            double c = double.Parse(textBoxc.Text);
            a7 = number7.data(a, b, c);
            number7.Draw7(a7, chart_run);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(textBox_x1.Text);
            double y1 = double.Parse(textBox_y1.Text);
            double x2 = double.Parse(textBox_x2.Text);
            double y2 = double.Parse(textBox_y2.Text);
            //file8.X = x1; file8.Y = y1;file8.X = x2; file8.Y = y2;
            file8 = new number8(x1, y1);
            file88 = new number8(x2, y2);
            a8 = number8.rasst(file8, file88);
            label4.Text = a8.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            file9 = new Magnumber9("file_mag.txt");
            Magnumber9.Drawgraphics(file9.MagList, chart_run);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num10 = DateTime.Parse(textBox_time1.Text);
            numb10 = DateTime.Parse(textBox_time2.Text);
            razni10 = number10.razn(num10, numb10);
            label4.Text = razni10.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numbe11 = new number11("file_time.txt");
            num11 = number11.maxdt(numbe11.data11);
            label4.Text = num11.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            parabola = new double[100, 100];
            double a = double.Parse(textBox_aa.Text);
            double b = double.Parse(textBox_bb.Text);
            double c = double.Parse(textBox_cc.Text);
            parabola = number12.parab(a, b, c);
            number12.svpr(parabola);
        }
    }
}
