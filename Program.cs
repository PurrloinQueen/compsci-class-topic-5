namespace topic_5___desicion_structures_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personOne, personTwo, personThree;
            Random ageGen = new Random();
            personOne = ageGen.Next(1, 51);
            personTwo = ageGen.Next(1, 51);
            personThree = ageGen.Next(1, 51);

            if ( personOne >= personTwo )
            {
                Console.WriteLine("Person 1 is older than Person 2.");
            }
            else if (personTwo >= personOne)
            {
                Console.WriteLine("Person 2 is older than Person 1.");
            }
            else
            {
                Console.WriteLine("Person 1 and Person 2 are the same age.");
            }

            if (personTwo >= personThree)
            {
                Console.WriteLine("Person 2 is older than Person 3.");
            }
        }
    }
}