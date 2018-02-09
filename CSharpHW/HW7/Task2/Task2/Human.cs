using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Human
    {
        private int _BirthDate;
        private string _FirstName;
        private string _LastName;
        private readonly string _Age;
        public Human()
        {

        }
        public Human(int birthDate, string firstName, string lastName, string age)
        {
            this._Age = age;
            this._BirthDate = birthDate;
            this._FirstName = firstName;
            this._LastName = lastName;
        }

        public Human(int birthDate)
        {
            
            this._BirthDate = birthDate;
            
        }
        public Human(int birthDate, string firstName)
        {
          
            this._BirthDate = birthDate;
            this._FirstName = firstName;
            
        }
        public Human(int birthDate, string firstName, string lastName)
        { 
            this._BirthDate = birthDate;
            this._FirstName = firstName;
            this._LastName = lastName;
        }
       
        public static bool Equals(Human human1, Human human2)
        {
            if((human1._Age == human2._Age) &&
                (human1._BirthDate == human2._BirthDate) &&
                (human1._FirstName == human2._FirstName) &&
                (human1._LastName == human2._LastName)){
                return true;
            }
            return false;
                
        }
    }
}
