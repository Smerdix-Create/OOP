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

}
