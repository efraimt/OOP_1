

using HackerUs.UI;
using SwapLogic;

Stam();
void Stam()
{
    Student efraim = new Student() { FirstName = "Efraim", LastName = "Teicher" };
    Student adam = new Student() { FirstName = "Eran", LastName = "Fillo" };


    Console.WriteLine(Student.BookName);

    SwapClass.Swap(efraim, adam);
    Console.WriteLine(efraim.FirstName);//Efraim

}