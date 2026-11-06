using DesignPatterns.Bridge;
new TransactionAlert(new SmsSender()).Send("Withdrawal completed.");
new SecurityAlert(new EmailSender()).Send("A new device signed in.");
