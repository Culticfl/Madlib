using System;
using System.Collections.Generic;
// --- Global Variables ---
List<string> wordTypes = new List<string>() { "noun", "number", "noun", "food",
"adjective", "verb", "type of employment", "noun", "adjective", "verb", "verb",
"adjective" };
List<string> userInput = new List<string>();
// --- Main Program Flow ---
welcome();
AddToList(wordTypes, userInput);
// STUDENT TASK 1: Call your story-building function here.
// The function should be named `addWordsToStory`.
// You need to pass the `userInput` list as the argument to the function.
// WRITE YOUR FUNCTION CALL ON THE LINE BELOW:
// --- Function Definitions ---
void AddToList (List <string> list, List <string> userInputList)
{
    foreach (string element in list)
    {
        Console.WriteLine($"Please type in a {element}:");
        string textInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(textInput))
        {
            userInputList.Add(textInput);
        }
        else
        {
            Console.WriteLine("That was an invalid input. A blank word has been added.");
            userInputList.Add(""); // Add a blank entry to keep lists aligned

        }
    }
    Console.WriteLine($"\nThe list of words you provided are: {string.Join(", ", userInputList)}\n");
    addWordsToStory();
}
void addWordsToStory()
{
    Console.WriteLine("called");
     Console.WriteLine($"\nThe list of words you provided are: {string.Join(", ", userInput)}\n");
    for (int i = 0; i < userInput.Count + 2; i++)
    {
        if (i == 0)
        {
            Console.WriteLine("I decided to go on a vacation to Australia with " + userInput[0] + ".");
        }
        if (i == 1)
        {
            Console.WriteLine("We got to the airport " + userInput[1]);
        }
        if (i == 2)
        {
            Console.WriteLine(" hours early. When we went through security, I got stopped because I forgot to take " + userInput[2]);
        }
        if (i == 3)
        {
            Console.WriteLine("out of my pocket. We got some " + userInput[3]);
        }
        if (i == 4)
        {
            Console.WriteLine(" for the flight and arrived at the gate. Once we boarded the plane, I was sitting next to a very " + userInput[4]);
        }
        if (i == 5)
        {
            Console.WriteLine(" man. He spent the entire flight " + userInput[5]);
        }
        if (i == 6)
        {
            Console.WriteLine(" and talking about his job doing " + userInput[6] + ".");
        }
        if (i == 7)
        {
            Console.WriteLine("Whenever I tried to sleep, he would step around me to go to the " + userInput[7] + ".");
        }
        if (i == 8)
        {
            Console.WriteLine("I was so " + userInput[8] + ".");
        }
        if (i == 9)
        {
            Console.WriteLine("Since I couldn't sleep, I decided to " + userInput[9]);
        }
        if (i == 10)
        {
            Console.WriteLine("and " + userInput[10] + " instead.");
        }
        if (i == 11)
        {
            Console.WriteLine(" Finally, we arrived in Australia. All in all, the flight was " + userInput[11] + "!");
        }

    }

}
// STUDENT TASK 2: Define the `addWordsToStory` function.
// It must:
// 1. Be named `addWordsToStory`.
// 2. Accept one parameter: a List<string> for the words the user typed.
// 3. Contain a FOR or FOREACH LOOP that iterates through the list of words.
// 4. Build and display the final story in the Console.
// The text for the story is provided below for you to use.
/*
"I decided to go on a vacation to Australia with ", // Insert words[0]
". We got to the airport ", // Insert words[1]
" hours early. When we went through security, I got stopped because I forgot to
take ", // Insert words[2]
" out of my pocket. We got some ", // Insert words[3]
" for the flight and arrived at the gate. Once we boarded the plane, I was
sitting next to a very ", // Insert words[4]
" man. He spent the entire flight ", // Insert words[5]
" and talking about his job doing ", // Insert words[6]
". Whenever I tried to sleep, he would step around me to go to the ", // Insert
words[7]
". I was so ", // Insert words[8]
". Since I couldn't sleep, I decided to ", // Insert words[9]
" and ", // Insert words[10]
" instead. Finally, we arrived in Australia. All in all, the flight was ", //
Insert words[11]
"!"
*/
// WRITE YOUR FUNCTION DEFINITION BELOW:
void welcome()
{
    Console.WriteLine("Welcome! Would you like to play MadLibs?\nType 1 for yes, 2 for no");

string input = Console.ReadLine();
if (input == "1")
{
        Console.WriteLine("You have selected Yes.");
}
else if (input == "2")
{
Console.WriteLine("Thanks.... and Don't forget to always travel with a towel. Good Bye");
Environment.Exit(0);
}
else
{
Console.WriteLine("I didn't catch that. Please try again.");
welcome(); // Recursive call for simplicity
}
}