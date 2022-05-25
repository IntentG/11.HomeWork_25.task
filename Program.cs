/*Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int result = 1;

if (numberA >= 1 && numberB >= 1)
    {
            for (int i = 0; i < numberB; i++)
            {
                result *= numberA;
            }
        Console.WriteLine($"Число {numberA} в степени {numberB} равно = {result}");
    } 
else 
    {
        Console.WriteLine("Введено не натуральное число, \n дальнейшая работа программы не возможна");
    }
