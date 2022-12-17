using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.DataVisualization.Charting;

namespace _2022._12._13_examen
{
    class number1//первое задание
    {
        public List<double> data1;
        public number1(string FileName)
        {
            StreamReader SR;
            try { SR = new StreamReader(FileName, System.Text.Encoding.Default); }
            catch { throw new Exception(); }
            data1 = new List<double>();
            while (!SR.EndOfStream)
            {
                double buf = double.Parse(SR.ReadLine());
                data1.Add(buf);
            }
        }
        static public double[] reverse(List<double> fl)
        {
            double[] res = new double[fl.Count];
            for (int i = 0; i < fl.Count; i++)
            {
                res[i] = fl[fl.Count - i - 1];
            }
            return res;
        }



    }
    class number2//второе задание
    {
        public List<double> data2;
        public number2(string FileName)
        {
            StreamReader SR;
            try { SR = new StreamReader(FileName, System.Text.Encoding.Default); }
            catch { throw new Exception(); }
            data2 = new List<double>();
            while (!SR.EndOfStream)
            {
                double buf = double.Parse(SR.ReadLine());
                data2.Add(buf);
            }
            data2.Sort();
        }
        

    }
    class number3//третье задание
    {
        public List<double> data3;
        public number3(string FileName)
        {
            StreamReader SR;
            try { SR = new StreamReader(FileName, System.Text.Encoding.Default); }
            catch { throw new Exception(); }
            data3 = new List<double>();
            while (!SR.EndOfStream)
            {
                double buf = double.Parse(SR.ReadLine());
                data3.Add(buf);
            }
        }

    }
    class number4//четвертое задание
    {
        public double[,] data4 = new double[3,3];
        public number4(string FileName)
        {
            int a = 0;
            StreamReader SR;
            try { SR = new StreamReader(FileName, System.Text.Encoding.Default); }
            catch { throw new Exception(); }
            
            while (!SR.EndOfStream)
            {
                string s = SR.ReadLine();
                string[] data44 = s.Split(' ', '\t', ',');
                for(int i = 0; i < 2; i++)
                {
                    data4[a, i] = double.Parse(data44[i]);
                }
                a++;
            }
        }
        static public double sum(double[,] fl)
        {
            double res = 0;
            for(int i = 0; i < fl.GetLength(0); i++)
            {
                for(int j = 0; j < fl.GetLength(1); j++)
                {
                    res += fl[i, j];
                }
            }
            return res;
        }
    }
    class number5//пятое задание
    {
        public double[,] data5 = new double[3, 3];
        public number5(string FileName)
        {
            int a = 0;
            StreamReader SR;
            try { SR = new StreamReader(FileName, System.Text.Encoding.Default); }
            catch { throw new Exception(); }

            while (!SR.EndOfStream)
            {
                string s = SR.ReadLine();
                string[] data55 = s.Split(' ', '\t', ',');
                for (int i = 0; i < 2; i++)
                {
                    data5[a, i] = double.Parse(data55[i]);
                }
                a++;
            } 
        }
        static public double maxx(double[,] fl)
        {
            double max = 0;
            double ns = 0;
            for (int i = 0; i < fl.GetLength(0); i++)
            {
                double res = 0;
                for (int j = 0; j < fl.GetLength(1); j++)
                {
                    res += fl[i, j];
                }
                if (res > max) max = res;
            }
            for (int k = 1; k < 3; k++)
                {
                    if (max == fl[k, 0] + fl[k, 1]) ns = k+1;
                }
            return ns;
        }
    }
    class number6//шестое задание
    {
        public double[,] data6 = new double[3, 3];
        public number6(string FileName)
        {
            int a = 0;
            StreamReader SR;
            try { SR = new StreamReader(FileName, System.Text.Encoding.Default); }
            catch { throw new Exception(); }

            while (!SR.EndOfStream)
            {
                string s = SR.ReadLine();
                string[] data66 = s.Split(' ', '\t', ',');
                for (int i = 0; i < 2; i++)
                {
                    data6[a, i] = double.Parse(data66[i]);
                }
                a++;
            }
        }
        static public double[,] obmen(double[,] fl, int a, int b)
        {
            double[] buf = new double[2];
            buf[0] = fl[a,0];
            buf[1] = fl[a,1];
            fl[a, 0] = fl[b, 0];
            fl[a,1] = fl[b, 1];
            fl[b, 0] = buf[0];
            fl[a,1] = buf[1];
            return fl;
        }
        static public void saverr(double[,] fl)
        {
            StreamWriter SW = new StreamWriter("save1.txt");
            for(int i = 0; i < fl.GetLength(0); i++)
            {
                for(int j = 0; j < fl.GetLength(1); j++)
                {
                    SW.Write(fl[i,j]);
                    SW.Write(' ');
                }
                SW.WriteLine();
            }
            SW.Close();

        }
    }
    class number7//седьмое задание
    {
        static public double[,] data(double a, double b, double c)
        {
            double[,] res = new double[100, 100];
            for(int i = 0; i < 100; i++)
            {
                res[i, 0] = i-50;
                res[i, 1] = a * (i-50) * (i-50) + b * (i-50) + c;
            }
            return res;
        }
        static public void Draw7(double[,] fl, Chart CC)
        {
            int a = 1;
            CC.Series[0].Points.Clear();
            CC.Series[0].ChartType = SeriesChartType.Line;
            for(int i = 0; i < 100; i++)
            {
                CC.Series[0].Points.AddXY(fl[i,0], fl[i,1]);
            }
        }
    }
    class number8//восьмое задание
    {
        private double x;
        public double X
        {get { return x; } set {x = value;} }
        private double y;
        public double Y
        { get { return y; } set { y = value; } }
        public number8(double ix, double iy)
        {
            X = ix;
            Y = iy;
        }
        static public double rasst(number8 a, number8 b)
        {
            double res;
            res = Math.Sqrt(Math.Pow(a.X-b.X, 2) + Math.Pow(a.Y-b.Y, 2));
            return res;
        }
    }
    class number9//девятое задание
    {
        private double x;
        public double X
        { get { return x; } set { x = value; } }
        private double _data;
        public double Data
        { get { return _data; } set { _data = value; } }
        public number9(double ix, double data)
        {
            X = ix;
            Data = data;
        }
    }
    class Magnumber9
    {
        public List<number9> MagList;
        public Magnumber9(string FileName)
        {
            StreamReader SR;
            try { SR = new StreamReader(FileName, System.Text.Encoding.ASCII); }
            catch { throw new Exception(); }
            MagList = new List<number9>();
            while (!SR.EndOfStream)
            {
                string buf = SR.ReadLine();

                string[] bufarray = buf.Split(' ', '\t');
                try
                {
                    MagList.Add(new number9(double.Parse(bufarray[0]), double.Parse(bufarray[1])));
                }
                catch (Exception ex) { throw new Exception("Ошибка в файле, в строке:" + ex); }
            }
            SR.Close();


        }
        static public void Drawgraphics(List<number9> mf, Chart CC)
        {
            CC.Series[0].Points.Clear();
            CC.ChartAreas[0].AxisY.IsLogarithmic = false;
            CC.ChartAreas[0].AxisX.IsLogarithmic = false;
            CC.Series[0].ChartType = SeriesChartType.Line;
            CC.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            CC.ChartAreas[0].AxisY.IsStartedFromZero = false;
            CC.ChartAreas[0].AxisX.LabelStyle.Format = "HH: mm";
            foreach (number9 el in mf)
            {
                CC.Series[0].Points.AddXY(el.X, el.Data);
            }
        }
    }
    class number10//десятое задание
    {
        static public TimeSpan razn(DateTime t1, DateTime t2)
        {
            TimeSpan res = new TimeSpan(0, 00, 00);
            res = t1.Subtract(t2);
            return res;
        }
    }
    class number11//одинадцатое задание
    {
        public List<DateTime> data11;
        public number11(string FileName)
        {
            StreamReader SR;
            try { SR = new StreamReader(FileName, System.Text.Encoding.Default); }
            catch { throw new Exception(); }
            data11 = new List<DateTime>();
            while (!SR.EndOfStream)
            {
                DateTime buf = DateTime.Parse(SR.ReadLine());
                data11.Add(buf);
            }
        }
        static public DateTime maxdt(List<DateTime> fl)
        {
            DateTime dt = DateTime.MinValue;
            for(int i = 0; i < fl.Count; i++)
            {
                if (fl[i] > dt) dt = fl[i];
            }
            return dt;
        }
    }
    class number12//двенадцатое задание
    {
        static public double[,] parab(double a, double b, double c)
        {
            double[,] res = new double[100, 100];
            for (int i = 0; i < 100; i++)
            {
                res[i, 0] = i - 50;
                res[i, 1] = a * (i - 50) * (i - 50) + b * (i - 50) + c;
            }
            return res;
        }
        static public void svpr(double[,] fl)//функция, сохраняющая параболу
        {
            StreamWriter SW = new StreamWriter("save1.txt");
            for (int i = 0; i < 100; i++)
            {
                SW.Write(fl[i,0]);
                SW.Write(" ");
                SW.WriteLine(fl[i,1]);
            }
            SW.Close();
        }
    }
    class func//некоторые функции, встречаются в нескольких заданиях
    {
        static public void saver(double[] fl)
        {
            StreamWriter SW = new StreamWriter("save1.txt");
            for (int i = 0; i < fl.Length; i++)
            {
                SW.WriteLine(fl[i]);
            }
            SW.Close();
        }
        static public void Draw(double[] fl, Chart CC)
        {
            int a = 1;
            CC.Series[0].Points.Clear();
            CC.Series[0].ChartType = SeriesChartType.Line;
            foreach (double el in fl)
            {
                CC.Series[0].Points.AddXY(a, el);
                a++;
            }
        }
        static public double[] assign(List<double> fl)
        {
            double[] res = new double[fl.Count];
            for (int i = 0; i < fl.Count; i++)
            {
                res[i] = fl[i];
            }
            return res;
        }
    }
}