using DesignPatterns.Mediator;
var mediator = new TransferMediator();
var sender = new Account("Sender", mediator);
var receiver = new Account("Receiver", mediator);
mediator.Register(sender);
mediator.Register(receiver);
sender.Transfer("Receiver", 25000m);
