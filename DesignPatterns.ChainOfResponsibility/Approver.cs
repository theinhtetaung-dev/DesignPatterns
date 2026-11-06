namespace DesignPatterns.ChainOfResponsibility;
public abstract class Approver(decimal limit, string role)
{
    private Approver? _next;
    public Approver SetNext(Approver next) { _next = next; return next; }
    public void Approve(decimal amount)
    {
        if (amount <= limit) Console.WriteLine($"{role} approved {amount:N2} MMK");
        else if (_next is not null) _next.Approve(amount);
        else Console.WriteLine($"{amount:N2} MMK requires board approval.");
    }
}
public class TellerApprover() : Approver(1000m, "Teller");
public class ManagerApprover() : Approver(10000m, "Manager");
public class DirectorApprover() : Approver(100000m, "Director");
