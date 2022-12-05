

Console.WriteLine("35");

var efraim = new Person();
var efraim1 = efraim;
Console.WriteLine(efraim.Id);//0
ChangePerson(efraim);
Console.WriteLine(efraim.Id);//0

int age = 29;
ChangeInt(age);
Console.WriteLine(age);//29
string s3 = "Moshe";
string s4 = s3;
s4 = "ttt";


void ChangePerson(Person person) {
    person.Id = 5;
}
void ChangeInt(int X) {
    X = 5;
}


void ChangeString(string s)
{
    s="text";
}



internal class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public void Stam()
    {
        Console.WriteLine("Stam");
    }
}

class Student : Person
{
    private void Stam1()
    {
        Console.WriteLine("Stam1");
        Stam();
    }
}




//IS A
//HAS A
//Consist of
