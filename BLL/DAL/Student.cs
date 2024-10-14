using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DAL
{
	public class Student
	{
		private int ID { get; set; }
		public string Name { get; set; }

		public string Surname { get; set; }
		public DateTime BirthDate { get; set; }
		public double GPA { get; set; }


	}
}
