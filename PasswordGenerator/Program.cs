// See https://aka.ms/new-console-template for more information

using PasswordGenerator;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine(Password.GetRandomPassword(length: 50, useNumeric:true, useLowerAlpha:true, useSymbol:true,  useUpperAlpha:true));
Console.WriteLine(Password.GetRandomPassword(length: 50, useNumeric:true, useLowerAlpha: true, useSymbol: true, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 50, useNumeric:true, useLowerAlpha: true, useSymbol: false, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 50, useNumeric:true, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));
Console.WriteLine("\n");                                 
Console.WriteLine("\n");                                 
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: true, useSymbol: true, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: true, useSymbol: true, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: true, useSymbol: true, useUpperAlpha: true));
Console.WriteLine("\n");                                 
Console.WriteLine("\n");                                 
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: false, useSymbol: true, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: false, useSymbol: true, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: false, useSymbol: true, useUpperAlpha: true));
Console.WriteLine("\n");                                 
Console.WriteLine("\n");                                 
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: false, useSymbol: false, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: false, useSymbol: false, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: false, useSymbol: false, useUpperAlpha: true));
Console.WriteLine("\n");                                 
Console.WriteLine("\n");                                 
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 04, useNumeric:true, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));
Console.WriteLine("\n");                                 
Console.WriteLine("\n");                                 
Console.WriteLine(Password.GetRandomPassword(length: 01, useNumeric:true, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 01, useNumeric:true, useLowerAlpha: true, useSymbol: false, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 01, useNumeric:true, useLowerAlpha: true, useSymbol: true, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 01, useNumeric:true, useLowerAlpha: true, useSymbol: true, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 01, useNumeric:true, useLowerAlpha: false, useSymbol: true, useUpperAlpha: false));
Console.WriteLine(Password.GetRandomPassword(length: 01, useNumeric:true, useLowerAlpha: false, useSymbol: false, useUpperAlpha: true));
Console.WriteLine(Password.GetRandomPassword(length: 01, useNumeric:false, useLowerAlpha: false, useSymbol: false, useUpperAlpha: false));

Console.ReadLine();