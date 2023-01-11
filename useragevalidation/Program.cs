// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal isestada tema perekonnanime
//lähtus´des kasutaja valikust, rakendu ś tervitab kasjutajat järgmiselt
//"welcome, mr [kasutaja perekonnanimi] / "welcomr ms (kasutaja perekonnanimi]

Console.WriteLine("peale, select your gender (m/f)");

char userGender = char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string formaadis
Console.WriteLine("please enter your last name:");

string userLastName = Console.ReadLine();
if(userGender == 'm')
{
    Console.WriteLine($"welcome, mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"welcome, ms.{userLastName}!");
}

else
{
    Console.WriteLine($"welcome! {userLastName}");
}


