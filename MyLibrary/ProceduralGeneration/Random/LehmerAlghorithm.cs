using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary_DotNETstd_2_1
{
    public class LehmerAlghorithm
    {
        private const int a = 16807;
        private const int m = 2147483647;
        private const int q = 127773;
        private const int r = 2836;
        private int seed;

        public LehmerAlghorithm(int seed)
        {
            if (seed <= 0 || seed == int.MaxValue)
                throw new Exception("Bad seed");
            this.seed = seed;
        }

        public double Next()
        {
            int hi = seed / q;
            int lo = seed % q;
            seed = (a * lo) - (r * hi);
            if (seed <= 0)
                seed = seed + m;
            return (seed * 1.0) / m;
        }
    }
}
