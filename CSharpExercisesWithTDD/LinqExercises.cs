namespace CSharpExercisesWithTDD
{
    /// <summary>
    /// This class will handle the methods for exercises on this page:
    /// https://www.csharpexercises.com/linq
    /// </summary>
    public static class LinqExercises
    {
        #region Easy

        /// <summary>
        /// Last Word Containing Letter
        /// Return the last word that contains 'e' after sorting the words alphabetically.
        /// https://www.csharpexercises.com/linq/exercise/last-word-containing-letter
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string LastWordContainingLetter(string[] words)
        {
            return words.OrderBy(w => w).LastOrDefault(w => w.Contains('e'))!;
        }

        /// <summary>
        /// Minimum Number
        /// Returns words at least 5 characters long and make them uppercase.
        /// https://www.csharpexercises.com/linq/exercise/minimum-length
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string[] MinimumLength(string[] words)
        {
            return words.Where(s => s.Length > 5).Select(s => s.ToUpper()).ToArray();
        }

        /// <summary>
        /// Numbers from range
        /// Return all numbers greater than thirty and less than 100
        /// https://www.csharpexercises.com/linq/exercise/numbers-from-range
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static List<int> NumbersFromRange(int[] numbers)
        {
            return numbers.Where(x => x > 30 && x < 100).ToList();
        }

        /// <summary>
        /// Replace Substring
        /// Replaces 'ea' substring with astersik (*) in given list of words.
        /// https://www.csharpexercises.com/linq/exercise/replace-substring
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string[] ReplaceSubstring(string[] words)
        {
            return words.Select(s => s.Replace("ea", "*")).ToArray();
        }

        /// <summary>
        /// Select Words
        /// Returns words starting with letter 'a' and ending with letter 'm'.
        /// https://www.csharpexercises.com/linq/exercise/select-words
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string[] SelectWords(string[] words)
        {
            return words.Where(s => s[0] == 'a' && s[^1] == 'm').ToArray();
        }

        /// <summary>
        /// Square Greater Than Twenty
        /// Return numbers and their squares only if square is greater than 20
        /// https://www.csharpexercises.com/linq/exercise/square-greater-than-20
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static string[] SquareGreaterThanTwenty(int[] numbers)
        {
            return numbers.Where(x => x * x > 20).Select(x => $"{x} - {x * x}").ToArray();
        }

        /// <summary>
        /// Top Five Numbers
        /// Returns top 5 numbers from the list of integers in descending order.
        /// https://www.csharpexercises.com/linq/exercise/top-5-numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int[] TopFiveNumbers(int[] numbers)
        {
            return numbers.OrderByDescending(x => x).Take(5).ToArray();
        }

        #endregion Easy

        #region Medium

        /// <summary>
        /// Decrypt Number
        /// Given a non-empty string consisting only of special chars (!, @, # etc.),
        /// return a number (as a string) where each digit corresponds to given
        /// special char on the keyboard ( 1→ !, 2 → @, 3 → # etc.).
        /// https://www.csharpexercises.com/linq/exercise/decrypt-number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string DecryptNumber(string input)
        {
            return string.Concat(input.Select(x => ")!@#$%^&*(".IndexOf(x)));
        }

        /// <summary>
        /// Frequency of Letters
        /// returns letters and their frequencies in the string.
        /// https://www.csharpexercises.com/linq/exercise/frequency-of-letters
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string FrequencyOfLetters(string input)
        {
            return input.Distinct().Select((x, i) => $"Letter {x} occurs {input.Count(c => c == x)} time(s)")
                .Aggregate((a, b) => a + $", {b}").ToString();
        }

        /// <summary>
        /// Most Frequent Character
        /// Returns most frequent character in string. Assume that there is only one such character.
        /// https://www.csharpexercises.com/linq/exercise/most-frequent-character
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static char MostFrequentCharacter(string input)
        {
            return input.OrderByDescending(s => input.Count(c => s == c)).First();
        }

        /// <summary>
        /// Shuffle An Array
        /// Write a query that shuffles sorted array.
        /// https://www.csharpexercises.com/linq/exercise/shuffle-an-array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int[] ShuffleAnArray(int[] input)
        {
            var random = new Random();
            return input.OrderBy(x => random.Next()).ToArray();
        }

        /// <summary>
        /// Unique Values
        /// Return an array that contains only unique (non-duplicate) strings.
        /// https://www.csharpexercises.com/linq/exercise/unique-values
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string[] UniqueValues(string[] input)
        {
            return input.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).ToArray();
        }

        /// <summary>
        /// Uppercase Only
        /// Returns only uppercase words from string.
        /// https://www.csharpexercises.com/linq/exercise/uppercase-only
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string[] UppercaseOnly(string input)
        {
            return input.Split(' ').Where(s => s == s.ToUpper()).ToArray();
        }

        #endregion Medium
    }
}