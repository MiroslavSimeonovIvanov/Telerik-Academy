using System;

namespace Methods
{
    public class StudentInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(StudentInformation other)
        {
            DateTime firstDate = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            DateTime secondDate = DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
            bool result = firstDate < secondDate;
            return result;
        }

        public static void Main()
        {
            StudentInformation peter = new StudentInformation() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            StudentInformation stella = new StudentInformation() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
