using System;

namespace Aproksymacja
{
    internal class Approximation
    {
        public double[] xArray { get; set; }
        public double[] yArray { get; set; }

        public double[] x2Array => ArrayPow(xArray, 2);
        public double[] x3Array => ArrayPow(xArray, 3);
        public double[] x4Array => ArrayPow(xArray, 4);
        public double[] x5Array => ArrayPow(xArray, 5);
        public double[] x6Array => ArrayPow(xArray, 6);

        public double[] xyArray => ArrayMultiply(xArray, yArray);
        public double[] x2yArray => ArrayMultiply(x2Array, yArray);
        public double[] x3yArray => ArrayMultiply(x3Array, yArray);

        private double[] ArrayPow(double[] array, double pow)
        {
            double[] result = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = Math.Pow(array[i], pow);
            }

            return result;
        }

        private double[] ArrayMultiply(double[] array, double[] multiplyArray)
        {
            double[] result = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * multiplyArray[i];
            }

            return result;
        }

        private double SumArray(double[] array)
        {
            double result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }

            return result;
        }

        public Approximation(double[] xx, double[] yy)
        {
            xArray = xx;
            yArray = yy;
        }

        public override string ToString()
        {
            Polynomial polynomial = new Polynomial()
            {
                ax1 = xArray.Length,
                ax2 = SumArray(xArray),
                ax3 = SumArray(x2Array),
                ax4 = SumArray(x3Array),
                axr = SumArray(yArray),

                bx1 = SumArray(xArray),
                bx2 = SumArray(x2Array),
                bx3 = SumArray(x3Array),
                bx4 = SumArray(x4Array),
                bxr = SumArray(xyArray),

                cx1 = SumArray(x2Array),
                cx2 = SumArray(x3Array),
                cx3 = SumArray(x4Array),
                cx4 = SumArray(x5Array),
                cxr = SumArray(x2yArray),

                dx1 = SumArray(x3Array),
                dx2 = SumArray(x4Array),
                dx3 = SumArray(x5Array),
                dx4 = SumArray(x6Array),
                dxr = SumArray(x3yArray)
            };

            polynomial.Calculate();

            return $"{Math.Round(polynomial.x1, 3)} * x^3 + " +
                $"{Math.Round(polynomial.x2, 3)} * x^2 + {Math.Round(polynomial.x3, 3)}" + 
                $"* x + {Math.Round(polynomial.x4, 3)}";
        }
    }
}
