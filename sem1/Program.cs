//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Console.WriteLine("введите трехзначное число:");
//int num = Convert.ToInt32(Console.ReadLine());
//int num1 = num / 10;
//int number1 = num % 10; 
//Console.WriteLine(num +"->" + num / 10 % 10 );



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("введите  число:");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num % 10;
int num2 = num / 10 % 10;
bool num3 = false  ;
if (  num >  num  % 10 ){
    Console.WriteLine(num +"->"+ num1   );
} 
else if (num >  num / 10 % 10){
    Console.WriteLine(num +"->"+ num2  );
}
else
{
    Console.WriteLine(num3  );
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

