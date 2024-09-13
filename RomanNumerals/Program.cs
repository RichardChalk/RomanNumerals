namespace RomanNumerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXTRA!
            // Använd en klass med ett bibliotek!
            // var translateRoman = new RomanNumeralsClass();
            // translateRoman.GatherRomanInput();

            // Använd endast Main - Inga övriga metoder
            Console.WriteLine("Ange ett romerskt tal:");
            string romanInput = Console.ReadLine().ToUpper();

            int decimalOutput = 0;

            for (int i = 0; i < romanInput.Length; i++)
            {
                int current = 0;

                // Använd switch för att bestämma värdet av varje romersk siffra
                switch (romanInput[i])
                {
                    case 'I':
                        current = 1;
                        break;
                    case 'V':
                        current = 5;
                        break;
                    case 'X':
                        current = 10;
                        break;
                    case 'L':
                        current = 50;
                        break;
                    case 'C':
                        current = 100;
                        break;
                    case 'D':
                        current = 500;
                        break;
                    case 'M':
                        current = 1000;
                        break;
                    default:
                        Console.WriteLine("Ogiltig romersk siffra");
                        return;
                }

                // Kolla om nästa siffra är större, då ska vi subtrahera nuvarande
                if (i + 1 < romanInput.Length)
                {
                    int next = 0;

                    switch (romanInput[i + 1])
                    {
                        case 'I':
                            next = 1;
                            break;
                        case 'V':
                            next = 5;
                            break;
                        case 'X':
                            next = 10;
                            break;
                        case 'L':
                            next = 50;
                            break;
                        case 'C':
                            next = 100;
                            break;
                        case 'D':
                            next = 500;
                            break;
                        case 'M':
                            next = 1000;
                            break;
                    }

                    if (current < next)
                    {
                        decimalOutput -= current;
                    }
                    else
                    {
                        decimalOutput += current;
                    }
                }
                else
                {
                    decimalOutput += current;
                }
            }

            Console.WriteLine($"Det motsvarande heltalet är: {decimalOutput}");
        }
    }
}

