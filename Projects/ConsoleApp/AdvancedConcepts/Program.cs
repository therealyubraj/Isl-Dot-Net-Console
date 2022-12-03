using AdvancedConcepts.Week5;
using System.Reflection.Metadata.Ecma335;

SerailizeExample.SerializeJSON();

List<SampleModel> modelList = new List<SampleModel>
            {
                new SampleModel{FName = "Hero", LName = "Babu",Commision_pct = 2.0f, Salary = 20000},
                new SampleModel{FName = "Gunda", LName = "Nani",Commision_pct = 5.0f, Salary = 70000},
                new SampleModel{FName = "Ram", LName = "Bahadur",Commision_pct = 0.0f, Salary = 90000},
                new SampleModel{FName = "Nasa", LName = "Ghimire",Commision_pct = 0.0f, Salary = 10000},
                new SampleModel{FName = "Hari", LName = "Kumari",Commision_pct = 3.0f, Salary = 20000},
                new SampleModel{FName = "Jhyaure", LName = "Madal",Commision_pct = 7.0f, Salary = 90000},
                new SampleModel{FName = "Mitho", LName = "Vatt",Commision_pct = 10.0f, Salary = 100000},
                new SampleModel{FName = "Bhuteko", LName = "Saag",Commision_pct = 2.0f, Salary = 50000},
                new SampleModel{FName = "Hero", LName = "Kukhuro",Commision_pct = 9.0f, Salary = 10000},
                new SampleModel{FName = "Udeko", LName = "Parewa",Commision_pct = 6.0f, Salary = 230000},
            };

// selection
List<SampleModel> salaryGreaterThan10k = modelList.Where(x => x.Salary > 10000).ToList();

// contains
List<SampleModel> HeroFirstName = modelList.Where(x => x.FName.Contains("Hero")).ToList();

// sorting
List<SampleModel> sortedBySalary = modelList.OrderBy(x => x.Salary).ToList();

//projection
List<float> commision_pcts = modelList.Select(x => x.Commision_pct).ToList();


void printList<t>(ref List<t> l)
{
    foreach (var item in l)
    {
        Console.WriteLine(item.ToString());
    }
    Console.WriteLine();
}

Console.WriteLine("salary greater than 10k");
printList<SampleModel>(ref salaryGreaterThan10k);

Console.WriteLine("Hero first name");
printList<SampleModel>(ref HeroFirstName);

Console.WriteLine("sorted by salary");
printList<SampleModel>(ref sortedBySalary);

Console.WriteLine("commission percentages");
printList<float>(ref commision_pcts);