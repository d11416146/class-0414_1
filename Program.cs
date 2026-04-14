namespace class_0414_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s=new Student();
            Console.WriteLine(s.GetName());

            Person p=new Student();
            Console.WriteLine(p.GetName());

            Teacher t=new Teacher();
            Console.WriteLine(t.GetName());

            Person p2 = new Teacher();
            Console.WriteLine(p2.GetName());

            Console.WriteLine(((Teacher)p2). GetName());


        }
    }
}
