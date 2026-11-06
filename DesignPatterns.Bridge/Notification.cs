namespace DesignPatterns.Bridge;
public interface IMessageSender { void Send(string title, string message); }
public class SmsSender : IMessageSender { public void Send(string title, string message) => Console.WriteLine($"SMS - {title}: {message}"); }
public class EmailSender : IMessageSender { public void Send(string title, string message) => Console.WriteLine($"Email - {title}: {message}"); }
public abstract class Notification(IMessageSender sender) { protected IMessageSender Sender { get; } = sender; public abstract void Send(string message); }
public class TransactionAlert(IMessageSender sender) : Notification(sender) { public override void Send(string message) => Sender.Send("Transaction Alert", message); }
public class SecurityAlert(IMessageSender sender) : Notification(sender) { public override void Send(string message) => Sender.Send("Security Alert", message); }
