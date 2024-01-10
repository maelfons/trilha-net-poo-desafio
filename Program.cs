using DesafioPOO.Models;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("85988776655","Lumia - X1", "0012121212", "256GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("GunshipBlattle Crypto Conflict");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("85911223344", "Iphone 13 ProMax", "550044332125", "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Wild Rift");
