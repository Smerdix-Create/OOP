//Первая реализация, через List
var ListAccount = new List<BankAccount>();
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
}


//Вторая реализация
BankAccount[] accountNumbers = new BankAccount[5];
accountNumbers[0] = new(343454, TypeBankAccount.Credit);
accountNumbers[1] = new(546456, TypeBankAccount.Accounting);
accountNumbers[2] = new(3244, TypeBankAccount.Credit);
accountNumbers[3] = new(23, TypeBankAccount.Current);
accountNumbers[4] = new(2342342344, TypeBankAccount.Deposit);

foreach (BankAccount bankAccount in accountNumbers)
{
    bankAccount.GetAccountNumber();
}

Console.ReadKey(true);