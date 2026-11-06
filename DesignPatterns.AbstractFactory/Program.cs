using DesignPatterns.AbstractFactory;
new BankingApplication(new MobileBankingFactory()).Render();
new BankingApplication(new WebBankingFactory()).Render();
