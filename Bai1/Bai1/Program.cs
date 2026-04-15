using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
// Cài đặt lớp cơ sở là lớp thường, có thể tạo đối tượng của lớp cơ sở, phương thức đa hình virtual
{
    public class HinhVe
    {
        public virtual double GetArea()
        {
            return 0;
        }
    }

    public class HinhTron : HinhVe
    {
        public double Radius { get; set; }

    public HinhTron(double r)
        {
            Radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class HinhVuong : HinhVe
    {
        public double Dai { get; set; }

    public double Rong { get; set; }

    public HinhVuong(double d = 0, double r = 0)
        {
            Dai = d;
            Rong = r;
        }

        public override double GetArea()
        {
            return Dai * Rong;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HinhVe> hv = new List<HinhVe>
{
    new HinhTron(3),
    new HinhVuong(5,3)
};
            foreach (var s in hv)
                Console.WriteLine($"Area={s.GetArea()}");
        }
    }
}
