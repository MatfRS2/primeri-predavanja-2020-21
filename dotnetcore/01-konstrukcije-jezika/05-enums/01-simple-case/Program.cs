
using System;

namespace RS2.SimpleEnum
{
    enum Color
    {
        Red,
        Green = 10,
        Blue
    }

    class Test
    {
        static string StringFromColor(Color c)
        {
            switch (c)
            {
                case Color.Red:
                    return String.Format("Red = {0}", (int)c);

                case Color.Green:
                    return String.Format("Green = {0}", (int)c);

                case Color.Blue:
                    return String.Format("Blue = {0}", (int)c);

                default:
                    return "Invalid color";
            }
        }

        static void Main()
        {
            Console.WriteLine(StringFromColor(Color.Red));
            Console.WriteLine(StringFromColor(Color.Green));
            Console.WriteLine(StringFromColor(Color.Blue));
        }

    }
}

