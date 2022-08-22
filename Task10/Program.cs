Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int Number=int.Parse(Console.ReadLine());



void CreateArrayFromNumber (int x){

int [] array = new int[3];

array[0]=x/100;
array[1]=(x-array[0]*100)/10;
array[2]=x-array[0]*100-array[1]*10;

Console.Write($"{x} -> {array[1]}");
}
CreateArrayFromNumber(Number);


