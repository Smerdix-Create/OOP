//Для физических лиц
public enum TypeBankAccount
{
    Current,
    Accounting,
    Credit,
    Deposit,
}

public class BankAccount
{

    private static int accountNumber = 1;

    private int _number;

    public decimal Balance { get; /* private */ set; }

    public TypeBankAccount Type { get; private set; }

    public int Number
    {
        get => _number;
        private set
        {
            _number = value;
        }
    }

    public BankAccount(decimal balance)
    {
        Balance = balance;
        Number = GenerateAccount();
    }

    public BankAccount(TypeBankAccount type)
    {
        Type = type;
        Number = GenerateAccount();
    }

    public BankAccount(decimal balance, TypeBankAccount type)
    {
        Balance = balance;
        Type = type;
        Number = GenerateAccount();
    }

    private static int GenerateAccount()
    {
        return accountNumber++;
    }

    /// <summary>
    /// Перевод денег с одного счёта на другой
    /// </summary>
    /// <param name="account">Счёт, с которого происходит списание</param>
    /// <param name="money">Количество денег</param>
    public void TransferMoney(BankAccount account, decimal money)
    {
        if (account.Balance < money)
        {
            Console.WriteLine("На счёте недостаточно денег для перевода");
            return;
        }
        this.Balance += money;
        account.Balance -= money;
    }

    /// <summary>
    /// Проверка равенства дроби по полям
    /// </summary>
    /// <param name="a">Первый счет</param>
    /// <param name="b">Второй счет</param>
    /// <returns></returns>
    public static bool operator ==(BankAccount a, BankAccount b)
    {
        return (a.Balance == b.Balance && a.Type == b.Type);
    }

    /// <summary>
    /// Проверка неравенства дроби по полям
    /// </summary>
    /// <param name="a">Первый счет</param>
    /// <param name="b">Второй счет</param>
    /// <returns></returns>
    public static bool operator !=(BankAccount a, BankAccount b)
    {
        return !(a == b);
    }

    /// <summary>
    /// Переопределение Equals
    /// </summary>
    /// <param name="obj">Счет</param>
    /// <returns></returns>
    public override bool Equals(Object? obj)
    {
        if (obj is BankAccount bankAccount) return Balance == bankAccount.Balance && Type == bankAccount.Type;
        return false;
    }

    /// <summary>
    /// Переопределение GetHashCode
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Balance.GetHashCode() ^ Type.GetHashCode();
    }

    /// <summary>
    /// Переопределение ToString
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"Номер счета {Number}, Баланс {Balance}, Тип счета {Type}";
}
