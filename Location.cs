using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aHome
{
    class Location
    {
        public Location(string name)                                  //Create the constructor
        {
            Name = name;                                              //assign value to a public field and can't change the value from the outside
        }

        public Location[] Exits;

        public string Name { get; private set; }                      //define a public field

        public virtual string Description                             //define a public field named Description which only can be obtained value.
        {
            get
            {
                string description = "You're standing in the " + Name + ". You see exits to the following places: ";  //define the field's standard form
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;               //Exits array is used to storage the whole Location field, and will print after the standard from
                    if (i != Exits.Length - 1)                        //when continuous printing some words ,we can use this 
                        description += ", ";                          //solution to put a comma between each case.
                }
                description += ". ";                                  //the end of the sentence
                return description;                                   //Description field return the value of description.
            }
        }
    }
}
