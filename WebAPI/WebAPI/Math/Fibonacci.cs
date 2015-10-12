using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Math
{
    using System.Numerics;

    public static class Fibonacci
    {
        public static BigInteger Get(int n)
        {
            if (n <= 0) return BigInteger.One;

            BigInteger n1 = 1;
            BigInteger n2 = 1;

            BigInteger n3 = 0;
            for (long i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            return n3;
        }
    }
}