using System;
using System.Collections.Generic;
using Animals;
using Introduction.Persons;
using Logging;

namespace Introduction.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreatePeople();
            // DogCreation();
            // PeopleInheritance();
            TeamMemberSalarySummaryExample();

            Console.ReadLine();
        }

        public static void PeopleInheritance()
        {
            TeamMember QLTeamMember = new TeamMember
            {
                FirstName = "David",
                MiddleName = "Slacker",
                LastName = "Esseily",
                Anniversary = new DateTime(2013, 8, 26, 8, 30, 0),
                TeamLeader = new Person("Kevin", "Lang"),
                Salary = 50000
            };
            QLTeamMember.SaySomething("I like .NET");
            QLTeamMember.TeamLeader.SaySomething("David deserves less money");
            Logger.Log(string.Format("David's Salary is ${0}", QLTeamMember.Salary));
            var newSalary = QLTeamMember.GiveRaise(-10000);
            Logger.Log(string.Format("David's Salary is ${0}", newSalary));
            QLTeamMember.GiveRaise1(-10000);
            Logger.Log(string.Format("David's Salary is ${0}", QLTeamMember.Salary));
            QLTeamMember.AddVacationTime(-10);

            QLTeamMember.GiveRaise(-10, true);

        }

        public static void DogCreation()
        {
            #region Dog

            Dog dog = new Dog
            {
                CollarColor = "Blue",
                Name = "Ringworm",
                Legs = 3,
                TailLength = 0
            };
            dog.Species = dog.MySpecies;
            dog.Walk(5);
            dog.Speak("Joe", "Is", "Really", "Walking", "Me");

            #endregion Dog
        }

        public static void CreatePeople()
        {
            Person[] people = new Person[4];

            // Create the person with the default constructor
            Person person1 = new Person();
            Console.WriteLine(person1.FullName);
            people[0] = person1;

            Person person2 = new Person("Joseph", "Guadagno", "James");
            Console.WriteLine(person2.FullName);
            people[1] = person2;

            Person person3 = new Person()
            {
                FirstName = "Joseph",
                MiddleName = "James",
                LastName = "Guadagno",
                MothersName = "Catherine",
                Children = new List<Person>()
            };
            Console.WriteLine(person3.FullName);
            people[2] = person3;

            Person person4 = new Person();
            person4.FirstName = "Joseph";
            person4.MiddleName = "James";
            person4.LastName = "Guadagno";
            Console.WriteLine(person4.FullName);
            people[3] = person4;
        }

        public static void TeamMemberSalarySummaryExample()
        {
            TeamMember teamMember1 = new TeamMember()
            {
                FirstName = "Joe",
                Salary = 10000
            };
            TeamMember teamMember2 = new TeamMember()
            {
                FirstName = "david",
                Salary = 1000
            };

            TeamMember[] teamMembers = new TeamMember[3];
            teamMembers[0] = teamMember1;
            teamMembers[1] = teamMember2;
            teamMembers[2] = new TeamMember {FirstName = "Akash", Salary = 300000};



            decimal totalSalary = 0;
            for (int teamMember = 0; teamMember < teamMembers.Length; teamMember++)
            {
                if (teamMembers[teamMember] != null)
                {
                    totalSalary += teamMembers[teamMember].Salary;
                }
            }

            Logger.Log(string.Format("Our current salary is ${0}", totalSalary));
        }
    }
}