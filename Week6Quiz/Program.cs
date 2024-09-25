using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Quiz
{
    internal class Program
    {
        public static void ReverseString(string input) //reverse string method
        {
            string reverse = ""; //declares and initalizes reverse string
            for (int i = input.Length - 1; i >= 0; i--) //for loop to loop through every index
            {
                reverse += input[i]; //sets reverse string to inverse of input string
            }
            Console.WriteLine("The reverse of " + input + " is " + reverse); //outputs reverse string
        }

        public static void CountVowels(string input) //countvowels method
        {
            int count = 0; //declares and initalizes count int
            for (int i = 0; i < input.Length; i++) //for loop to loop through every character
            {
                switch (input[i]) //switch loop to check if index character is a vowel
                {
                    case 'a': //a case
                        count++; //counts vowel
                        break; //breaks from switch loop
                    case 'e': //a case
                        count++; //counts vowel
                        break; //breaks from switch loop
                    case 'i': //a case
                        count++; //counts vowel
                        break; //breaks from switch loop
                    case 'o': //a case 
                        count++; //counts vowel
                        break; //breaks from switch loop
                    case 'u': //a case
                        count++; //counts vowel
                        break; //breaks from switch loop
                    default: //default case
                        break; //breaks from switch loop
                }
                        
            }
            Console.WriteLine("The number of vowels in the string is: " + count); //outputs vowel count
        }

        public static void IsPalndrome(string input) //IsPanlidrome method
        {
            bool isPalndrome = false; //declares and initalizes bool 

            for (int i = 0; i < input.Length; i++) //for loop to loop through each character
            {
                if (input[i] == input[input.Length -i -1]) //if condition if index equals opisite character
                {
                    isPalndrome = true; //sets bool to true
                }
                else //else condition if index !equals opisite character
                {
                    isPalndrome = false; //sets bool to false
                }
            }
            if (isPalndrome == true) //if bool is true condition
            {
                Console.WriteLine("The string is a palindrome"); //output
            }
            else //if bool is not true condition
            {
                Console.WriteLine("The string is not a palindrome"); //output
            }

        }
        static void Main(string[] args)
        {
            int input = 0; //input int
            while (input != 4) //while loop while input does not equal 4
            {
                Console.WriteLine("Please enter a string: "); //text display asking for user input
                string MainInput = Console.ReadLine(); //sets user input to string variable
                Console.WriteLine("Please select an operation"); //text display asking for user input
                Console.WriteLine("1. Reverse the string"); //displays text
                Console.WriteLine("2. Count the number of vowels"); //displays text
                Console.WriteLine("3. Is it a palindrome?"); //displays text
                Console.WriteLine("4. Exit"); //displays text
                Console.WriteLine(); //displays blank line
                input = Convert.ToInt32(Console.ReadLine()); //sets user input to int variable

                switch (input) //switch loop
                {
                    case 1: //case for option 1
                        ReverseString(MainInput); //calls reversestring method
                        break; //breaks from switch loop
                    case 2: //case for option 1
                        CountVowels(MainInput); //calls countvowels method
                        break; //breaks from switch loop
                    case 3: //case for option 1
                        IsPalndrome(MainInput); //calls ispalnidrome method
                        break; //breaks from switch loop
                    case 4: //case for option 1 //calls reversestring method
                        break; //breaks from switch loop
                }
            }
        }
    }
}
