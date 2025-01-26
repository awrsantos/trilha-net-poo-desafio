using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "G11 Plus", imei: "123123123", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4567890123", modelo: "15 Pro Max", imei: "456456456", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");