using System;

namespace System_of_equations
{
    internal class Gauss_Elimination
    {
        public static int Solve(double[,] A, double[] B, double[] X, double eps)
        {
            int i, j, k, N, M, R;
            double T, MA, a1 = 1.0;
            double ZT, ZS;

            N = A.GetLength(0) - 1; M = A.GetLength(1) - 1; R = B.Length - 1;

            if (N == M && N == R)
            {
                for (i = 1; i <= N; i++)
                {
                    T = Math.Abs(A[i, i]);
                    k = i;

                    for (j = i + 1; j <= N; j++)
                    {
                        MA = Math.Abs(A[j, i]);

                        if (MA > T)
                        {
                            T = MA;
                            k = j;
                        }
                    }

                    if (T < eps)
                    {
                        return -1;
                    }

                    if (i == k)
                    {
                        ZT = A[i, i];
                    }
                    else
                    {
                        ZS = B[k];
                        B[k] = B[i];
                        B[i] = ZS;

                        ZT = A[k, i];

                        for (j = N; j >= i; j--)
                        {
                            ZS = A[k, j];
                            A[k, j] = A[i, j];
                            A[i, j] = ZS;
                        }
                    }

                    ZT = a1 / ZT;
                    A[i, i] = ZT;

                    for (j = i + 1; j <= N; j++)
                    {
                        ZS = A[j, i] * ZT;
                        B[j] -= B[i] * ZS;

                        for (k = i + 1; k <= N; k++)
                        {
                            A[j, k] -= A[i, k] * ZS;
                        }
                    }
                }

                for (i = N; i >= 1; i--)
                {
                    ZT = B[i];

                    for (j = i + 1; j <= N; j++)
                    {
                        ZT -= A[i, j] * X[j];
                    }

                    X[i] = ZT * A[i, i];
                }
            }

            return 0;
        }
    }
}
