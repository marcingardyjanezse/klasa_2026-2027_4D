
Student student = new Student(19);
//student.SetAge(student.GetAge() + 1);

student.Age = 19;
student.Age++;
Console.WriteLine("Wiek ucznia" + student.Age);

class Student
{
    public Student(int age)
    {
        this.age = age;
    }

    private int age;
    public int Age
    {
        get
        {
            Console.WriteLine("Pobrałeś wartość age");
            return age;
        }
        set
        {
            age = value;
            //OnAgeChange();
            Console.WriteLine("Zmieniłeś wartość age");
        }
    } 
	
	//ZADANIE:
	//Zrób klase Employee, która ma zmienne firstName, lastName i salary oraz Propertisy umożliwiające dostęp
	//Niech properties zgłasza, że została zmieniona zmienna

}