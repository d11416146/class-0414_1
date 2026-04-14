using System;

public class Person
{
    public virtual string GetName()
    {
        return "Person";
    }
}
public class Student : Person

{
    public override string GetName()
    {
        return "Student";
    }
}
public class Teacher : Person
{
    public new string GetName()
    {
        return "Teacher";
    }
}
