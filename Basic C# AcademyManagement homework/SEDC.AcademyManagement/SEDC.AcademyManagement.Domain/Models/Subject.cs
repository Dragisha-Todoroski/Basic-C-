using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class Subject
    {
        public Subject(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
