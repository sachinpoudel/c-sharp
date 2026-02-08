interface IBankService
{
    void CreateAccount(string name);
    void Deposit (int accNo, decimal amount);
    void WithDraw(int accNo, decimal amount);
}