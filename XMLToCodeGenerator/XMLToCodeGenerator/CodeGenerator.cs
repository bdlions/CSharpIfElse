using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using freemarker.template;
using java.io;
using java.util;
using System.Xml.Serialization;

namespace XMLToCodeGenerator
{
    public class CodeGenerator
    {
        /*public int getInt()
        {
          
            Assembly _assembly;
            _assembly = Assembly.GetExecutingAssembly();

            string[] names = _assembly.GetManifestResourceNames();
            foreach (string name in names)
                System.Console.WriteLine(name);
            TextReader _imageStream;
            _imageStream = new StreamReader(_assembly.GetManifestResourceStream("XMLToCodeGenerator.code.ftl"));
            Console.ReadLine();

            string result = _imageStream.ReadToEnd();
            Console.WriteLine(result);
            Console.ReadLine();
            return 10;
        }*/

        public void serialize()
        {
            Assembly _assembly;
            _assembly = Assembly.GetExecutingAssembly();
            string[] names = _assembly.GetManifestResourceNames();
            //foreach (string name in names)
            //    System.Console.WriteLine(name);
            Pages pages;

            using (var stream = new System.IO.StreamReader(_assembly.GetManifestResourceStream("XMLToCodeGenerator.sample.blocks1.xml")))
            {
                var serializer = new XmlSerializer(typeof(Pages));
                pages = (Pages)serializer.Deserialize(stream);
                
                System.Console.WriteLine("No of pages: "+pages.page.Count);
                System.Console.WriteLine("First page is : " + pages.page[0].pageName);
                System.Console.WriteLine("Second page is : " + pages.page[1].pageName);
            }
        }

        public String testFreemarker()
        {
             Assembly _assembly;
            _assembly = Assembly.GetExecutingAssembly();
            //Console.WriteLine(_assembly.
            try{
                Configuration cfg = new Configuration();
                cfg.setDirectoryForTemplateLoading(new File("template"));
                //cfg.setDirectoryForTemplateLoading(new File(""));
                cfg.setObjectWrapper(new DefaultObjectWrapper());
			  
                
                Template temp = cfg.getTemplate("c.ftl");
               
                Map root = new HashMap();
			    root.put("codeGen", this);
    	
			    ByteArrayOutputStream outputStream = new ByteArrayOutputStream();
                Writer output = new OutputStreamWriter(outputStream);
    	
			    temp.process(root, output);
			    output.flush();
                //System.Console.WriteLine(outputStream.toString());
                return outputStream.toString();
                
		    }
		    catch (IOException exception) {
                
		    } catch (TemplateException exception) {
               
		    }
            return "";
        }
    }
}
