﻿using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3, 4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParantheses"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParantheses();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }
        // <summary>
        /// Questions:
        // </summary>
        // <returns>
        // 1. How does the Stack and Heap Work?
        // - The stack is a pile where the item on top of the pile is executed first,
        // for the second item on th epile to be executed the top item must be removed.
        // Basically you can not access everyting at the same time.
        // 
        // - The Heap is is a heap of items in a none specific order, where the executed item is picked from the heap.
        // There is no need for the first item to be removed in order for the next item to be executed. 
        // Here you can access everything at the same time.
        // 
        // 2. What are Value Types and Reference Types?
        // - Value Types include bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, 
        // struct, uint, ulong, and ushort.
        // 
        // The Value Type directly contains the data.
        // 
        // - Reference Types are classes and onterfaces.Variables of reference types store references to their data 
        // (objects) in memory, so they do not directly contain the data. (An object of tyoe Object, string, or
        // dynamic is also a reference type.
        // 
        // 3. The following methods generate different result. The first one returns 3, and the second one returns 4. Why?
        // (This questoins is referring to a specific code snippet)
        //- The first method is using Value Types that is why x = 3; and not y = x; y = 4;
        //As y is not overriding x, they do not affect each other because they are not pointing to the same object.
        //
        // - The second method is using Reference Types, and because both x and y are pointing to the same object,
        // y will override the value of x.
        // 
        // </returns>


        // <summary>
        // Examines the datastructure List
        // </summary>

        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch (nav) {...}

            Console.WriteLine("List");

            List<string> ExamineList = new List<string>(); //Creating list

            while (true) //creating loop that hold switch case for adding and removing items to list
            {
                Console.WriteLine("Enter '+' to add or '-' to remove (0 to exit):");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) //goes back to main menu if string is null or empty
                {
                    break;
                }

                char operation = input[0]; //converting input into char literals
                string item = input.Substring(1).Trim(); //inputing string into substring and trimming space

                switch (operation)
                {
                    case '+':
                        ExamineList.Add(item);//add item
                        break;
                    case '-':
                        ExamineList.Remove(item);//delete item
                        break;
                    default:
                        Console.WriteLine("Use only '+' or '-'");
                        break;
                }
                Console.WriteLine("List content:");
                foreach (var listItem in ExamineList)//displaying list content
                {
                    Console.WriteLine(listItem);
                }
                Console.WriteLine($"Count: {ExamineList.Count}, Capacity: {ExamineList.Capacity}");//displaying list count and capacity
            }

            //1.Complete the implementation of the ExamineList method so that the examination can be carried out.
            //
            //2.When Does the List's Capacity Increase? (i.e., the size of the underlying array)
            //When inputs are added to the list.
            //
            //3.By How Much Does the Capacity Increase?
            //By double the exact amount of input that is added to list.
            //
            //4.Why Doesn't the List's Capacity Increase at the Same Rate as Elements Are Added?
            //To save resources.
            //
            //5.Does the Capacity Decrease When Elements Are Removed from the List?
            //No, not immediately.
            //
            //6.When Is It Advantageous to Use a Custom Array Instead of a List?
            //When you know the exact amount of items in the array.

        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Console.WriteLine("Queue");

            Queue<string> ExamineQueue = new Queue<string>(); //Creating queue

            ExamineQueue.Enqueue("a. The grocery store opens, and the cashier's line is empty.");
            ExamineQueue.Enqueue("b. Kalle joins the queue.");
            ExamineQueue.Enqueue("c. Greta joins the queue.");
            ExamineQueue.Enqueue("d. Kalle is served and leaves the queue. ");
            ExamineQueue.Enqueue("e. Stina joins the queue.");
            ExamineQueue.Enqueue("f. Greta is served and leaves the queue.");
            ExamineQueue.Enqueue("g. Olle joins the queue.");

            while (true) //creating loop that hold switch case for adding and removing items to queue
            {

                Console.WriteLine("Enter '+' to add or '-' to remove (0 to exit):");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) //goes back to main menu if string is null or empty
                {
                    break;
                }

                char operation = input[0]; //converting input into char literals
                string item = input.Substring(1).Trim(); //inputing string into substring and trimming space


                switch (operation)
                {
                    case '+':
                        ExamineQueue.Enqueue(item);//add item
                        break;
                    case '-':
                        ExamineQueue.Dequeue();//delete item
                        break;
                    default:
                        Console.WriteLine("Use only '+' or '-'");
                        break;
                }
                Console.WriteLine("Queue Content:");
                foreach (var queueItem in ExamineQueue)//displaying queue content
                {
                    Console.WriteLine(queueItem);
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */


            Console.WriteLine("Stack");

            Stack<string> ExamineStack = new Stack<string>(); //Creating a Stack

            ExamineStack.Push("a. The grocery store opens, and the cashier's line is empty.");
            ExamineStack.Push("b. Kalle joins the queue.");
            ExamineStack.Push("c. Greta joins the queue.");
            ExamineStack.Push("d. Kalle is served and leaves the queue. ");
            ExamineStack.Push("e. Stina joins the queue.");
            ExamineStack.Push("f. Greta is served and leaves the queue.");
            ExamineStack.Push("g. Olle joins the queue.");

            while (true) //creating loop that hold switch case for pushing and popping items to stack
            {

                Console.WriteLine("Enter '+' to add or '-' to remove, 'r' to reverse (0 to exit):");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) //goes back to main menu if string is null or empty
                {
                    break;
                }

                char operation = input[0]; //converting input into char literals
                string item = input.Substring(1).Trim(); //inputing string into substring and trimming space

                switch (operation)
                {
                    case '+':
                        ExamineStack.Push(item);//add item
                        break;
                    case '-':
                        ExamineStack.Pop();//delete item
                        break;
                    case 'r':
                        Console.WriteLine(ReverseString("Hello"));
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Use only '+', '-', 'r' or '0'.");
                        break;
                }
                Console.WriteLine("Stack Content:");
                foreach (var stackItem in ExamineStack)//displaying stack content
                {
                    Console.WriteLine(stackItem);
                }
            }
        }

        //Alternative solution:
        static string ReverseString(string input)
        {
            Stack<char> charStack = new Stack<char>();

            foreach (char c in input)
            {
                charStack.Push(c);
            }

            char[] reversedChars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                reversedChars[i] = charStack.Pop();
            }

            return new string(reversedChars);
        }

        //static string ReverseText()
        //{

        //    //Collect a string
        //    //Turn string into an array
        //    //Reverse order of array
        //    //Create new string with array
        //    //Return new string

        //    //To get string input back in reverse, press r + space + (insert string) + enter
        //    string sentence = Console.ReadLine(); //Assignes string to user inpu,Ask for user input
        //    char[] charArr = sentence.ToCharArray(); //converts string user input to char and then char to char array
        //    Array.Reverse(charArr); // reverses char array

        //    foreach (char c in charArr)
        //    {
        //        Console.WriteLine(c); //displays user inout as a reversed char array
        //    }

        //    return sentence;
        //}
        static void CheckParantheses()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            //1. create a list or dictionary with correct and uncorrect input
            //2. convert user input to char array
            //3. loop through user input to find opening and matching closing parentheses 
            //4. create a bool sating true or false based on user input

            //Example solution:
            //static bool CheckParentheses(string input)
            //{
            //    Stack<char> parenthesesStack = new Stack<char>();

            //    foreach (char character in input)
            //    {
            //        if (character == '(' || character == '{' || character == '[')
            //        {
            //            //If it´s an open parentheses, add it to the stack.
            //            parenthesesStack.Push(character);
            //        }
            //        else if (character == ')' || character == '}' || character == ']')
            //        {
            //            //If it´s a closed parentheses, check if it matches with the last open parentheses.
            //            if (parenthesesStack.Count == 0)
            //            {
            //                //If the stack is empty then there is no matching open parentheses.
            //                return false;
            //            }

            //            char lastOpened = parenthesesStack.Pop();
            //            if (!IsMatchingPair(lastOpened, character))
            //            {
            //                //If the closed parentheses does not match the latest open parentheses:
            //                return false;
            //            }
            //        }
            //    }

            //    //The stack should be  empty if all open parentheses has a matching closed parentheses.
            //    return parenthesesStack.Count == 0;
            //}

            //static bool IsMatchingPair(char opening, char closing)
            //{
            //    return (opening == '(' && closing == ')') ||
            //           (opening == '{' && closing == '}') ||
            //           (opening == '[' && closing == ']');
            //}
        }
    }
}

