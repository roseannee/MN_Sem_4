using System.Reflection;
using System.Windows.Forms;

namespace Aproksymacja
{
    internal class Polynomial
    {
        public double ax1 { get; set; }
        public double ax2 { get; set; }
        public double ax3 { get; set; }
        public double ax4 { get; set; }
        public double axr { get; set; }

        public double bx1 { get; set; }
        public double bx2 { get; set; }
        public double bx3 { get; set; }
        public double bx4 { get; set; }
        public double bxr { get; set; }

        public double cx1 { get; set; }
        public double cx2 { get; set; }
        public double cx3 { get; set; }
        public double cx4 { get; set; }
        public double cxr { get; set; }

        public double dx1 { get; set; }
        public double dx2 { get; set; }
        public double dx3 { get; set; }
        public double dx4 { get; set; }
        public double dxr { get; set; }

        public double ax { get; set; }
        public double bx { get; set; }
        public double cx { get; set; }
        public double dx { get; set; }

        public double x1 { get; set; }
        public double x2 { get; set; }
        public double x3 { get; set; }
        public double x4 { get; set; }

        public Polynomial() { }
        public Polynomial(Polynomial mathData)
        {
            if (mathData == null)
                return;

            PropertyInfo[] propInfo = mathData.GetType().GetProperties();

            foreach (PropertyInfo info in propInfo)
            {
                GetType().GetProperty(info.Name).SetValue(this, info.GetValue(mathData));
            }
        }

        public void Calculate()
        {
            //1
            if (ax1 == 0)
            {
                MessageBox.Show("Found 0 in line A!");
                return;
            }

            bx = bx1 / ax1;
            cx = cx1 / ax1;
            dx = dx1 / ax1;

            bx1 = bx1 - bx * ax1;
            bx2 = bx2 - bx * ax2;
            bx3 = bx3 - bx * ax3;
            bx4 = bx4 - bx * ax4;
            bxr = bxr - bx * axr;

            cx1 = cx1 - cx * ax1;
            cx2 = cx2 - cx * ax2;
            cx3 = cx3 - cx * ax3;
            cx4 = cx4 - cx * ax4;
            cxr = cxr - cx * axr;

            dx1 = dx1 - dx * ax1;
            dx2 = dx2 - dx * ax2;
            dx3 = dx3 - dx * ax3;
            dx4 = dx4 - dx * ax4;
            dxr = dxr - dx * axr;

            //2
            if (bx2 == 0)
            {
                MessageBox.Show("Found 0 in line B!");
                return;
            }

            cx = cx2 / bx2;
            dx = dx2 / bx2;

            cx1 = cx1 - cx * bx1;
            cx2 = cx2 - cx * bx2;
            cx3 = cx3 - cx * bx3;
            cx4 = cx4 - cx * bx4;
            cxr = cxr - cx * bxr;

            dx1 = dx1 - dx * bx1;
            dx2 = dx2 - dx * bx2;
            dx3 = dx3 - dx * bx3;
            dx4 = dx4 - dx * bx4;
            dxr = dxr - dx * bxr;

            //3
            if (cx3 == 0)
            {
                MessageBox.Show("Found 0 in line C!");
                return;
            }

            dx = dx3 / cx3;

            dx1 = dx1 - dx * cx1;
            dx2 = dx2 - dx * cx2;
            dx3 = dx3 - dx * cx3;
            dx4 = dx4 - dx * cx4;
            dxr = dxr - dx * cxr;

            //result
            if (dx4 == 0)
            {
                MessageBox.Show("Found 0 in line D!");
                return;
            }

            x4 = dxr / dx4;
            x3 = (cxr - x4 * cx4) / cx3;
            x2 = (bxr - x3 * bx3 - x4 * bx4) / bx2;
            x1 = (axr - x2 * ax2 - x3 * ax3 - x4 * ax4) / ax1;
        }
    }
}
