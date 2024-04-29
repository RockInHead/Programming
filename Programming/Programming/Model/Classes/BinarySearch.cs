namespace Programming.Model.Classes
{
    internal class BinarySearch
    {
        public int BinarySearchFunction(int[] array, int x)
        {
            int L = 0;
            int R = array.Length - 1;

            while (L <= R)
            {
                int Mid = (L + R) / 2;
                if (array[Mid] < x)
                {
                    L = Mid + 1;
                }
                else if (array[Mid] > x)
                {
                    R = Mid - 1;
                }
                else
                {
                    return Mid;
                }
            }
            return -1;
        }
    }
}
