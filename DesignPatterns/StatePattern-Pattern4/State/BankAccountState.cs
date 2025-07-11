using PRACTICEPATTERN.DesignPatterns.StatePattern.Enum;

namespace PRACTICEPATTERN.DesignPatterns.StatePattern.State;
public abstract class BankAccountState
{
  public BankAccount BankAccount { get; set; }
  public abstract StateInfo Login(string password);
  public abstract StateInfo Logout();
  public abstract StateInfo Unlock(int resetCode);
  public abstract StateInfo Withdraw(decimal amount);
}