#region CODE FROM COPILOT NOT USING
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;


//public class UniqueValueSorter
//{
//    public int[] GetUniqueValuesByFrequency(int[] inputArray)
//    {
//        // Group the numbers and count their frequencies
//        var frequencyMap = inputArray
//            .GroupBy(number => number)
//            .Select(group => new { Value = group.Key, Count = group.Count() })
//            .ToList();

//        // Sort by frequency first, then by value
//        var sortedByFrequency = frequencyMap
//            .OrderBy(item => item.Count)
//            .ThenBy(item => item.Value)
//            .Select(item => item.Value)
//            .ToArray();
//        int[] reversedList = sortedByFrequency.Reverse().ToArray();
//        return reversedList;
//    }
//}

// Example usage:
//class Program
//{
//    public static void Main()
//    {
//var sorter = new UniqueValueSorter();
//int[] inputArray = new int[] { 0, 0, 1, 3, 2, 3, 2, 1, 1, 0 };

//int[] uniqueValuesByFrequency = sorter.GetUniqueValuesByFrequency(inputArray);

//Console.WriteLine("Unique values sorted by frequency (and value):");
//foreach (var value in uniqueValuesByFrequency)
//{
//    Console.WriteLine(value);
//}
//    }
//}
#endregion

using System.Collections.Specialized;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    public static void Main()
    {
        MessagingAndOutput.GetNumberOrderAndCountMSG();
        TestMethods.GetNumberOrderAndCount(GetDataForNewClassTesting.randNumList);

        MessagingAndOutput.AddTheEvensMSG();
        TestMethods.AddTheEvens(GetDataForNewClassTesting.randNumList);

        MessagingAndOutput.CheckPalindromeMSG();

        MessagingAndOutput.ReverseStringsInASentanceMSG();
        Console.ForegroundColor = ConsoleColor.Green;
        string newSentance = TestMethods.ReverseStringsInASentance();
        Console.WriteLine($"   {string.Join("", newSentance)}");

        TestMethods.GetStarsAndSpaces(5);
        Console.ForegroundColor = ConsoleColor.White;
        TestMethods.Something();

        Console.ReadLine();
    }

}

public static class MessagingAndOutput
{
    internal static void CheckPalindromeMSG()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE AN STRING");
        Console.WriteLine(" AND TURNS IT INTO A STRING ARRAY");
        Console.WriteLine(" AND THEN REVERSE THE SPELLING OF THE STRING (STRING ARRAY)");
        Console.WriteLine("  THEN COMPARE TO SEE IF THE 2 STRINGS ARE EQUAL");
        Console.WriteLine("    WILL REPORT AS PALINDROME OR NOT PALINDROME");
        Console.WriteLine("##########################################");
        Console.ForegroundColor = ConsoleColor.Green;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {"tacocat"}");
        ReverseStrings.chkPalindrome("tacocat");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {"palindrome"}");
        ReverseStrings.chkPalindrome("palindrome");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    internal static void GetNumberOrderAndCountMSG()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE AN INT ARRAY");
        Console.WriteLine(" AND PRINT TO THE SCREEN A HASHTABLE");
        Console.WriteLine(" OF THE UNIQUE INTEGERS AND THE NUMBER");
        Console.WriteLine("  OF TIMES THEY APPEAR IN THE ARRAY");
        Console.WriteLine("    IN ORDER FROM MOST TO LEAST");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {string.Join("", (string.Join(" ", GetDataForNewClassTesting.randNumList)))}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
    }

    internal static void AddTheEvensMSG()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE AN INT ARRAY");
        Console.WriteLine("  AND USING FOR LOOP WILL CHOOSE THE EVEN NUMBERS");
        Console.WriteLine(" AND ADD THOSE NUMBERS PRINTING OUT THE SUM");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {string.Join("", GetDataForNewClassTesting.randNumList)}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
    }

    internal static void ReverseStringsInASentanceMSG()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE A STRING ARRAY");
        Console.WriteLine("  AND USING LINQ WILL CHOOSE EACH WORD");
        Console.WriteLine(" IN THE ARRAY AND REVERSE THE SPELLING OF");
        Console.WriteLine("  THE WORD THEN PRINT THE NEW SENTENCE");
        Console.WriteLine("           TO THE SCREEN");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {GetDataForNewClassTesting.wordListFromSentance}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
    }

    internal static void ReverseMSG()
    {
        string result = TestMethods.ReverseNewMethod();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.WriteLine("  THIS METHOD WILL TAKE AN INT ARRAY");
        Console.WriteLine(" AND FIRST USE A FOR LOOP TO CREATE A ");
        Console.WriteLine(" NEW SENTENCE THAT WILL HAVE EVERY OTHER");
        Console.WriteLine("     WORD WRITTEN IN REVERSE");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"INPUT: {string.Join("", GetDataForNewClassTesting.wordListFromSentance)}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("##########################################");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(result);
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    internal static void stuff()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("#####################################################");
        Console.WriteLine("  TRY TO MAKE THE TRIANGLE WITH * AND SPACES  ");
        Console.WriteLine("#####################################################");
        Console.ForegroundColor = ConsoleColor.Green;
    }

}

public static class GetDataForNewClassTesting
{
    public static int[] randNumList = new int[] { 0, 1, 0, 6, 2, 0, 1, 1, 0, 3, 2, 1, 2, 1, 1, 1, 1, 0, 1, 3, 6 };
    public static string wordListFromSentance = "the rabbit ate the carrots";
    public static string nextSentence = "This is the sentence I will use to test";
    public static string nextTestSentance = "try this sentence now and see if it works";
}

public static class TestMethods
{
    internal static string ReverseNewMethod()
    {
        Console.WriteLine(" ");
        string[] sepSent = ReverseStringsInASentance().Split(" ");
        string result = string.Empty;

        for (int i = 0; i < sepSent.Length; i++)
        {
            if (i % 2 == 0)
            {
                result += $"{sepSent[i]} ";
            }
            else
            {
                char[] charArray = sepSent[i].ToCharArray();
                Array.Reverse(charArray);
                string tmp = new string(charArray);
                result += $"{tmp} ";
            }
        }
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine("##########################################");
        //Console.WriteLine("  THIS METHOD WILL TAKE AN INT ARRAY");
        //Console.WriteLine(" AND FIRST USE A FOR LOOP TO CREATE A ");
        //Console.WriteLine(" NEW SENTENCE THAT WILL HAVE EVERY OTHER");
        //Console.WriteLine("     WORD WRITTEN IN REVERSE");
        //Console.ForegroundColor = ConsoleColor.Cyan;
        //Console.WriteLine($"INPUT: {string.Join("", sepSent)}");
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine("##########################################");
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine(result);
        //Console.WriteLine(" ");
        //Console.ForegroundColor = ConsoleColor.White;
        return result;
    }

    internal static string ReverseStringsInASentance()
    {
        string customWordsList = string.Empty;
        var wordsToReorder = GetDataForNewClassTesting.wordListFromSentance
           .Split()
           .Select(x => string.Concat(x.ToElements().Reverse()));
        foreach (string word in wordsToReorder)
        {
            customWordsList += $"{word} ";
        }
        return customWordsList;
    }

    internal static void GetStarsAndSpaces(int N)
    {
        char star = '*';
        char space = ' ';
        string starSpace = "* ";
        int X = N - 1;
        var sb = new StringBuilder();
        string newLine = string.Empty;
        string newLine2 = string.Empty;

        for (int i = 0; i < N; i++)
        {
            if (i == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                newLine = $"{new string(space, X)}{star}";
                Console.WriteLine(newLine);
            }

            if (i > 0 && (X >= i))
            {
                newLine = $"{new string(space, X - i)}{starSpace}";
                StringBuilder sb2 = new StringBuilder(newLine);
                for (int j = 0; j < i; j++)
                {
                    sb2.Append(starSpace);
                    newLine2 = sb2.ToString();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(newLine2);
            }
        }
    }
    internal static void GetNumberOrderAndCount(int[] TheInput)
    {
        var sortTheInput = TheInput.GroupBy(x => x);
        Dictionary<int, int> counting = new Dictionary<int, int>();
        foreach (var y in sortTheInput)
        {
            counting.Add(y.Key, y.Count());
        }
        var sortedDict = from entry in counting orderby entry.Value descending select entry;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Unique numbers in order by number of times appeared in the string array");
        foreach (var item in sortedDict)
        {
            Console.WriteLine(item);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" ");
    }

    internal static void Something()
    {
        string[] states = { "California", "New York", "Vermont", "Florida", "california" };
        int statesCount = states.Length;
        int caliCount = 0;
        foreach (string state in states)
        {
            if (state.ToLower().Equals("california"))
            {
                caliCount++;
            }
        }

        bool isOdd = false;

        isOdd = caliCount % 2 == 0;

        Console.WriteLine($"states count = {statesCount} and california count = {caliCount} and is it odd :: {isOdd}");
    }

    internal static void AddTheEvens(int[] TestInput)
    {
        int tmpResult = 0;
        foreach (var num in TestInput)
        {
            if (num % 2 == 0)
            {
                tmpResult += num;
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(tmpResult);
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

public static class ReverseStrings
{
    public static IEnumerable<string> ToElements(this string source)
    {
        var enumerator = StringInfo.GetTextElementEnumerator(source);
        while (enumerator.MoveNext())
            yield return enumerator.GetTextElement();
    }

    internal static void chkPalindrome(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        if (reversedString.Equals(str))
        {
            Console.WriteLine("Palindrome");
            Console.WriteLine("");
        }
        else
            Console.WriteLine("Not Palindrome");
        Console.WriteLine("");
    }

    internal static void ReverseWordOrder(string sentence)
    {
        string[] sentArray = sentence.Split(' ');
        int sentLength = sentArray.Length;
        string newSentence = string.Empty;

        for (int i = sentLength - 1; i >= 0; i--)
        {
            newSentence += $"{sentArray[i]} ";
        }

        Console.WriteLine($"new sentence here: {newSentence}");

    }

}
