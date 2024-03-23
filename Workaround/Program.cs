using Business.Concrete;
using Entities.Concrete;

//Console.WriteLine("Hello, World!");

//SelamVer("Furkan");
//SelamVer();
//int sonuc = Topla(6, 58);


////Diziler / Arrays
////Referarans Tipler = Arrays, class,interface,absract,String

//string[] ogrenciler = new string[3];
//ogrenciler[0] = "Kemal";
//ogrenciler[1] = "Kerem";
//ogrenciler[2] = "Osman";

//for (int i = 0; i < ogrenciler.Length; i++)
//{
//    Console.WriteLine(ogrenciler[i]);
//}

//string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
//string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

//sehirler2 = sehirler1; //Referans Ataması 
//sehirler1[0] = "Adana";
//Console.WriteLine(sehirler2[0]);

//foreach (var sehir in sehirler1)
//{
//    Console.WriteLine(sehir);
//}

//List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
//yeniSehirler1.Add("Adana 1");
//foreach (var sehir in yeniSehirler1)
//{
//    Console.WriteLine(sehir);
//}

Person person = new Person();
person.FirstName = "NAME";
person.LastName = "LASTNAME";
person.DateOfBirthYear = 2000;
person.NationalIdentity = 123;



PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);
















//static void SelamVer(string isim="isimsiz")
//{
//    Console.WriteLine("Merhaba" + " " + isim);
//}

//static int Topla(int sayi1=5, int sayi2=10)
//{
//     int sonuc = sayi1 + sayi2;
//    Console.WriteLine("Toplam" + " " + sonuc); ;
//    return sonuc ;
//}



