using System;

public class CitizenProfile
{
    public string FullName { get; set; }
    public string IDNumber { get; set; }
    public int Age { get; set; }
    public string CitizenshipStatus { get; set; }

    public CitizenProfile(string name, string id, string status)
    {
        FullName = name;
        IDNumber = id;
        CitizenshipStatus = status;
        Age = CalculateAge();
    }

    private int CalculateAge()
    {
        string yy = IDNumber.Substring(0, 2);
        string mm = IDNumber.Substring(2, 2);
        string dd = IDNumber.Substring(4, 2);

        int year = int.Parse(yy);
        year += (year > 25) ? 1900 : 2000;

        DateTime birthDate = new DateTime(year, int.Parse(mm), int.Parse(dd));
        int age = DateTime.Now.Year - birthDate.Year;

        if (DateTime.Now < birthDate.AddYears(age))
            age--;

        return age;
    }

    public string ValidateID()
    {
        if (IDNumber.Length != 13)
            return "Invalid: ID must be 13 digits";

        if (!long.TryParse(IDNumber, out _))
            return "Invalid: ID must be numeric";

        if (Age < 0 || Age > 120)
            return "Invalid age calculated";

        return "ID is valid";
    }
}