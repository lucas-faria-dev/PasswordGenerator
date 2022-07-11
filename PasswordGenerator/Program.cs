// See https://aka.ms/new-console-template for more information

using PasswordGenerator;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine(Password.GetRandomPassword(length: 50, useLowerAlpha:true, useSymbol:true,  useUpperAlpha:true));
Console.WriteLine(Password.GetRandomPassword(length: 50, useLowerAlpha: true, useSymbol: true, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 50, useLowerAlpha: true, useSymbol: false, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 50, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: true, useSymbol: true, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: true, useSymbol: true, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: true, useSymbol: true, useUpperAlpha: true));
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: false, useSymbol: true, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: false, useSymbol: true, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: false, useSymbol: true, useUpperAlpha: true));
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: false, useSymbol: false, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: false, useSymbol: false, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: false, useSymbol: false, useUpperAlpha: true));
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 4, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine(Password.GetRandomPassword(length: 1, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 1, useLowerAlpha: true, useSymbol: false, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 1, useLowerAlpha: true, useSymbol: true, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 1, useLowerAlpha: true, useSymbol: true, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 1, useLowerAlpha: false, useSymbol: true, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 1, useLowerAlpha: false, useSymbol: false, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 1, useLowerAlpha: false, useSymbol: true, useUpperAlpha: true));

Console.ReadLine();