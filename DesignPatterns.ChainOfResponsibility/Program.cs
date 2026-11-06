using DesignPatterns.ChainOfResponsibility;
var chain = new TellerApprover();
chain.SetNext(new ManagerApprover()).SetNext(new DirectorApprover());
chain.Approve(500m);
chain.Approve(5000m);
chain.Approve(50000m);
