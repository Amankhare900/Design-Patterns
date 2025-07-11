namespace PRACTICEPATTERN.DesignPatterns.StatePattern.State;
public class LoggedIn : BankAccountState
{
  public LoggedIn(BankAccountSolution bankAccount)
  {
    this.BankAccount = bankAccount;
  }
  public override StateInfo Login(string password)
  {
    return StateInfo.LoggedIn;
  }
  public override StateInfo Logout()
  {
    BankAccount.PasswordRetries = 0;
    BankAccount.State = BankAccount.LoggedOut;
    return StateInfo.LoggedOut;
  }
  public override StateInfo Unlock(int resetCode)
  {
    return StateInfo.LoggedIn;
  }
  public override StateInfo Withdraw(decimal amount)
  {
    if (amount <= BankAccount.CashBalance && amount >= 0)
    {
      BankAccount.CashBalance -= amount;
      return StateInfo.LoggedIn;
    }
    return StateInfo.Error;
  }
}
