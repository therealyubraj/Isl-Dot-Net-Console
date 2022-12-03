using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts.Week5
{
    public class SampleModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FName { get; set; }
        public string LName { get; set; }
        public int Salary { get; set; }
        public float Commision_pct { get; set; }

        public override string ToString()
        {
            return "ID: " + Id + " FName: " + FName + " LName: " + LName + " Commission pct: " + Commision_pct + " Salary: " + Salary;
        }
    }

}
