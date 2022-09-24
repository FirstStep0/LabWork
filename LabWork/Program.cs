using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork
{
    public class item
    {
        public int n;
        public double x;
        public double v;
        public double v2;
        public double vfin;

    };
    static class Program
    {
        public static double f1(double x, double v)
        {
            return x * x;
        }
        public delegate double func(double x, double v);
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void setTable(DataTable table, List<item> list) {
             
        }
        public static double RK4_step(double x, double v, double h, func f)
        {
            double k1 = f(x, v);
            double k2 = f(x + h / 2, v + h * k1 / 2);
            double k3 = f(x + h / 2, v + h * k2 / 2);
            double k4 = f(x + h, v + h * k3);
            return v + h * (k1 + 2.0 * k2 + 2.0 * k3 + k4) / 6;
        }
        public static void method_RK4(double x0, double b, double u0, double h0, int nmax, double eps, double klp, func f)
        {
            List<item> items = new List<item>();
            double x = x0;
            double v = u0;
            double h = h0;
        }
    }
}
