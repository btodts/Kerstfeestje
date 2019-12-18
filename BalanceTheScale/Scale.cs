using System;

namespace BalanceTheScale
{
    public class Scale
    {
        public int Left { get; }
        public int Right { get; }
        public int[] Weights { get; }

        public Scale(int left, int right, int[] weights)
        {
            if (weights.Length > 4)
                throw new InvalidOperationException("The scale can only use 4 weights!");

            Left = left;
            Right = right;
            Weights = weights;
        }

        public string BalanceIt()
        {
            throw new NotImplementedException();
        }
    }
}
