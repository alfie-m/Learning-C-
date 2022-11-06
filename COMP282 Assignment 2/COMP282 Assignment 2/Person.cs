using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//COMP282 Assignment 2 
//Alfie Moseley 201353343

namespace COMP282_Assignment_2
{
    class Person
    {
        //Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Getters & Setters
        public string Name { get; set; }
        public int Age { get; set; }

        //Output method
        public string Output()
        {
            return Name + " (" + Age + ")";
        }

        //Comparison methods
        public static int CompareByName(Person p1, Person p2)
        {
            return p1.Name.CompareTo(p2.Name);
        }

        public static int CompareByAge(Person p1, Person p2)
        {
            return p1.Age.CompareTo(p2.Age);
        }
    }
}
