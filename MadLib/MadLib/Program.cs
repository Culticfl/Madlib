using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
List<string> wordTypes = new List<string>() { "noun", "number", "noun", "food",
"adjective", "verb", "type of employment", "noun", "adjective", "verb", "verb",
"adjective" };
List<string> userInput = new List<string>();
List<string> story;
welcome();
AddToList(wordTypes, userInput);
void AddToList (List <string> list, List <string> userInputList)
{
    foreach (string element in list)
    {
        Console.WriteLine($"Please type in a {element}:");
        string textInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(textInput))
        {
            userInputList.Add(textInput);
            for (int i = 0; i < story.Count + 1; i++)
            {
                addWordsToStory(story[i]);
            }
            }

        else
        {
            Console.WriteLine("That was an invalid input. A blank word has been added.");
            userInputList.Add("");

        }
    }
    Console.WriteLine($"\nThe list of words you provided are: {string.Join(", ", userInputList)}\n");
    
}
void addWordsToStory(string word)
{
    Console.WriteLine($"\nThe list of words you provided are: {string.Join(", ", userInput)}\n");
        Console.WriteLine(word);
}
void welcome()
{
    Console.WriteLine("Welcome! Would you like to play MadLibs?\nType 1 for yes, 2 for no");
            story = new List<string>() {"I decided to go on a vacation to Australia with " + userInput[0] + "." + "We got to the airport " + userInput[1]
            + " hours early. When we went through security, I got stopped because I forgot to take " + userInput[2] + "out of my pocket. We got some " + userInput[3] +
            " for the flight and arrived at the gate. Once we boarded the plane, I was sitting next to a very " + userInput[4] + " man. He spent the entire flight " + userInput[5] +
            " and talking about his job doing " + userInput[6] + "." + "words" + "Whenever I tried to sleep, he would step around me to go to the " + userInput[7] + "." + "I was so " + userInput[8] + "." +
            "Since I couldn't sleep, I decided to " + userInput[9] + "and " + userInput[10] + " instead." + " Finally, we arrived in Australia. All in all, the flight was " + userInput[11] + "!"};
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