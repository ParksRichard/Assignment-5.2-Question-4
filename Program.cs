//Write a program to check if a given string is a palindrome
//using recursion

//loop?
//how to change iterative solution to recursion?
//palindromes and substrings?

namespace Assignment_5._2_Question_4
{
    internal class Program
    {
        class PalindromeChecker
        {
            static void Main()
            {
                Console.WriteLine("Welcome back to the Palindrome checker 2.0!");
                Console.Write("Please enter a word to check for palindromes: ");
                string input = Console.ReadLine();
                Console.WriteLine("");

                //bool like prior palindrome program
                bool isPalindrome = IsPalindrome(input, 0, input.Length - 1);

                if (isPalindrome)
                {
                    Console.WriteLine("Congrats, it's a palindrome.");
                }
                else
                {
                    Console.WriteLine("This word is not a palindrome.");
                }
            }

            //substring thing moving towards middle
            static bool IsPalindrome(string input, int left, int right)
            {
                if (left >= right)
                {
                    return true;
                }

                if (input[left] != input[right])
                {
                    return false;
                }

                return IsPalindrome(input, left + 1, right - 1);
                //this is science
            }
        }

    }
}

