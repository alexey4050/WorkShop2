// Задача 13. Напишите программу, которая выводит третью цифрузаданного числа или сообщает. что третьей цифры нет.

Console.Write("Задача 13. ");
Console.WriteLine("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
    Console.WriteLine("третья цифра -> " + anyNumberText[2]);    
}
else{
    Console.WriteLine("третьей цифры нет");
}