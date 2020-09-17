using System;

namespace High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int aimedLengh = int.Parse(Console.ReadLine());            
            int jumps = 0;

            int startLengh = aimedLengh - 30;

            while (startLengh <= aimedLengh )
            {


                for (int attempt = 1; attempt <= 3; attempt++)
                {
                    jumps++;
                    int jumpedLengh = int.Parse(Console.ReadLine());

                    if (jumpedLengh > startLengh && jumpedLengh < aimedLengh)
                    {

                        startLengh += 5;
                        break;
                    }
                    else
                    {
                        if (attempt == 3)
                        {
                            Console.WriteLine($"Tihomir failed at {startLengh}cm after {jumps} jumps.");
                            return;
                        }
                    }
                    if (jumpedLengh>=aimedLengh)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {startLengh}cm after {jumps} jumps.");
                    } 
                }

            }
            
        }
    }
}
