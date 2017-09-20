using System;

namespace CreatingArraysPart2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           string zig = "You can get what you want our of your life " +
                "if you help enough other people get what they want out of theirs";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            // here we are converting the string into characters so that we can revers every character
            // using array.reverse so that it will print the message backwards
            foreach (char zigChar in charArray)
                // for each allows this code to be ran for each of the things in the array
                Console.Write(zigChar);

            Console.ReadLine();



        }
    }
}
