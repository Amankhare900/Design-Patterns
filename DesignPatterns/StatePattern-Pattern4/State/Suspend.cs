using PRACTICEPATTERN.DesignPatterns.StatePattern.Enum;

namespace PRACTICEPATTERN.DesignPatterns.StatePattern.State;
public class Suspended : BankAccountState
{
  public Suspended(BankAccount bankAccount)
  {
    this.BankAccount = bankAccount;
  }
  public override StateInfo Login(string password)
  {
    return StateInfo.Suspended;
  }
  public override StateInfo Logout()
  {
    return StateInfo.Suspended;
  }
  public override StateInfo Unlock(int resetCode)
  {
    BankAccount.State = resetCode == BankAccount.ResetCode ? BankAccount.LoggedOut : BankAccount.Suspended;
    return resetCode == BankAccount.ResetCode ? StateInfo.LoggedOut : StateInfo.Suspended;
  }
  public override StateInfo Withdraw(decimal amount)
  {
    return StateInfo.Suspended;
  }
}
