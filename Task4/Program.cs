﻿// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
int N = 6433; 
int a = 0;  // a хранит последнюю цифру числа N 
while (N > 0)
{
    a = N % 10;
    N = N / 10;
    Console.Write($"{a},  ");
}