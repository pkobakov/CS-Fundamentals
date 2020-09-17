using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int barcodesCount  = int.Parse(Console.ReadLine());

            string pattern = @"^(?<start>@#+)(?<product>([A-Z][A-Za-z0-9]{4,}[A-Z]))(?<end>@#+)$";

            for (int i = 1; i <= barcodesCount; i++)
            {
                string currentCode = Console.ReadLine();
                string code = string.Empty;
                Match codeValidation = Regex.Match(currentCode, pattern);

                if (codeValidation.Success)
                {
                    string productName = codeValidation.Groups["product"].Value;
                    

                    for (int k = 0; k < productName.Length; k++)
                    {
                        if (Char.IsDigit(productName[k]))
                        {
                            code += productName[k];
                            
                        }
                    }
                    if (code==string.Empty)
                    {
                        code = "00";
                    }
                    Console.WriteLine($"Product group: {code}");
                }

                else
                {
                    Console.WriteLine("Invalid barcode");

                }

               
            }
            
        }
    }
}
