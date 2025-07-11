using PRACTICEPATTERN.DesignPatterns.StatePattern.Enum;
using PRACTICEPATTERN.DesignPatterns.StatePattern.State;

namespace PRACTICEPATTERN.DesignPatterns.StatePattern;
public class BankAccount
{
  public BankAccountState State { get; set; }
  public BankAccountState LoggedIn { get; set; }
  public BankAccountState LoggedOut { get; set; }
  public BankAccountState Suspended { get; set; }
  public int CashBalance { get; set; }
  public int ResetCode { get; set; }
  public int PasswordRetries { get; set; }
  public string Password { get; set; }
  public BankAccount(decimal cashBalance, string password, int resetCode)
  {
    CashBalance = (int)cashBalance;
    Password = password;
    ResetCode = resetCode;
    PasswordRetries = 0;
    LoggedIn = new LoggedIn(this);
    LoggedOut = new LoggedOut(this);
    Suspended = new Suspended(this);
    State = LoggedOut;
  }
  public StateInfo Login(string password)
  {
    return State.Login(password);
  }
  public StateInfo Logout()
  {
    return State.Logout();
  }
  public StateInfo Unlock(int resetCode)
  {
    return State.Unlock(resetCode);
  }
  public StateInfo Withdraw(decimal amount)
  {
    return State.Withdraw(amount);
  }
}
