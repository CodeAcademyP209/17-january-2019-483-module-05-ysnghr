using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem
{
    class Workerlist
    {
        static int id = 1;
        public Workerlist(string name, string surname, string email, int salary, int workHours, DateTime regdate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Salary = salary;
            WorkHours = workHours;
            WorkerRegDate = regdate;
            id++;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public int WorkHours { get; set; }
        public DateTime WorkerRegDate { get; set; }

    }
}
