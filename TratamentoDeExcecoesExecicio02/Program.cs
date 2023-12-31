﻿using TratamentoDeExcecoesExecicio02.Entities;
using TratamentoDeExcecoesExecicio02.Entities.Exceptions;
using System.Globalization;


Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string holder = Console.ReadLine();
Console.Write("Initial balance: ");
double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account acc = new Account(number, holder, balance, withDrawLimit);

Console.WriteLine();
Console.Write("Enter amount for withdraw: ");
double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
try
{
    acc.WithDraw(withDraw);
    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
} 
catch (DomainException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
} 
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}
