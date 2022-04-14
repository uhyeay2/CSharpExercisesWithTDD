using NUnit.Framework;

namespace CSharpExercisesWithTDD.Tests
{
    [TestFixture]
    public class LinqExcercisesTests
    {
        #region Easy

        [Test, Description("Last Word Containing Letter - Given an array of strings," +
            " Write a query that sorts the words alphabetically and return the last word that contains 'e'. " +
            " Exercise: https://www.csharpexercises.com/linq/exercise/last-word-containing-letter ")]
        [TestCase(new string[] { "plane", "ferry", "car", "bike" }, "plane")]
        public void LastWordContainingLetter_GivenStringArray_ReturnLastWord_AfterSortingAlphebetically_ThatContainsE(string[] input, string output)
        {
            Assert.AreEqual(output, LinqExercises.LastWordContainingLetter(input));
        }

        [TestCase(new string[] { "computer", "usb" }, new string[] { "COMPUTER" })]
        public void MinimumInput_GivenStringArray_ReturnWordsLongerThanFiveChars_InUppercase(string[] input, string[] output)
        {
            Assert.AreEqual(output, LinqExercises.MinimumInput(input));
        }

        [Test, Description("Numbers From Range - Given an array of integers," +
            " Write a query that returns list of numbers greater than 30 & less than 100." +
            " Exercise: https://www.csharpexercises.com/linq/exercise/numbers-from-range ")]
        [TestCase(new int[] { 67, 92, 153, 15 }, new int[] { 67, 92 })]
        public void NumbersFromRange_GivenIntArray_ReturnsNumbersFrom30To100_AsList(int[] input, int[] output)
        {
            Assert.AreEqual(output, LinqExercises.NumbersFromRange(input));
        }

        [Test, Description("Replace substring - Given an array of strings," +
            " Write a query that replaces 'ea' substring with astersik (*) in given list of words." +
            "Exercise: https://www.csharpexercises.com/linq/exercise/replace-substring ")]
        [TestCase(new string[] { "learn", "current", "deal" }, new string[] { "l*rn", "current", "d*l" })]
        public void ReplaceSubstring_GivenStringArray_ReturnW_ea_ReplacedWith_Asterisks(string[] input, string[] output)
        {
            Assert.AreEqual(output, LinqExercises.ReplaceSubstring(input));
        }

        [Test, Description("Select Words - Given an array of strings," +
                    " Write a query that returns words starting with letter 'a' and ending with letter 'm'." +
            " Exercise: https://www.csharpexercises.com/linq/exercise/select-words ")]
        [TestCase(new string[] { "mum", "amsterdam", "bloom" }, new string[] { "amsterdam" })]
        public void SelectWords_GivinStringArray_ReturnsWords_StartingWithA_EndingWithM(string[] input, string[] output)
        {
            Assert.AreEqual(output, LinqExercises.SelectWords(input));
        }

        [Test, Description("Square Greater Than 20 - Given an array of integers," +
            " Write a query that returns numbers and their squares only if square is greater than 20." +
            " Exercise: https://www.csharpexercises.com/linq/exercise/square-greater-than-20")]
        [TestCase(new int[] { 7, 2, 30 }, new string[] { "7 - 49", "30 - 900" })]
        public void SquareGreaterThanTwenty_GivenIntArray_ReturnNumbersAndTheirSquare_IfSquareIsGreaterThanTwenty(int[] input, string[] output)
        {
            Assert.AreEqual(output, LinqExercises.SquareGreaterThanTwenty(input));
        }

        [Test, Description("Top 5 Numbers - Given an array of integers," +
            " Write a query that returns top 5 numbers from the array of integers in descending order." +
            " Exercise: https://www.csharpexercises.com/linq/exercise/top-5-numbers ")]
        [TestCase(new int[] { 78, -9, 0, 23, 54, 21, 7, 86 }, new int[] { 86, 78, 54, 23, 21, })]
        public void TopFiveNumbers_GivenIntArray_ReturnTopFive_FromArray_InDescendingOrder(int[] input, int[] output)
        {
            Assert.AreEqual(output, LinqExercises.TopFiveNumbers(input));
        }

        #endregion Easy

        #region Medium

        #region Test Cases for Medium Tasks

        /// <summary>
        /// Test Cases for DecryptNumber - https://www.csharpexercises.com/linq/exercise/decrypt-number
        /// </summary>
        private static readonly object[] _decryptNumberSource =
        {
                          // input, output
            new object[] { "())(" , "9009" },
            new object[] { "*$(#&", "84937" },
            new object[] { "!!!!!!!!!!", "1111111111" }
        };

        private static readonly object[] _frequencyOfLettersSource =
        {
            new object[]{ "gamma", "Letter g occurs 1 time(s), Letter a occurs 2 time(s), Letter m occurs 2 time(s)" },
            new object[]{ "dog", "Letter d occurs 1 time(s), Letter o occurs 1 time(s), Letter g occurs 1 time(s)" },
            new object[]{ "abbccc", "Letter a occurs 1 time(s), Letter b occurs 2 time(s), Letter c occurs 3 time(s)"}
        };

        #endregion Test Cases for Medium Tasks

        [Test, Description(@"DecryptNumber - Given a string of only Special Characters, Return a number (as a string)
            where each digit corresponds to given special char on the keyboard ( 1→ !, 2 → @, 3 → # etc.)
            Exercise: https://www.csharpexercises.com/linq/exercise/decrypt-number ")]
        [TestCaseSource(nameof(_decryptNumberSource))]
        public void DecryptNumber_GivenRandomSpecialChars_DecryptUsingKeyboardNumRow_ReturnNumbersAsString(string input, string output)
        {
            Assert.AreEqual(output, LinqExercises.DecryptNumber(input));
        }

        [Test, Description(@"Frequency of Letters - Given string, Write a query that returns letters and their frequencies in the string.
            Exercise: https://www.csharpexercises.com/linq/exercise/frequency-of-letters ")]
        [TestCaseSource(nameof(_frequencyOfLettersSource))]
        public void FrequencyOfLetters_GivenString_ReturnLetter_AndItsFrequency(string input, string output)
        {
            Assert.AreEqual(output, LinqExercises.FrequencyOfLetters(input));
        }

        [Test, Description("Most Frequent Character - Given a string," +
                    " Write a query that returns most frequent character in string. " +
            " Assume that there is only one such character." +
            "Exercise: https://www.csharpexercises.com/linq/exercise/most-frequent-character ")]
        [TestCase("panda", 'a')]
        [TestCase("n093nfv034nie9", 'n')]
        public void MostFrequentCharacter_GivenString_ReturnMostFrequentCharacter(string input, char output)
        {
            Assert.AreEqual(output, LinqExercises.MostFrequentCharacter(input));
        }

        [Test, Description("Shuffle An Array - Given an array of integers," +
                            " Write a query that shuffles assorted array," +
            " Exercise: https://www.csharpexercises.com/linq/exercise/shuffle-an-array ")]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void ShuffleAnArray_GivenIntArray_ReturnsRandomlyShuffledArray(int[] input)
        {
            Assert.AreNotEqual(input, LinqExercises.ShuffleAnArray(input));
        }

        [Test, Description("Unique Values - Given an array of strings," +
            " Return an array that contains only unique (non-duplicate) strings." +
            " Exercise: https://www.csharpexercises.com/linq/exercise/unique-values ")]
        [TestCase(new string[] { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" }, new string[] { "klm", "rst" })]
        public void UniqueValues_GivenStringArray_ReturnOnlyUniqueStrings(string[] input, string[] output)
        {
            Assert.AreEqual(output, LinqExercises.UniqueValues(input));
        }

        [Test, Description("Uppercase Only - Given string," +
            " Write a query that returns only uppercase words from the string" +
            " Exercise: https://www.csharpexercises.com/linq/exercise/uppercase-only ")]
        [TestCase("DDD example CQRS Event Sourcing", new string[] { "DDD", "CQRS" })]
        public void UppercaseOnly_GivenString_ReturnOnlyUppercaseWords_InStringArray(string input, string[] output)
        {
            Assert.AreEqual(output, LinqExercises.UppercaseOnly(input));
        }

        #endregion Medium
    }
}