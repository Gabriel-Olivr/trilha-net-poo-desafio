using DesafioPOO.Models;


Console.WriteLine("--- Testando Smartphone Nokia ---");
Smartphone nokia = new Nokia(numero: "(21) 99999-9999", modelo: "Nokia 3310", imei: "111111111", memoria: 128); // 128 MB 😉
nokia.Ligar();
nokia.InstalarAplicativo("Snake II");

Console.WriteLine("\n");

Console.WriteLine("--- Testando Smartphone iPhone ---");
Smartphone iphone = new Iphone(numero: "(81) 99999-9999", modelo: "iPhone 15 Pro", imei: "222222222", memoria: 128); 
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");