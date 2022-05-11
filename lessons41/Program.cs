namespace lessons41
{
    internal class Program
    {

        static int SumArray(int[] myArray, int i = 0)
        {


            if (i >= myArray.Length)
                return 0;

            int result = SumArray(myArray, i + 1);
            return myArray[i] + result;



        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 5 };

            int result = SumArray(myArray);
        }
    }
}
