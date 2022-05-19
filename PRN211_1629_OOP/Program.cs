namespace PRN_1629;

using System.Collections;
using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        /*Employee e = new Employee();
        e.Id = 1;
        e.Name = "Khanh";
        e.salary = 150.55d;
        Clear();
        WriteLine(e);*/

        ArrayList list = new ArrayList();
        list.Add(new Employee(1, "a", 100));
        list.Add(new Employee(2, "b", 200));
        list.Add(new Employee(3, "c", 300));
        list.Add(new Employee(4, "d", 400));
        list.Add(new Employee(5, "e", 500));
        list.Add(new Employee(6, "f", 600));

        Display(list);
    }

    private static void Display(ArrayList list)
    {
        /*foreach(Employee e in list) {
            WriteLine(e);
        }*/

        for (int i = 0; i < list.Count; i++) {
            WriteLine(list[i]);
        }
    }
}