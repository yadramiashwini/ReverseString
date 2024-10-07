namespace ReverseString
{
    public class StringReverse
    {
        public static string ReverseString(string s)
        {
            char[] ReversedArr = s.ToCharArray();

            Array.Reverse(ReversedArr);

            return new string(ReversedArr);

        }
        public static bool isPalindrome(string s)
        {
            if (s == ReverseString(s))
            {
                return true;
            }
            return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string:");
            string input = Console.ReadLine();
        
            string str = ReverseString(input);
            Console.WriteLine("reversed string is:"+str);

            if (isPalindrome(input) == false)
            {
                Console.WriteLine("not a palindrome");
            }
            else
            {
                Console.WriteLine("palindrome");
            }
        }
    }
}
