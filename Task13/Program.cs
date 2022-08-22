Console.Clear();
Console.WriteLine("Введите число:");
int number=int.Parse(Console.ReadLine());
int startNumber=number;


int NumberOrder (int x){// метод узнает порядок числа (количество членов массива)
int multiplier=1;
do{
multiplier=multiplier*10;
}
while (x/multiplier>0);

double numberOrder=Math.Log10(Convert.ToDouble(multiplier));

return Convert.ToInt32(numberOrder);
}

int numberOrder=NumberOrder(number);

Console.WriteLine($"Порядок введённого числа равен {numberOrder}");

int[] array= new int[numberOrder];

int position=0;

while (position<array.Length){

    array[position]=number/Convert.ToInt32(Math.Pow(10.0, Convert.ToDouble(numberOrder-1)));
    Console.Write($"{array[position]} ");
    number=number-array[position]*Convert.ToInt32(Math.Pow(10.0, Convert.ToDouble(numberOrder-1)));   
    position++;
    numberOrder--; 
    
}
 Console.WriteLine();
Console.WriteLine("------------------------------");

Console.WriteLine("Задача 13. Третья цифра заданного числа:");

number=startNumber;

if (array.Length<3){
   
    Console.WriteLine($"{number} -> третьей цифры нет");
} else {
    
    Console.WriteLine($"{number} -> {array[2]}");
}
Console.WriteLine("------------------------------");





