using System;

namespace Interfaces2
{
    class Program
    {

        //interfaceler newlenemez
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();

            IPersonManager internManager = new InternManager();
            internManager.update();
            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(employeeManager);
            
        }
    }

    interface IPersonManager
    {
        //unimplemented Operation
        void Add();
        void update();
    }

    //İnherits-Class-----------------İmplement-İnterface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer is added");
        }

        public void update()
        {
            Console.WriteLine("Customer is updated");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee is added");
        }

        public void update()
        {
            Console.WriteLine("Employee is updated");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern is Added");
        }

        public void update()
        {
            Console.WriteLine("Intern is Updated");
        }
    }

}

