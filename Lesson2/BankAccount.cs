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

    public decimal Balance { get; set; }

    public TypeBankAccount Type { get; set; }

    public int Number
    {
        get => _number;
        set
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

    public void GetAccountNumber()
    {

        Console.WriteLine($"Информация о счёте: номер счёта - {accountNumber}; баланс - {Balance} руб.; тип счёта - {Type}");
        accountNumber++;
        Console.WriteLine();
    }
}
