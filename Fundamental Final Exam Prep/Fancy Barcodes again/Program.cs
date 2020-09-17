using System;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes_again
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^(?<starttag>[@]{1}[#]+)(?<barcode>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})(?<endtag>[@]{1}[#]+)$");
            int barcodesCount  = int.Parse(Console.ReadLine());

            for (int i = 0; i < barcodesCount; i++)
            {
                string barcode = Console.ReadLine();

                Match validBarcode = pattern.Match(barcode);
                
                if (validBarcode.Success)
                {
                    string productGroup = string.Empty;
                    var theBarcode = validBarcode.Groups["barcode"].Value.ToCharArray();

                    foreach (var symbol in theBarcode)
                    {
                        if (char.IsDigit(symbol))
                        {
                            productGroup += symbol;
                        }

                        else
                        {
                            continue;
                        }
                    }

                    if (productGroup == string.Empty)
                    {
                        productGroup = "00";
                    }


                    Console.WriteLine($"Product group: {productGroup}");

                }

                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
