﻿// See https://aka.ms/new-console-template for more information
using MyNamespace;


Console.WriteLine("Ask me a Q");
string question = Convert.ToString(Console.ReadLine());

foreach (var s in args)
{
    Console.Write(s);
    Console.Write(' ');
}
Console.WriteLine();

string[] answers =
{
    "It is certain.",       "Reply hazy, try again.",     "Don’t count on it.",
    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
};

await Utilities.ShowConsoleAnimation();


var index = new Random().Next(answers.Length - 1);
Console.WriteLine(answers[index]);
