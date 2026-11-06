using DesignPatterns.Interpreter;
var context = new TransactionContext("VIP", 150000m, "MMK");
IExpression rule = new AndExpression(new CustomerTypeExpression("VIP"), new MinimumAmountExpression(100000m));
Console.WriteLine($"Fee waiver eligible: {rule.Interpret(context)}");
