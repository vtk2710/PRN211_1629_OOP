namespace PRN_1629;
public class Employee
{
    /*fields/data*/
    private int _id;
    private string _name;

    /*properties*/
    public double salary { get; set; } //.NET 5 +
    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }

    /*constructors*/
    public Employee()
    {

    }
    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        this.salary = salary;
    }

    public override string ToString()
    {
        return $"(ID = {this._id}, Name = {this._name}, Salary = {this.salary})";
    }
}