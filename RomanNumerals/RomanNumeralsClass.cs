using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeralsClass
    {
        public void GatherRomanInput()
        {
            Console.WriteLine("Ange ett romerskt tal:");
            string roman = Console.ReadLine().ToUpper();
            int result = RomanToInt(roman);
            Console.WriteLine($"Det motsvarande heltalet är: {result}");
        }
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // Om nuvarande tecken är mindre än nästa... ska det subtraheras
                if (i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i + 1]])
                {
                    total -= romanMap[s[i]];
                }
                // annars... ska det adderas
                else
                {
                    total += romanMap[s[i]];
                }
            }
            return total;
        }
    }
}
