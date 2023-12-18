using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\nSmartphone Nokia");
Smartphone nokia = new Nokia(numero: "234568", modelo: "B49-Model" ,imei: "999888432", memoria: 89);
nokia.Ligar();
nokia.InstalarAplicativo("MyLib");
Console.WriteLine("\n ------------------------ \n");
Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "987635", modelo: "T43" ,imei: "978375635", memoria: 245);
iphone.Ligar();
iphone.InstalarAplicativo("Clash Of Clans");
