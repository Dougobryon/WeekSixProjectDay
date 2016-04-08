using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilEightNine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meeting Minutes Management Software   ");
 //Begin populating employee list below
 
Employee employee1 = new Employee()
{
Department = Marketing A,
Name = "Allen Smith",
};
Employee employee2 = new Employee()
{
Department = Marketing B,
Name = "Brian Smith",
};
Employee employee3 = new Employee()
{ 
Department = Marketing C,
Name = "Chet Smith",
};
Employee employee4 = new Employee()
{
Department = Tech A,
Name = "Aaron Smith",
};
Employee employee5 = new Employee()
{
Department = Tech B,
Name = "Bill Smith",
};
Employee employee6 = new Employee()
{ 
Department = Tech C,
Name = "Cris Smith",
};
Employee employee7 = new Employee()
{
Department = Exec A,
Name = "Anthony Smith",
};
Employee employee8 = new Employee()
{
Department = Exec B,
Name = "Bruce Smith",
};
Employee employee9 = new Employee()
{ 
Department = Exec C,
Name = "Charles Smith",
};

Dictionary<string, Employee> dictionaryEmployees = new Dictionary<string, Employee>();
dictionaryEmployees.Add(employee1.ID, employee1);
dictionaryEmployees.Add(employee2.ID, employee2);
dictionaryEmployees.Add(employee3.ID, employee3);
dictionaryEmployees.Add(employee4.ID, employee4);
dictionaryEmployees.Add(employee5.ID, employee5);
dictionaryEmployees.Add(employee6.ID, employee6);
dictionaryEmployees.Add(employee7.ID, employee7);
dictionaryEmployees.Add(employee8.ID, employee8);
dictionaryEmployees.Add(employee9.ID, employee9);

Console.WriteLine("Meeting Minutes Management Software");
using (StreamWriter writer = new StreamWriter("software.txt"))
{
	    writer.WriteLine("Create Meeting");
	    writer.WriteLine("View Team");
	    writer.WriteLine("Exit");
}
Console.WriteLine("Choose a Menu Option ");
if (string writer.WriteLine = "Create Meeting");
{
    Console.WriteLine string text.Header = ("Acme Company");
    Console.WriteLine string text.Header = ("123 Main Street");
    Console.WriteLine string text.Header = ("Meeting Minutes");
}
elseif(string writer.WriteLine = "View Team");
new StreamWriter("MeetingType.txt");
{
    writer.WriteLine("Marketing");
    writer.WriteLine("Tech");
    writer.WriteLine("Exec");
if(string writer.WriteLine = "Marketing")
    Console.WriteLine("Allen Smith, Brian Smith, Chet Smith");
else if(string writer.WriteLine = "Tech")
    Console.WriteLine("Aaron Smith, Bill Smith, Cris Smith");
else if(string writer.WriteLine = "Exec")
    Console.WriteLine("Anthony Smith, Bruce Smith, Charles Smith");
else
{
Console.WriteLine"You've chosen to exit - Goodbye! ";
}
string text = "Enter team member recording the minutes, ";
        System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);
string text = "Enter team member leading the meeting, ";
    System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);
string text = "Enter meeting date in MMDDYY format, ";
    System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);
string text = "Enter meeting type - choose from the list below, ";
    System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);
new StreamWriter("MeetingType.txt");
List<string> listOfStrings = new List<string>();
listOfStrings.Add("Marketing");
listofStrings.Add("Tech");
listofStrings.Add("Exec");
{
    writer.WriteLine("Marketing");
    writer.WriteLine("Tech");
    writer.WriteLine("Exec");
using(StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt))
{
	foreach (string line in lines)
	outputFile.WriteLine(line);
}
public class StreamWriter : TextWriter
{
Console.WriteLine("Enter meeting topic");
Console.WriteLine("Enter notes for this topic");
Console.WriteLine("Would you like to enter notes for another topic?");
}
{
if (string writer.WriteLine = "Yes ");
}
Console.WriteLine("Please enter topic name and notes");
{ 
else
Console.WriteLine("All text written to the file");
        }
    }
