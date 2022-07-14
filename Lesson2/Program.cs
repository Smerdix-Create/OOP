//Первая реализация, через List
/*var ListAccount = new List<BankAccount>();
ListAccount.Add(new BankAccount(546546567));
ListAccount.Add(new BankAccount(TypeBankAccount.Credit));
ListAccount.Add(new BankAccount(32434, TypeBankAccount.Credit));

for (int i = 0; i < 3; i++)
{
    GetAccount(ListAccount[i]);
    Console.WriteLine();
}

void GetAccount(BankAccount account)
{
    Console.WriteLine($"Счет: {account.Number}");
    Console.WriteLine($"Тип счета: {account.Type}");
    Console.WriteLine($"Баланс счета: {account.Balance}");
    Console.WriteLine();
}*/


//Вторая реализация
BankAccount[] accountNumbers = new BankAccount[6];
accountNumbers[0] = new(343454, TypeBankAccount.Credit);
accountNumbers[1] = new(546456, TypeBankAccount.Accounting);
accountNumbers[2] = new(3244, TypeBankAccount.Credit);
accountNumbers[3] = new(23);
accountNumbers[4] = new(TypeBankAccount.Deposit);
accountNumbers[5] = new(343454, TypeBankAccount.Credit);

accountNumbers[4].TransferMoney(accountNumbers[3], 23);

foreach (BankAccount bankAccount in accountNumbers)
{
    Console.WriteLine($"Счет: {bankAccount.Number}");
    Console.WriteLine($"Тип счета: {bankAccount.Type}");
    Console.WriteLine($"Баланс счета: {bankAccount.Balance}");
    Console.WriteLine();
}


Console.WriteLine(accountNumbers[0] == accountNumbers[5]);
Console.WriteLine(accountNumbers[0] != accountNumbers[5]);
Console.WriteLine(accountNumbers[0].Equals(accountNumbers[5]));
Console.WriteLine(accountNumbers[0].GetHashCode());
Console.WriteLine(accountNumbers[5].GetHashCode());
Console.WriteLine(accountNumbers[0].ToString());

Console.ReadKey(true);
