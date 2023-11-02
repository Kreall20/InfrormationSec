using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class Analysis
    {
        const string ALPHABET = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public static Dictionary<char, double> RUSSIANDICT = new Dictionary<char, double>
        {
            { 'о', 10.98},
            { 'е' , 8.45 },
            { 'а' , 8.01 },
            { 'и' , 7.37 },
            { 'н' , 6.70 },
            { 'т' , 6.32 },
            { 'с' , 5.47 },
            { 'р' , 4.75},
            { 'в' , 4.54 },
            { 'л' ,  4.34},
            { 'к' ,  3.49},
            { 'м' ,  3.21},
            { 'д' ,  2.98},
            { 'п' ,  2.81},
            { 'у' ,  2.62},
            { 'я' ,  2.01},
            { 'ы' ,  1.90},
            { 'ь' ,  1.74},
            { 'г' ,  1.69},
            { 'з' ,  1.64},
            { 'б' ,  1.59},
            { 'ч' ,  1.45},
            { 'й' ,  1.21},
            { 'х' ,  0.97},
            { 'ж' ,  0.94},
            { 'ш' ,  0.72},
            { 'ю' ,  0.64},
            { 'ц' ,  0.49},
            { 'щ' ,  0.36},
            { 'э' ,  0.33},
            { 'ф' ,  0.27},
            { 'ъ' ,  0.04},
            { 'ё' ,  0.02}
        };

        public static Dictionary<char, double> countAppearencesOfLetter(string text)
        {
            Dictionary<char, int> letterCounts = new Dictionary<char, int>(ALPHABET.Length);

            int totalCharacters = 0;

            HashSet<char> processedLetters = new HashSet<char>();

            foreach (char letter in text)
            {
                totalCharacters++;
                if (char.IsLetter(letter))
                {
                    char lowercaseLetter = char.ToLower(letter);
                    if (!processedLetters.Contains(lowercaseLetter) && ALPHABET.Contains(lowercaseLetter))
                    {
                        processedLetters.Add(lowercaseLetter);
                    }

                    if (letterCounts.ContainsKey(lowercaseLetter) && ALPHABET.Contains(lowercaseLetter))
                    {
                        letterCounts[lowercaseLetter]++;
                    }
                    else
                    {
                        letterCounts[lowercaseLetter] = 1;
                    }
                }
            }

            Dictionary<char, double> letterProbabilities = new Dictionary<char, double>(ALPHABET.Length);

            foreach (var kvp in letterCounts)
            {
                letterProbabilities[kvp.Key] = ((double)kvp.Value / totalCharacters) * 100;
            }

            return letterProbabilities;
        }
    }
}
