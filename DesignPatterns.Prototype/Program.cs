using DesignPatterns.Prototype;
var template = new TransferTemplate("Salary", "Company Account", 500000m, ["Monthly", "Payroll"]);
var copy = template.Clone();
copy.Name = "November Salary";
copy.Tags.Add("Employee-1001");
template.Print();
copy.Print();
