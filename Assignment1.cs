using System;
using System.Collections.Generic;
using System.Linq;
/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK
*/


namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is :{0}", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is :{0}", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "zimmermanschoolofadvertising";
            char ch = 'x';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix :{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {       
                // write your code here

                String output_string = "";
                // creating a new string with vowels(upper case and lower case)
                string k = "aeiouAEIOU";
                // iterating through each char of given string to check whether it is vowel or not
                for (int i = 0; i < s.Length; i++)
                {
                    if (!k.Contains(s[i]))
                        // if char is not vowel, concatinating with the result string
                        output_string += s[i];
                }
                // returns the result
                return output_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // write your code here.
                // concatinating the strings in an array to one string k1
                string k1 = string.Join("", bulls_string1);
                // concatinating the strings in an array to one string k2
                string k2 = string.Join("", bulls_string2);

                // condition two check whether the both strings are equal or not
                if(k1==k2) {
                    // if both strings are equal it returns true
                    return true;
                }
                // if both strings are not equal it returns false
                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // write your code here
                // decalring a variable to store output
                int output = 0;

                // creating an empty dictionary to store the key as number and value as repeated count;
                Dictionary<int, int> input =
                       new Dictionary<int, int>();

                // converting the input array to list
                List<int> list = bull_bucks.ToList();

                // iterating to setup the key as number and value as repeated count
                for(int i=0;i<bull_bucks.Length;i++)
                {
                    // adding key and incrementing the value if the number repeats
                    if (input.ContainsKey(bull_bucks[i]))
                        input[bull_bucks[i]] += 1;
                    else
                        // adding key and value if it's first time
                        input.Add(bull_bucks[i], 1);
                }

                // An iterator to iterate through each key and sums only non repeated key's respected values

                foreach( var bb in input)
                {
                    if (bb.Value == 1)
                        output += bb.Key;
                }

                // returns the output
                return output;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.
                int sum = 0;
                // getting the size of n*n matrix
                int n = bulls_grid.GetLength(0);
                // iterating through the size 
                for (int i=0;i<n;i++)
                {
                    // add right diagonal elements 
                    sum += bulls_grid[i, i];
                    // adding left diagonal elments 
                    sum += bulls_grid[i, n - i-1];
                }

                // condition to check whether the  size of matrix is even or odd
                if (n%2==0)
                       return sum;
                // subtracting duplicate value for even size square matrix 
                int duplicate = bulls_grid[n / 2, n / 2];
                return sum - duplicate;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // write your code here.

                // initializing the  string of length 6000
                string k = new string('*', 6000);
                
                // iterating through indices
                for( int i=0;i<indices.Length;i++)
                {   
                    // replacing the existing character with new character and converting it into string 
                    k=k.Remove(indices[i],1).Insert(indices[i], bulls_string[i].ToString());
                }
                //  string strip with empty character
                // replacing extra chars with ''
                string str = k.Replace("*",String.Empty);
                return str;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String prefix_string = "";
                // initializing k for index of first occurance of char ch
                int k = 0;

                // iterating through input string 
                for (int i = 0; i < bulls_string6.Length; i++)
                {   
                    // condition to check char ch
                    if (bulls_string6[i] == ch)
                    {
                        k = i;
                        break;
                    }
                }
                // reversing string from the first occurance char ch
                for (int i=k;i>=0;i--)
                {
                    prefix_string += bulls_string6[i];
                }
                // and finally adding all other characters of  input string 
                for(int i=k+1;i<bulls_string6.Length;i++)
                {
                    prefix_string += bulls_string6[i];
                }
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }

}

/* 
 * Self-reflection:- 
 * Learned  syntax of c#, 
 * gone through concepts of dictionaries, arrays.
 * Learned how to use different functions.
 * It took around 8hrs to complete the assignment by going through the each question.
 /*