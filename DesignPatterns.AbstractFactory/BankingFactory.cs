namespace DesignPatterns.AbstractFactory;
public interface ILoginView { void Render(); }
public interface ITransferView { void Render(); }
public interface IBankingUiFactory { ILoginView CreateLoginView(); ITransferView CreateTransferView(); }
public class MobileLoginView : ILoginView { public void Render() => Console.WriteLine("Mobile login view"); }
public class MobileTransferView : ITransferView { public void Render() => Console.WriteLine("Mobile transfer view"); }
public class WebLoginView : ILoginView { public void Render() => Console.WriteLine("Web login view"); }
public class WebTransferView : ITransferView { public void Render() => Console.WriteLine("Web transfer view"); }
public class MobileBankingFactory : IBankingUiFactory { public ILoginView CreateLoginView() => new MobileLoginView(); public ITransferView CreateTransferView() => new MobileTransferView(); }
public class WebBankingFactory : IBankingUiFactory { public ILoginView CreateLoginView() => new WebLoginView(); public ITransferView CreateTransferView() => new WebTransferView(); }
public class BankingApplication(IBankingUiFactory factory)
{
    private readonly ILoginView _login = factory.CreateLoginView();
    private readonly ITransferView _transfer = factory.CreateTransferView();
    public void Render() { _login.Render(); _transfer.Render(); }
}
