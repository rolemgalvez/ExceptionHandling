namespace HomeworkThirteen
{
    public static class Section
    {
        public static void Welcome()
        {
            Console.WriteLine("Homework Thirteen");
            Console.WriteLine("-----------------");
            Console.WriteLine();
        }

        public static void Process()
        {
            try
            {
                LoopSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error from Process:");
                Console.WriteLine(ex.Message);
            }
        }

        private static void LoopSomething()
        {
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine($"i = {i};");
                ThrowException(i);
            }
        }

        private static void ThrowException(int i)
        {
            if (i == 5)
            {
                throw new Exception("Such exception just been triggered.");
            }
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
