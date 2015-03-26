using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Students
    {

        public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string FN { get; private set; }
    public string Tel { get; private set; }
    public string Email { get; private set; }
    public List<byte> Marks { get; private set; }
    public byte GroupNumber { get; private set; }
    public int Age { get; private set; }

    // CONSTRUCTORS

    public Students(string firstName, string lastName, int age, string FN, string Tel, byte group, string email)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.FN = FN;
        this.Tel = Tel;
        this.Email = email;
        this.Marks = new List<byte>();
        this.GroupNumber = group;
    }

    // METHODS

    public static Students[] FirstBeforeLast(Students[] students)
    {
        return students.Where(x => x.FirstName.CompareTo(x.LastName) < 0).ToArray();
    }

    public static Students[] AgeRange(Students[] students, int low, int high)
    {
        return students.Where(x => x.Age > low && x.Age < high).ToArray();
    }

    public void SetEmail(string newMail)
    {
        Email = newMail;
    }

    public void AddMark(byte mark)
    {
        Marks.Add(mark);
    }


    public static Students[] OrderStudents(Students[] students)
    {
        return students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToArray();
    }
    public static List<Students> StudentGroups(Students[] students, int group)
    {
        return students.Where(st => st.GroupNumber == group).OrderBy(st => st.FirstName).ToList();
    }

    public static List<Students> ExtractEmail(Students[] students, string email)
    {
        return students.Where(x => x.Email.Contains(email)).ToList();
    }

    public static List<Students> FromCity(Students[] students, string phoneStart)
    { return students.Where(st => st.Tel.StartsWith("02")).ToList();    }


    public static List<Students> Dvoiki(Students[] students)
    { return students.Where(s => s.Marks.Count(m => m == (byte)2) == 2).ToList(); }

   
    



        
     
    public override string ToString()
    {
        return string.Format("{0} {1} Age:{2} Faculty number:{3} Tel:{4} Mail:{5} Marks:{6} Group:{7}", FirstName, LastName, Age, FN, Tel, Email, string.Join(",", Marks), GroupNumber);
    }
    }
}
