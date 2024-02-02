


class Student:Person
{
    public int Kurs { get; set; }


    public string Ihtisos { get; set; }

    public Student(string name , int kurs, string ihtisos):base(name)
    {
        Kurs = kurs;
        Ihtisos = ihtisos;
    }

    public void Study (){

        System.Console.WriteLine($" The student is studying");
        if   ( Name ==Name && Kurs == Kurs && Ihtisos == Ihtisos )
        {
                System.Console.WriteLine($"Yes Carlos is Student");
                System.Console.WriteLine($"{Name} Honandai Kursi {Kurs} -i ihtisosi {Ihtisos}");
        }
        else{
            System.Console.WriteLine($"No ");
        }
    }
}