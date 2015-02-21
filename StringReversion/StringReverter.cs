namespace StringReversion
{
    internal class StringReverter
    {
        public static string Revert(string inputString)
        {
            var revertedString = "";

            var inputStringLength = inputString.Length;

            for (int i = inputStringLength -1 ; i >= 0 ; i--)
            {
                revertedString += inputString.Substring(i, 1);
            }

            return revertedString;
        }
    }
}
