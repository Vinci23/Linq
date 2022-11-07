using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1programcic
{
    internal class Program
    {
        static void Main(string[] args)
        { 

		List<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John" } ,
				new Student() { StudentID = 2, StudentName = "Moin" } ,
				new Student() { StudentID = 3, StudentName = "Bill" } ,
				new Student() { StudentID = 4, StudentName = "Ram" } ,
				new Student() { StudentID = 5, StudentName = "Ron"  }
			};

			
		// LINQ Query Syntax
		/*var result = from student in studentList
					 where student.StudentName.Contains("o")
					 select student.StudentName;
		*/

		var result = studentList.Where(student => student.StudentName.Contains("o"));

			foreach (var str in result)
			{
				Console.WriteLine(str.StudentName);
			}
			


			Console.ReadKey();
		}
    }
	public class Student
	{

		public int StudentID { get; set; }
		public string StudentName { get; set; }
	}

}
