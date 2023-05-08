using System;
using System.Collections.Generic;

namespace PracticeHere
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //LIST ARRAY 
            var people = new string[] { "Mark", "Paul", "John", "Kyle" };

            //Creating a variable so we can get the First Person in our ARRAY called people
            //The variable then grabs the first name from our ARRAY
            var firstPersonsNameInTheArray = people[0];

            //We can also, ask for the length of the Array with .Length 
            var peopleLengthInArray = firstPersonsNameInTheArray.Length;

            //Printing out how many names there are in our Array which should give us 4
            Console.WriteLine($"There are {peopleLengthInArray} people in The Array");

            //Printing out "Mark" since the first  index is  0
            Console.WriteLine($"This is our first person in our Array {firstPersonsNameInTheArray}");

            //

            //PROBLEMS WITH ARRAYS: Once an Array is created, its size of how many indexes can't change
            //Problems with ARRAYS: Cannot access an index that does not exist in our program 
            //PROBLEMS WIH ARRAYS: Arrays can only store data of the same type








            // LIST STRING

            //creating a list of string (Names)
            var students = new List<string>() { "Kyle", "Joseph", "Ryan" };

            //Adding the name Joe too our LIST of students so it should say - Kyle, Joseph, Ryan, Joe
            students.Add("Joe");

            // Creating a variable for the first name of the LIST of students 
            var firstName = students[0];

            //Printing out the first name in our students LIST . It should print out the name Kyle
            Console.WriteLine($"The first name in our students List is {firstName}");

            // Like adding we can Add a name in our LIST in any part of the LIST Instead of just adding it to the end 
            students.Insert(3, "Jacob");
            // Printing out how many students are in out LIST of students. It should print out 5
            Console.WriteLine($"There are {students.Count} students in our LIST ");



            // THE Variable lastIndexInStudents will accesa our students LIST. and with .Count - 1;  that will help us get the last index
            var lastIndexInStudents = students.Count - 1;
            // The variable lastStudent will access our student LIST and the variable lastIndexInStudents
            var lastStudent = students[lastIndexInStudents];
            //Printing out our last student in the LIST which should be Joe
            Console.WriteLine($"Our last student in our student LIST is {lastStudent}");







            // LIST INT

            //Creating an LIST INT Instead of having a LIST STRING.
            //Also, we are adding the indexes/items in after making the LIST
            var soccerScores = new List<int>() { };
            // We are adding the Ints after instead of immediately like how we added the names to the List of students 
            soccerScores.Add(13);
            soccerScores.Add(15);
            soccerScores.Add(12);
            soccerScores.Add(14);
            // Removing a int from out list 
            soccerScores.Remove(13);

            // CReating a variable to call back that creates the last Index of that LIST... the -1 is what makes it happen
            var lastSoccerScoreIndexOrNumber = soccerScores.Count - 1;
            // recalling the variable lastSoccerScoreIndexOrNumber previous variable and now asking it to return the last index
            var lastSoccerScore = soccerScores[lastSoccerScoreIndexOrNumber];

            //Creating a variable to recall later to find what index the number 13 is in. 
            //We use IndexOf() to choose what number Id like to find the
            var indexOfThirteen = soccerScores.IndexOf(13);
            // Recalling the variable indexOfThirteen and should return 0
            Console.WriteLine($"Found 13 at index {indexOfThirteen}");








            // LIST DICTIONARY 

            // Dictionary a type of List Collections. It passes two things
            var footballScores = new Dictionary<string, int>();

            //Adding to our dictionary must contain 2 inputs one string and one Int
            footballScores.Add("Eddy Huapaya", 1_000);

            // Another way of adding to the dictionary List
            footballScores["John Meyer"] = 100;

            //Creating Variable to find the score for John
            var JohnsFootballScore = footballScores["John Meyer"];

            //Printing out JohnsFootballScore which should be 100
            Console.WriteLine($"Johns football score is {JohnsFootballScore}");

            //Changing Eddy Huapaya sscore from 1_000 to 3_000
            //You can aslo Add in LIST DICTIONARY this way as well
            footballScores["Eddy Huapaya"] = 3_000;

            // How to find the an index in our Dictionary List. We must first create a variable for it and call the string to return a Int. 
            var EddyHuapayaIndex = footballScores["Eddy Huapaya"];
            // Recalling the variable firstFootballIndex To output the first Index in our Dictionary List
            Console.WriteLine($"{EddyHuapayaIndex}");


            //The method ContainsKey()  ask our DICTIONARY LIST if it Contains the Key Eddy Huapaya
            var hasKey = footballScores.ContainsKey("Eddy Huapaya");
            //If hasKey variable is true then print out, Hi Eddy your score is {eddyScore}
            if (hasKey == true)
            {

                var eddyScore = footballScores["Eddy Huapaya"];
                Console.WriteLine($"Hi Eddy your score is {eddyScore}");
            }







            //LIST QUEUES

            //QUEUES First in, First Out
            var names = new Queue<string>() { };
            //Adding to our QUEUE LIST
            names.Enqueue("Eddy");
            names.Enqueue("John");
            names.Enqueue("Lien");
            names.Enqueue("Creed");
            //Deleting names from LIST QUEUE 
            var FirstName = names.Dequeue();
            // Prints out the first name always because it is a QUEUE LIST
            Console.WriteLine(FirstName);




















        }

    }
}
