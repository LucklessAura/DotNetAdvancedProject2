using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCF;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Starting Server \n");
            ServiceHost host = new ServiceHost(typeof(ClassesWCF), new Uri("http://localhost:8000/PC"));

            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine("adress : {0}\t binding : {1}\t contract : {2}", se.Address, se.Binding.Name, se.Contract.Name);
            }

            host.Open();
            Console.WriteLine("Server Started");
            Console.WriteLine("Press enter to close");
            Console.ReadKey();
            host.Close();
        }
    }
}
