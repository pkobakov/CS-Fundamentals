using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
           
            int doctors = 7;

            int patientsTreated = 0;
            int patientsUntreated = 0;
            int totalPatientsTreated = 0;
            int totalPatiensUntreated = 0;

            for (int currentDay = 1; currentDay <= period; currentDay++)
            {
                int patientsCount = int.Parse(Console.ReadLine());

                if (currentDay % 3 == 0 && patientsUntreated>patientsTreated)
                {
                    ++doctors;

                }

                if (patientsCount <= doctors)
                {
                      patientsTreated = patientsCount;
                      totalPatientsTreated += patientsTreated;

                }
                else
                {
                      patientsTreated = doctors;
                      totalPatientsTreated += patientsTreated;

                      patientsUntreated = patientsCount - doctors;
                      totalPatiensUntreated += patientsUntreated;
                       
                       
                }

                  
               
            }
            
           
            Console.WriteLine($"Treated patients: {totalPatientsTreated}.");
            Console.WriteLine($"Untreated patients: {totalPatiensUntreated}.");

        }


    }
}
