namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The algorithm in the Readme contains an error
            // Rewrite the algorithm in C# bellow fixing the error
            // Show the test outputs for the test table in the Readme
            // Put your evidence where it says Do the coding task in C#


            bool validChoice = false;
            int startYear = -1, endYear = -1, difference = -1;

            do
            {
                Console.Write("Enter a start year: ");
                string input1 = Console.ReadLine();

                Console.Write("Enter an end year: ");
                string input2 = Console.ReadLine();

                if (!IsValidNumber(input1) || !IsValidNumber(input2))
                {
                    Console.WriteLine("Invalid input. Please enter numbers.");
                    continue;
                }

                startYear = Convert.ToInt32(input1);
                endYear = Convert.ToInt32(input2);

                if (startYear >= endYear)
                    Console.WriteLine("Start year must be before end year.");
                else if (startYear >= 2000)
                    Console.WriteLine("Start year must be before 2000.");
                else
                    validChoice = true;

            } while (!validChoice);

            difference = endYear - startYear;
            Console.WriteLine(difference);
        }

        static bool IsValidNumber(string input)
        {
            foreach (char c in input)
                if (c < '0' || c > '9') return false;
            return true;
        }
    }
}
