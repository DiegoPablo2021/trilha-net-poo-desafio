using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "111111111", modelo: "1", imei: "122333444455555", memoria: 512);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("==========================================");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone (numero: "222222222", modelo: "2", imei: "123456789101112", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");