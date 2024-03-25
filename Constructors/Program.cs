using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
     class Program
    {
        static void Main(string[] args)
        {
            IPersonManager personManager = new CustomerManager();
            personManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();


        }        

    }

    interface IPersonManager
    {
        void Add();
        void Update();
        
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //musteri ekleme kodlari yazilir
            Console.WriteLine("müsteri eklendi");

        }

        public void Update()
        {

        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("personel güncellendi");
        }
    }

}
