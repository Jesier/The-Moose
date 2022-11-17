using System;
using System.Collections.Generic;

var responses = new Dictionary<string, List<string>>()
{
    {"Canada", new List<string>(){"Really? It seems very unlikely.","I  K N E W  I T !!!"}},
    {"enthusiastic", new List<string>(){"Yay!","You should try it!"}},
    {"cSharp", new List<string>(){"Good job sucking up to your instructor!","You will...oh, yes, you will..."}},
    {"secret", new List<string>(){"ME TOO!!!! I love secrets...tell me one!","Oh, no...secrets are the best, I love to share them!"}}
};

Main();

void Main()
{
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Let the moose speak!
    MooseSays("Give me your first born");
    MooseSays("There is no other option");


       question("Is Canada real?", "Canada");
       question("Are you enthusiastic?", "enthusiastic");
       question("Do you love C# yet?","cSharp");
       question("Do you want to know a secret?","secret");
   
    // Ask a question old way
    // CanadaQuestion();
    // EnthusiasticQuestion();
    // LoveCSharpQuestion();
    // SecretQuestion();
}



void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

void question(string question, string topic)
{
    if (MooseAsks(question))
    {
        MooseSays(responses[topic][0]);
    }
    else
    {
        MooseSays(responses[topic][1]);
    }
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Previous Way the simple and unconcise
// void CanadaQuestion()
// {
//     bool isTrue = MooseAsks("Is Canada real?");
//     if (isTrue)
//     {
//         MooseSays("Really? It seems very unlikely.");
//     }
//     else
//     {
//         MooseSays("I  K N E W  I T !!!");
//     }
// }

// void EnthusiasticQuestion()
// {
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }
// }

// void LoveCSharpQuestion()
// {
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }
// }

// void SecretQuestion()
// {
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }