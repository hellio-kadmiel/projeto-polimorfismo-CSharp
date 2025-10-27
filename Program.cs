using DesafioPOO.Models;
using System;


// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("----- Testando iPhone -----");
Iphone iphone = new Iphone(numero: "123-456-7890", modelo: "iPhone 13", imei: "IMEI1234567890", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine(//---------------------------------------/
);

Console.WriteLine("----- Testando Nokia -----");
Nokia nokia = new Nokia("098-765-4321", "Nokia 3310", "IMEI0987654321", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
