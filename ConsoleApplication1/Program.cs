using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            String line;
            List<string> myLocCollection = new List<string>();

            //int i = 0; //used to create a list of arrays
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\users\\keith\\desktop\\sample.txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //does the line contain a LOC
                    if ( line.Contains("LOC"))
                            {
                                //see how many delimiters there are
                                int count = 0;
                                foreach (char c in line)
                                    if (c == '+') { 
                                        count++;
                                    }
                        int sumElements = count + 1; // if there are 2 delimiters then there are 3 Elements
                        //Console.WriteLine(count+" "+sumElements);
                        //break down the string
                        string locElement1, locElement2;

                        int delimiterPos1 = line.IndexOf('+');
                        int strEndPos = line.IndexOf("'");
                        string secondPartOfString = line.Substring(delimiterPos1, line.Length);
                        Console.WriteLine(secondPartOfString);
                        
                       //   int strEndPos = line.IndexOf("'");
                       // Console.WriteLine(delimiterPos1 + " " + delimiterPos2);
                       // locElement1 = line.Substring(delimiterPos1+1,delimiterPos2);
                       //locElement2 = line.Substring(delimiterPos2, strEndPos);
                       // Console.WriteLine(strEndPos);
                       // Console.WriteLine(locElement1);

                        //add them into the array                        
                        //myLocCollection.Add(string);
                                
                        }
                    

 
                    //write the lie to console window
                    Console.WriteLine(line);

                    //Read the next line
                    line = sr.ReadLine();
                }
                Console.ReadKey();
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            //halt the screen to stop the console closing automatically
            Console.Write("Press any key to continue");
            Console.ReadLine();
        }
       
    }
}
