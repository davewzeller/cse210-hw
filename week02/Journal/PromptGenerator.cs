using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator

{


    private static List<string> _prompt = new List<string>
        {
              "Today I found joy in: ",
              "Things I did for myself: ",
              "Things I did for Others: ",
              "Today I am grateful for: ",
              "Inspiring words for today: ",
              "Things to let go of today: "

        };


    private static Random _rand = new Random();

    public static string GetRandomPrompt()
        {
        int _index = _rand.Next(_prompt.Count);
        return _prompt[_index];

        }
        
    }




    

