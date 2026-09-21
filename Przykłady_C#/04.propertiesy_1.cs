
//Pytanie
//Po co tworzymy zmienne prywatne, a do nich publiczne gety i sety?
//Przykład z Pilotem-TV
//Przykład z HotDogiem


Student student = new Student(19);
student.SetAge(student.GetAge() + 1);


class Student
{
    public Student(int age)
    {
        this.age = age;
    }

    private int age;
    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return age;
    }

    //Problem: Wiele krótkich metod Set i Get
    //Ale one są potrzebne bo jeśli nagle trzeba będzie wywołać jakiś OnAgeChange to z publiczną zmienną się nie będzie dało
    //Rozwiązanie? - Propertiesy

}