using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.coding.core.services;


public delegate void Callback(string name);


public static class Control
{
    public static void ShowMeTheName(string name)
    {
        Console.Write($"Hello {name}");
    }
}
