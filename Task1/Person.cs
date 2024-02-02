


public class Person 
{

public string Name { get; set; }

public Person (string name)
{
    Name = name;
}

    public virtual void ToString(){
        System.Console.WriteLine($"{Name}The student is studying");
    }

}