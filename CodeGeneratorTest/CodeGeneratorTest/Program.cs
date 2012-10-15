using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XMLToCodeGenerator;
using System.IO;
using System.Reflection;

namespace CodeGeneratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.init();
            CodeGenerator c = new CodeGenerator();
            //c.getInt();
            //System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer();
            Console.WriteLine("Freemarker code---------");
            Console.WriteLine(c.testFreemarker());

            Console.WriteLine("Get object after parsing output type XML--------");
            c.serialize();

            Console.ReadLine();
        }

    }
}

