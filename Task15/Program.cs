Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели:");
int number=int.Parse(Console.ReadLine());

if (number>0 && number<6){

    Console.Write($"{number} -> это будний день");

} else if (number>5 & number<8){

        Console.Write($"{number} -> это выходной день");

} else{

        Console.Write("Вы ввели недопустимое значение. Введите число от 1 до 7");


}