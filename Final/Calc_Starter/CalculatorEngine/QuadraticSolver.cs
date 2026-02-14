using System;
using System.Globalization;

namespace Calculator
{
    public static class QuadraticSolver
    {
        public static string Solve(double a, double b, double c)
        {
            const double eps = 1e-12;

            // a == 0 -> линейное
            if (Math.Abs(a) < eps)
            {
                if (Math.Abs(b) < eps)
                {
                    if (Math.Abs(c) < eps) return "Бесконечно много решений";
                    return "Решений нет";
                }

                double x = -c / b;
                return "Линейное: x=" + x.ToString(CultureInfo.InvariantCulture);
            }

            double D = b * b - 4.0 * a * c;

            if (D < -eps)
            {
                return "D=" + D.ToString(CultureInfo.InvariantCulture) + "; Нет корней";
            }

            if (Math.Abs(D) <= eps)
            {
                double x = -b / (2.0 * a);
                return "D=0; x=" + x.ToString(CultureInfo.InvariantCulture);
            }

            double sqrtD = Math.Sqrt(D);
            double x1 = (-b - sqrtD) / (2.0 * a);
            double x2 = (-b + sqrtD) / (2.0 * a);

            return "D=" + D.ToString(CultureInfo.InvariantCulture)
                 + "; x1=" + x1.ToString(CultureInfo.InvariantCulture)
                 + "; x2=" + x2.ToString(CultureInfo.InvariantCulture);
        }
    }
}

