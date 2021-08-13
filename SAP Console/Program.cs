using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassSAP;

namespace SAP_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            string SAP_Client = "ABB";

            SAP_Connection SAP = new SAP_Connection();
           
            //Type[] exampleClasses = new Type[] //{ typeof(StepByStepClient), typeof(StepByStepServer), typeof(SampleDestinationConfiguration) };

            bool keepGoing = true;

            /*do
            {
                Console.WriteLine("\n===== TUTORIAL EXAMPLES =====");
                for (int i = 0; i < exampleClasses.Length; i++)
                {
                    Console.Write((i + 1).ToString());
                    Console.Write(' ');
                    Console.WriteLine("??");//OutputName(exampleClasses[i].Name));
                }
                Console.WriteLine("E Exit");
                Console.WriteLine("T Change Trace Directory (currently is {0})", ""); // RfcTrace.TraceDirectory);
                Console.Write("\nYour Choice: ");
                string input = Console.ReadLine();
                bool inputRecognized = true;
                int n;

                if (input.Equals("E", StringComparison.OrdinalIgnoreCase))
                {
                    keepGoing = false;
                }
                else if (input.Equals("T", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("New trace directory: ");
                    string traceDir = Console.ReadLine();
                    try
                    {
                        //RfcTrace.TraceDirectory = traceDir;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
                else if (int.TryParse(input, out n) && n >= 1 && n <= exampleClasses.Length)
                {
                    //keepGoing = SubMenu(exampleClasses[n - 1]);
                }
                else
                {
                    inputRecognized = false;
                }

                if (!inputRecognized)
                {
                    Console.WriteLine("\nEnter 1 - {0} for an example, 'T' or 't' to change the current trace directory, 'E' or 'e' to exit", exampleClasses.Length.ToString());
                }
            }
            while (keepGoing);

            Console.WriteLine("\nBYE");*/
        }
    }
}
