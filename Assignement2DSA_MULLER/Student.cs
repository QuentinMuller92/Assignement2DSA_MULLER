using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement2DSA_MULLER
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string studentNumber;
        private float averageScore;

        //Constructors
        public Student() { }

        public Student(string firstName, string lastName, string studentNumber, float averageScore)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.averageScore = averageScore;
        }

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public string StudentNumber
        {
            get { return this.studentNumber; }
        }

        public float AverageScore
        {
            get { return this.averageScore; }
        }

        //Method
        public override string ToString()
        {
            return "The student with the student number " + studentNumber + " is " + firstName + " " + lastName + " and has an average score of " + averageScore + ".";
        }
    }
}
