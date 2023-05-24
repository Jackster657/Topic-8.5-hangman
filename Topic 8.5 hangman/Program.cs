using System;

namespace Topic_8._5_hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();    
            List<string> words = new List<string>();
            string word, word2 = "";
            string guess;
            int lives = 6;
            int lettersGuessed = 0;
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
            words.Add("harm");
            words.Add("chalk");
            words.Add("issue");
            words.Add("routine");
            words.Add("Bible");
            words.Add("surround");
            words.Add("offer");
            words.Add("choose");
            words.Add("conceive");
            words.Add("remunerate");
            words.Add("coffee");
            words.Add("lip");
            words.Add("snail");
            words.Add("gift");
            words.Add("dialogue");
            words.Add("metal");
            words.Add("greeting");
            words.Add("dismiss");
            words.Add("eaux");
            words.Add("frog");



            word = words[generator.Next(words.Count)];
            
            for (int i = 0; i < word.Length; i++)
            {
                word2 += "_ ";
            }
            Console.WriteLine("=======|");
            Console.WriteLine("   |   |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("===========");
            Console.WriteLine();
            while (lives > 0 || lettersGuessed == word.Length)
            {
                // Console.WriteLine(word);
                Console.WriteLine();
                Console.WriteLine("Guess a letter");
                guess = Console.ReadLine().Trim();
                while (guess.Length != 1)
                {
                    if (guess.Length != 1)
                    {
                        Console.WriteLine("Guess is more than one character");
                    }
                    guess = Console.ReadLine().Trim().ToLower();
                }

                if (word.Contains(guess))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guess[0])
                        {
                            word2 = word2.Remove(i * 2,1);
                            word2 = word2.Insert(i * 2, Convert.ToString(guess[0]));
                            lettersGuessed++;

                        }

                    }
                }
                else if (word.IndexOf(guess) == -1)
                {
                    lives--;

                }
                if (lettersGuessed == word.Length)
                {
                    Console.WriteLine("Congrats, you win");
                }
                Console.WriteLine();
                Console.WriteLine(word2);
                switch (lives)
                {
                    case 6:
                        Console.WriteLine("=======|");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("===========");
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("=======|");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("   O   |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("===========");
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("=======|");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("   O   |");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("===========");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("=======|");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("   O   |");
                        Console.WriteLine("   |\\  |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("===========");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("=======|");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("   O   |");
                        Console.WriteLine("  /|\\  |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("===========");
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.WriteLine("=======|");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("   O   |");
                        Console.WriteLine("  /|\\  |");
                        Console.WriteLine("    \\  |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("===========");
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine("=======|");
                        Console.WriteLine("   |   |");
                        Console.WriteLine("   O   |");
                        Console.WriteLine("  /|\\  |");
                        Console.WriteLine("  / \\  |");
                        Console.WriteLine("       |");
                        Console.WriteLine("       |");
                        Console.WriteLine("===========");
                        Console.WriteLine();
                        Console.WriteLine("The word was " + word);
                        break;
                }
            }
            
            
        }
    }
}