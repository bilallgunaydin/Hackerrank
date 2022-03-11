using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for(int i = 0; i < numScores; i++){
                scores[i]= Convert.ToInt32(inputs[i]);
            } 
            
            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }

    class Student:Person
    {
        private int[] testScores;
        public Student(string firstName,string lastName, int id, int [] scores)
        {
            this.firstName=firstName;
            this.lastName=lastName;
            this.id=id;
            this.testScores=scores;

        }
        public char Calculate()
        {
            char grade='A';
            int sum=0;
            double avg;
            for(int i=0; i<testScores.Length; i++)
            {
                sum=sum+testScores[i];
            }
            avg=(Convert.ToDouble(sum)/testScores.Length);
            if(avg>=90 && avg<=100)
            grade='O';
            else if(avg>=80 && avg<90)
            grade='E';
            else if(avg>=70 && avg<80)
            grade='A';
            else if(avg>=55 && avg<70)
            grade='P';
            else if(avg>=40 && avg<55)
            grade='D';
            else if(avg<40)
            grade='T';

            return grade;
        }
    }
}
