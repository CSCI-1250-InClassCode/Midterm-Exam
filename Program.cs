/*
//#3. Rewrite the code shown in question 2 using an if statement. (8 pts)

int grade = 11;

if(grade == 9)
{
    System.Console.WriteLine("FRESHMAN");
}
else if(grade == 10)
{
    System.Console.WriteLine("SOPHOMORE");
}
else if(grade == 11)
{
    System.Console.WriteLine("JUNIOR");
}
else if(grade == 12)
{
    System.Console.WriteLine("SENIOR");
}
else //if(grade < 9 || grade > 12) DON"T WANT THIS!
{
    System.Console.WriteLine("INVALID GRADE NUMBER");
}

//#8 Write the correct C# statement(s) to prompt the user to store a string, and then allow the user to store a string.
//(4pts)

System.Console.Write("Store some string! ");
string someString = Console.ReadLine();

//#9 Write the correct C# statement(s) to prompt the user to store a number, and then allow the user to store a number in an 
// integer. (4 pts)

System.Console.Write("Store some number! ");
//int someInt = Convert.ToInt32(Console.ReadLine());
int someInt = int.Parse(Console.ReadLine());

//11
string firstName = "Santa";
string lastName = "Clause";
System.Console.WriteLine($"{firstName} {lastName}");

//12


for(int count = 10; count > 0; count--)
{
    System.Console.WriteLine(count);
}

System.Console.WriteLine("Blast Off!");

//13 using the do while
string cont;

do
{
    System.Console.Write("Enter a name! ");
    string name = Console.ReadLine();

    System.Console.WriteLine(name.ToUpper());
    System.Console.WriteLine(name.ToLower());
    System.Console.WriteLine(name[0]);
    System.Console.WriteLine(name[name.Length - 1]);

    System.Console.Write("Do you wish to continue? ");
    cont = Console.ReadLine();

    //14
    while(cont != "Y" && cont != "N")
    {
        System.Console.WriteLine("That was an invalid choice. Please enter a Y or N!");
        System.Console.Write("Do you wish to continue? ");
        cont = Console.ReadLine();
    }

}while(cont == "Y");

//13 using a while

string toCont = "Y";

while(toCont == "Y")
{
    System.Console.Write("Enter a name! ");
    string name = Console.ReadLine();

    System.Console.WriteLine(name.ToUpper());
    System.Console.WriteLine(name.ToLower());
    System.Console.WriteLine(name[0]);
    System.Console.WriteLine(name[name.Length - 1]);

    System.Console.Write("Do you wish to continue? ");
    toCont = Console.ReadLine();

    //14
    while(toCont != "Y" && toCont != "N")
    {
        System.Console.WriteLine("That was an invalid choice. Please enter a Y or N!");
        System.Console.Write("Do you wish to continue? ");
        toCont = Console.ReadLine();
    }


}*/

    string[] names = {"Mathew", "Steve", "Mallory", "Anne", "Jona", "Casper", "Smitty", "Brooke", "Patti"};

    /*System.Console.WriteLine(names[0]);
    System.Console.WriteLine(names[1]);
    System.Console.WriteLine(names[2]);
    System.Console.WriteLine(names[3]);
    System.Console.WriteLine(names[4]);*/

    for(int i = 0; i < names.Length; i++)
    {
        System.Console.WriteLine(names[i]);
    }

    int sum = 0;
    int tempNum;
    int counter = 0;

    System.Console.WriteLine("Keep entering grades until -1 is entered!");
    tempNum = int.Parse(Console.ReadLine());
    while(tempNum != -1)
    {   
        counter++;
        sum += tempNum;
        System.Console.WriteLine("Keep entering grades until -1 is entered!");
        tempNum = int.Parse(Console.ReadLine());
    }

    if(counter != 0)
    {
        System.Console.WriteLine((double)sum / counter);
    }

    