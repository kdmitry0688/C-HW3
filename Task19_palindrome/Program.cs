string xText;
Console.WriteLine("Введите пятизначное число: ");
xText = Console.ReadLine();
Console.WriteLine( Sunasad(xText));


string Sunasad(string xText)
{
if ((xText[0] == xText[4]) && (xText[1] == xText[3]))
 {
    return ("Введеное число является палиндромом");
 }
 else
 {
    return "Введеное число не является палиндромом"; 
 }
}