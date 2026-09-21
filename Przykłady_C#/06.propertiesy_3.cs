Student student = new Student(19);
//student.SetAge(student.GetAge() + 1);

student.Age = 19;
student.Age++;
Console.WriteLine(student.Age);

class Student
{
    public Student(int age)
    {
        this.age = age;
    }

    //private int age;
    //public int Age
    //{
    //    get
    //    {
    //        return age;
    //    }
    //    set
    //    {
    //        age = value;
    //    }
    //} 

   // public int Age { get; set; } 

    //private int age;
    //public int Age
    //{
    //    get => age;
    //    set
    //    {
    //        //OnAgeChange();
    //        age = value;
    //    }
    //}
	
	//ZADANIE:
	//Zrób klase Employee, która ma propshort FirstName, LastName i Salary

}