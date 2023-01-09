using System;

namespace StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            string word = "";
            string sumSecretCommand = "";
            char currentLetter = '+';
            string newWord = "";


            while (command != "End")
            {
                command = Console.ReadLine();
                if (command != "End")
                {
                    currentLetter = char.Parse(command);
                    if ((currentLetter >= 65 && currentLetter <= 90) || (currentLetter >= 97 && currentLetter <= 122))
                    {
                        if (currentLetter == 'c' && !(sumSecretCommand.Contains("c")))
                        {
                            sumSecretCommand += char.ToString(currentLetter);

                        }
                        else if (currentLetter == 'o' && !(sumSecretCommand.Contains("o")))
                        {
                            sumSecretCommand += char.ToString(currentLetter);
                        }
                        else if (currentLetter == 'n' && !(sumSecretCommand.Contains("n")))
                        {
                            sumSecretCommand += char.ToString(currentLetter);
                        }
                        else
                        {
                            word += char.ToString(currentLetter);

                        }
                        if (sumSecretCommand.Contains("c") && sumSecretCommand.Contains("o") && sumSecretCommand.Contains("n"))
                        {
                            word += " ";
                            newWord = word;
                            sumSecretCommand = "";
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if (command == "End")
            {
                Console.WriteLine(newWord);
            }



        }
    }
}
