using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerCss
{
    class CommonFunctions
    {
        internal static List<int> Factor(int n1)
        {
            List<int> n1FList = new List<int>();
            n1FList.Add(1);n1FList.Add(n1);
            int n1Prime = 0;
            for (int i = 2; i < n1; i++)
            {
                if (n1 % i == 0)
                {
                    n1FList.Add(i);
                    n1Prime = n1 / i;
                    break;
                }
            }
        redo:
            for (int i = 2; i <= n1Prime; i++)
            {
                if (n1Prime % i == 0)
                {
                    n1FList.Add(i);
                    n1Prime = n1Prime / i;
                    goto redo;
                }
            }

            n1FList = n1FList.OrderByDescending(p => p).ToList();
            return n1FList;
        }

        public static int GCD(int n1, int n2)
        {
            int result = 0;
            List<int> n1Fs = Factor(n1);
            List<int> n2Fs = Factor(n2);
            foreach(int a in n1Fs)
            {
                if (n2Fs.Contains(a) && a > result) { result = a; }
            }


            return result;
        }

        internal static List<long> Factor(long n1)
        {
            List<long> n1FList = new List<long>();
            n1FList.Add(1); n1FList.Add(n1);
            long n1Prime = 0;
            for (long i = 2; i < n1; i++)
            {
                if (n1 % i == 0)
                {
                    n1FList.Add(i);
                    n1Prime = n1 / i;
                    break;
                }
            }
        redo:
            for (long i = 2; i <= n1Prime; i++)
            {
                if (n1Prime % i == 0)
                {
                    n1FList.Add(i);
                    n1Prime = n1Prime / i;
                    goto redo;
                }
            }

            n1FList = n1FList.OrderByDescending(p => p).ToList();
            return n1FList;
        }

        public static long GCD(long n1, long n2)
        {
            long result = 0;
            List<long> n1Fs = Factor(n1);
            List<long> n2Fs = Factor(n2);
            foreach (long a in n1Fs)
            {
                if (n2Fs.Contains(a) && a > result) { result = a; }
            }


            return result;
        }

        public static bool CheckPrime(long pr)
        {
            for (long i = 2; i < pr; i++)
            {
                if (pr % i == 0) { return false; }
            }
            return true;
        }
    }
}
