using System;
using System.Collections.Generic;
using System.Text;

namespace MultMatrix
{
    class Position
    {
        private int n;

        public int N
        {
            get { return n; }
            set { n = value; }
        }

        private int k;

        public int K
        {
            get { return k; }
            set { k = value; }
        }


        public Position(int n, int k)
        {
            N = n;
            K = k;
        }

    }
}
