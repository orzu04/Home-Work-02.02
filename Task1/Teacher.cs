


public class Teacher:Person
{
    public string FaniDarsi { get; set; }
    public int Age { get; set; }


    public Teacher (string name , string fanidarsi,int age):base(name)
    {
        FaniDarsi = fanidarsi;
        Age = age;
    }

    public override void ToString()
    {
        if(Age > 25)
        {
            System.Console.WriteLine("The teacher is explaining");
            System.Console.WriteLine($"{Name} muallimai fanni {FaniDarsi}:");

        }
        else
        {
            System.Console.WriteLine("No Tea");
        }
    } 

}