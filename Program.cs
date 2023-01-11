using DesafioPOO.Models;


Nokia myNokia = new Nokia(numero:"(81)9.9100-0000",modelo: "12c",imei: "24249129490124-1294",memoria: 32);
myNokia.MostrarEspecificacoesSmartphone();
myNokia.Ligar();
myNokia.InstalarAplicativo("Dio");

Console.WriteLine("\n");

Iphone myIphone = new Iphone(numero:"(81)9.9200-0000",modelo: "1FX",imei: "12949129490124-1294",memoria: 64);
myIphone.MostrarEspecificacoesSmartphone();
myIphone.ReceberLigacao();
myIphone.InstalarAplicativo("DuoLingo");