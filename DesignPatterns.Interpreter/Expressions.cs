namespace DesignPatterns.Interpreter;
public record TransactionContext(string CustomerType, decimal Amount, string Currency);
public interface IExpression { bool Interpret(TransactionContext context); }
public class CustomerTypeExpression(string expected) : IExpression { public bool Interpret(TransactionContext context) => context.CustomerType == expected; }
public class MinimumAmountExpression(decimal minimum) : IExpression { public bool Interpret(TransactionContext context) => context.Amount >= minimum; }
public class AndExpression(IExpression left, IExpression right) : IExpression { public bool Interpret(TransactionContext context) => left.Interpret(context) && right.Interpret(context); }
