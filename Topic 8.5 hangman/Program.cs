namespace Topic_8._5_hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();    
            List<string> words = new List<string>();
            string word;
            string guess;
            words.Add("ugliest");
            words.Add("piquant");
            words.Add("front");
            words.Add("knit");
            words.Add("audit");
            words.Add("sort");
            words.Add("paste");
            words.Add("fail");
            words.Add("opine");
            words.Add("astonishing");
            words.Add("proud");
            words.Add("soar");
            words.Add("boundary");
            words.Add("thump");
            words.Add("reply");
            words.Add("unused");
            words.Add("snotty");
            words.Add("solve");
            words.Add("gate");
            words.Add("apples");

            word = words[generator.Next(0, 21)];
            Console.WriteLine("=======|");
            Console.WriteLine("   |   |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("===========");
            Console.WriteLine();
            Console.WriteLine("Guess a letter");
            guess = Console.ReadLine().Trim();
            while (guess.Length != 1)
            {

            }
            
        }
    }
}