class Program
{
    public static void Main()
    {
        Person person = new Person("Aaron", "Riddle", 25, 175);
        Console.WriteLine(person.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 45, 279, "Knife");
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}
