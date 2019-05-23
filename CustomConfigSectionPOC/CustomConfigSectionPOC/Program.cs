using QA_QC_GIS_Config.Config;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConfigSectionPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            QAQCConfigSection section = ConfigurationManager.GetSection("QAQCConfigSection") as QAQCConfigSection;

            Console.WriteLine("Below are Key value pairs read from App.config file...");
            for (int i = 0; i < section.Bundles.Count; i++)
            {
                Console.WriteLine("{0} - {1}", section.Bundles[i].Name, section.Bundles[i].Alias);
                Console.WriteLine("Layers ::");
                for (int j = 0; j < section.Bundles[i].Layers.Count; j++)
                {
                    LayerElement lyr = section.Bundles[i].Layers[j];
                    Console.WriteLine($"{lyr.Name}");

                    Console.WriteLine("Fields ::");
                    for (int k = 0; k < lyr.Fields.Count; k++)
                    {
                        FieldElement fld = lyr.Fields[k];
                        Console.WriteLine($"Key: {fld.Key} => Value: {fld.Value}");
                    }
                    Console.WriteLine("---------------");
                }
                Console.WriteLine("------------------------------------------------------");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
