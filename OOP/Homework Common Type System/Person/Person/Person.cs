using System.Text;
namespace Person
{
    public class Person
    {
        public string Name { get; set; }
        public uint? Age { get; set; }

        public override string ToString()
        {
            StringBuilder personInfo = new StringBuilder();

            personInfo.AppendLine("Name: " + this.Name);
            personInfo.Append("Age: ");

            
            if (this.Age == null)
            {
                personInfo.AppendLine("Not specified.");
            }
            else
            {
                personInfo.AppendLine("" + this.Age);
            }

            return personInfo.ToString();
        }
    }
}
