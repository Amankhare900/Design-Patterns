namespace PRACTICEPATTERN.DesignPatterns.StatePattern.State;
public class LoggedOut :BankAccountState
{
  public LoggedOut(BankAccountSolution bankAccount)
  {
    this.BankAccount = bankAccount;
  }
  public override StateInfo Login(string password)
  {
    if (password == BankAccount.Password)
    {
      BankAccount.PasswordRetries = 0;
      BankAccount.State = BankAccount.LoggedIn;
      return StateInfo.LoggedIn;
    }
    BankAccount.PasswordRetries++;
    BankAccount.State = BankAccount.PasswordRetries > 2 ? BankAccount.Suspended : BankAccount.LoggedOut;
    return BankAccount.PasswordRetries > 2 ? StateInfo.Suspended : StateInfo.LoggedOut;
  }
  public override StateInfo Logout()
  {
    return StateInfo.LoggedOut;
  }
  public override StateInfo Unlock(int resetCode)
  {
    return StateInfo.LoggedOut;
  }
  public override StateInfo Withdraw(decimal amount)
  {
    return StateInfo.LoggedOut;
  }
}
