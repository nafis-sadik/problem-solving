namespace Solutions
{
    public static class Extensions
    {
        /// <summary>
        /// Displays the contents of a dictionary by printing each key-value pair to the console.
        /// </summary>
        public static void ShowDict(this Dictionary<int, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"* dict[{kvp.Key}] * {kvp.Value} *");
            }
        }

        /// <summary>
        /// Swaps the elements at two specified indices in an integer array.
        /// </summary>
        /// <param name="nums">The array in which elements will be swapped.</param>
        /// <param name="xIndex">The index of the first element to swap.</param>
        /// <param name="yIndex">The index of the second element to swap.</param>        
    }

    public static class Print
    {
        public static void Swap(this int[] nums, int xIndex, int yIndex)
        {
            int value = nums[xIndex];
            nums[xIndex] = nums[yIndex];
            nums[yIndex] = value;
        }

        public static void Success(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Error(string text)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write(text); // Print without newline
            Console.ResetColor(); // Reset colors immediately after

            Console.WriteLine(); // Move to the next line
        }

        public static void Warning(string message)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write(message); // Print without newline
            Console.ResetColor(); // Reset colors immediately after

            Console.WriteLine(); // Move to the next line
        }
    }
}