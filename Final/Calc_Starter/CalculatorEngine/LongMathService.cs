using System;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    public static class LongMathService
    {
        public static Task<double> FactorialAsync(int n, CancellationToken ct, int delayMs = 30)
        {
            return Task.Run(() =>
            {
                if (n < 0) throw new ArgumentOutOfRangeException(nameof(n));
                if (n > 170) throw new OverflowException("n too large for double factorial");

                double res = 1.0;
                for (int i = 2; i <= n; i++)
                {
                    ct.ThrowIfCancellationRequested();
                    Thread.Sleep(delayMs); // симуляция долгой операции
                    res *= i;
                }
                return res;
            }, ct);
        }
    }
}

