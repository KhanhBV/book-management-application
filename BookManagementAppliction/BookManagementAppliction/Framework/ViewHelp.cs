using System;
namespace BookManagementAppliction.Framework
{
    public static class ViewHelp
    {
        public static void WriteLine(string message, ConsoleColor color, bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            if (resetColor)
                Console.ResetColor();
        }

        public static void Write(string message, ConsoleColor color = ConsoleColor.Blue, bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            if (resetColor)
                Console.ResetColor();
        }

        public static bool InputBool(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.Blue)
        {
            Write($"{label} [y/n]: ", labelColor);
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            bool @char = key.KeyChar == 'y' || key.KeyChar == 'Y' ? true : false;
            return @char;
        }

        public static bool InputBool(string label, bool oldValue, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.Blue)
        {
            Write($"{label}: ", labelColor);
            WriteLine(oldValue.ToString("y/n"), ConsoleColor.Yellow);
            Write("New Value >> ", ConsoleColor.Green);
            Console.ForegroundColor = valueColor;
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str)) return oldValue;
            return str.ToBool();
        }

        public static int InputInt(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.Blue)
        {
            while (true)
            {
                var str = InputString(label, labelColor, valueColor);

                var result = int.TryParse(str, out int i);
                if (result)
                {
                    return i;
                }
            }

        }

        public static int InputInt(string label, int oldValue, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.Magenta)
        {
            Write($"{label}: ", labelColor);
            WriteLine($"{oldValue}", ConsoleColor.Yellow);
            Write("New value >> ", ConsoleColor.Blue);
            Console.ForegroundColor = valueColor;
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str)) return oldValue;
            if (str.ToInt(out int i)) return i; //su dung phuong thuc mo rong ToInt
            return oldValue;
        }

        public static string InputString(String label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.Blue)
        {
            Write($"{label}: ", labelColor, false);
            Console.ForegroundColor = valueColor;
            string value = Console.ReadLine();
            Console.ResetColor();
            return value;
        }

        public static string InputString(string label, string oldValue, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.Blue)
        {
            Write($"{label}: ", labelColor);
            WriteLine(oldValue, ConsoleColor.Yellow);
            Write("New value >> ", ConsoleColor.Green);
            Console.ForegroundColor = valueColor;
            string newValue = Console.ReadLine();
            return string.IsNullOrEmpty(newValue.Trim()) ? oldValue : newValue;
        }
    }
}
