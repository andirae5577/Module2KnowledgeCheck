﻿using System;
using System.Collections.Generic;

namespace Program
    public class Program
    {
    public static void Main(string[] args)
     }
    Console.WriteLine("How many records do you want to add? ");
    var numberOfRecords = int.Parse(Console.ReadLine());

    var recordList = new List<MyClass>();
for (int i = 0; i<numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myClass = new MyClass();

    Console.WriteLine("Enter the value for ");
    myClass.myProperty = Console.ReadLine();

    recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()
    }
    }