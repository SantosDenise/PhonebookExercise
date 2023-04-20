using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory
{
    public class AddPhNo
    {
        public Dictionary<string, string> contacts = new Dictionary<string, string>();

        public void WritingInFile(string FullName, string PhoneNo)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\DBS\OneDrive - Dublin Business School (DBS)\Desktop\AlgorithmDataStructure_2023\PhoneDirectory\ContactList.txt", true))
            {
                writer.WriteLine($"{FullName},{PhoneNo}");
            }

        }
        public void ReadingFromFile()
        {
            if (File.Exists(@"C:\Users\DBS\OneDrive - Dublin Business School (DBS)\Desktop\AlgorithmDataStructure_2023\PhoneDirectory\ContactList.txt"))
            {
                using (StreamReader reader = new StreamReader(@"C:\Users\DBS\OneDrive - Dublin Business School (DBS)\Desktop\AlgorithmDataStructure_2023\PhoneDirectory\ContactList.txt"))
                {
                    while (reader.Peek() >= 0)
                    {
                        string line = reader.ReadLine();
                        string[] array = line.Split(',');
                        string name = array[0];
                        string phoneNum = array[1];
                        contacts.Add(phoneNum, name);
                    }
                }

            }
        }

        public void UpdateContactsFiles()
        {
            // get the local contact dict
            string filePath = @"C:\Users\DBS\OneDrive - Dublin Business School (DBS)\Desktop\AlgorithmDataStructure_2023\PhoneDirectory\ContactList.txt";

            //delete the file
            if (File.Exists(filePath)) 
            {
                File.Delete(filePath);
            }

            //update the file
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (TextWriter tw = new StreamWriter(fs))

                    foreach (KeyValuePair<string, string> kvp in contacts)
                    {
                        tw.WriteLine(string.Format("{1},{0}", kvp.Key, kvp.Value));
                    }
            }

        }

    }
}