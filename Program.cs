using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

//Teste com celular nokia
Smartphone nokia = new Nokia(numero: "123456687789", modelo: "G 50", imei: "589514545", memoria: 10);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");
//Teste com celular Iphone 

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "16255488842", modelo: "X", imei: "548651684651", memoria: 8);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");