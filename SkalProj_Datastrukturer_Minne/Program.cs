using System;

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
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
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
                        CheckParanthesis();
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
        /// <summary>
        /// Questions:
        /// </summary>
        /// <returns>
        /// 1. How does the Stack and Heap Work?
        /// - The stack is a pile where the item on top of the pile is executed first, 
        /// for the second item on th epile to be executed the top item must be removed.
        /// Basically you can not access everyting at the same time.
        /// 
        /// - The Heap is is a heap of items in a none specific order, where the executed item is picked from the heap.
        /// There is no need for the first item to be removed in order for the next item to be executed. 
        /// Here you can access everything at the same time.
        /// 
        /// 2. What are Value Types and Reference Types?
        /// - Value Types include bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, 
        /// struct, uint, ulong, and ushort.
        /// 
        /// The Value Type directly contains the data.
        /// 
        /// - Reference Types are classes and onterfaces. Variables of reference types store references to their data 
        /// (objects) in memory, so they do not directly contain the data. (An object of tyoe Object, string, or 
        /// dynamic is also a reference type.
        /// 
        /// 3. The following methods generate different result. The first one returns 3, and the second one returns 4. Why?
        /// (This questoins is referring to a specific code snippet)
        ///- The first method is using Value Types that is why x = 3; and not y = x; y = 4;
        ///As y is not overriding x, they do not affect each other because they are not pointing to the same object.
        ///
        /// - The second method is using Reference Types, and because both x and y are pointing to the same object,
        /// y will override the value of x.
        /// 
        /// </returns>


        /// <summary>
        /// Examines the datastructure List
        /// </summary>
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

            //switch(nav){...}
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
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

