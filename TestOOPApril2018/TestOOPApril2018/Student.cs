using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPApril2018
{
    class Student
    {
        #region DataMembers
        // data members 
        private string name;
        private string favFood;
        private string homeTown;
        private DateTime dateOfBirth;
        // DOB data member
        #endregion

        #region Properties
        // Properties 
        public string Name
        {
            set // give a value for name 
            { // validation 
                name = value;// value is always on the right side!
            }
            get// retrive the name 
            {// validation 
                return name; 
            }
        }

        public string FavFood
        {
            set
            {
                favFood = value;
            }
            get
            {
                return favFood;
            }
        }

        public string HomeTown
        {
            set
            {
                homeTown = value;
            }
            get
            {
                return homeTown;
            }
        }

        public DateTime DateOfBirth
        {
            set
            {
                dateOfBirth = value;
            }
            get
            {
                return dateOfBirth;
            }
        }
        #endregion


        public void PrintInfo()
        {
            Console.WriteLine("Student Name: "+Name);
            Console.WriteLine("Fav. Food: "+ FavFood);
            Console.WriteLine("Hometown: "+HomeTown);
            Console.WriteLine("Date of Birth: "+DateOfBirth);
        }
    }
}