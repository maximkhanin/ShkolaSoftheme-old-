﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Human
    {
        private readonly int _birthDate;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _age;
      
        public Human(int birthDate, string firstName, string lastName, string age)
        {
            _age = age;
            _birthDate = birthDate;
            _firstName = firstName;
            _lastName = lastName;
        }

        public Human(int birthDate): this(birthDate, String.Empty, "unknown", "0")
        {   
        }
        public Human(int birthDate, string firstName): this(birthDate,firstName,"unknown","0")
        {          
        }
        public Human(int birthDate, string firstName, string lastName):this(birthDate,firstName,lastName,"0")
        { 
        }
       
        public static bool Equals(Human human1, Human human2)
        {
            if((human1._age == human2._age) &&
                (human1._birthDate == human2._birthDate) &&
                (human1._firstName == human2._firstName) &&
                (human1._lastName == human2._lastName)){
                return true;
            }
            return false;
                
        }
    }
}
