using DesignPatterns.Singleton;

ConfigSetting config1 = ConfigSetting.GetInstance();
ConfigSetting config2 = ConfigSetting.GetInstance();

Console.WriteLine($"Config1 Connection String: {config1.DbConnectionString}");
Console.WriteLine($"Config2 Connection String: {config2.DbConnectionString} \n");

Console.WriteLine("Changing the connection string in config1...");
config1.DbConnectionString = "Server=newServer;Database=newDataBase;User Id=newUsername;Password=newPassword;\n";

Console.WriteLine("After Chaning the Config 1 : The Result of Config 2 is : ");
Console.WriteLine($"Config2 Connection String: {config2.DbConnectionString} \n");

if (config1.DbConnectionString == config2.DbConnectionString)
{
    Console.WriteLine("Both Config1 and Config2 have the same connection string as used same instance!.\n");
}

ConfigSettingV2 configV2_1 = ConfigSettingV2.GetInstance("Server=newServer;Database=newDataBase;User Id=newUsername;Password=newPassword;");
ConfigSettingV2 configV2_2 = ConfigSettingV2.GetInstance();

Console.WriteLine($"ConfigV2_1 Connection String: {configV2_1.dbConnectionString} \n");
Console.WriteLine($"ConfigV2_2 Connection String: {configV2_2.dbConnectionString} \n");

if (configV2_1.dbConnectionString == configV2_2.dbConnectionString)
{
    Console.WriteLine("Both ConfigV2_1 and ConfigV2_2 have the same connection string as used same instance!.");
}