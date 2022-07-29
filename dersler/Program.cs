// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("sadık sunbul");
string yazınsalmetın = "dersler";
int sayısalveriler = 10;
double kusuratlısayılar = 1.2;

Console.WriteLine(yazınsalmetın);
Console.WriteLine(kusuratlısayılar);
Console.WriteLine(sayısalveriler);

bool sıstemegırışyaptımı = true;
if (sıstemegırışyaptımı==false)
{
    Console.WriteLine("giriş yapıldı");

}
else
{
    Console.WriteLine("giriş yapılamdı");
}

double dolarbugun = 10.9;
double dolardun = 10.9;

if (dolarbugun<dolardun)
{
    Console.WriteLine("düşüş oku");
}
else if (dolardun<dolarbugun)
{
    Console.WriteLine("yukselıs oku");
}
else
{
    Console.WriteLine("hareket etmedi essitri oku");
}

string[] isimler = { "sadık", "fatıma", "ali", "salıh", "hasibe" };

for (int i = 0; i <isimler.Length; i++)
{
    Console.WriteLine(isimler[i]);
}
foreach (string x in isimler)
{
    Console.WriteLine(x);
}
for (int i = 0; i <3; i++)
{
    Console.WriteLine(i);
}
for (int i = 0; i <10; i+=2)
{
    Console.WriteLine(i);
}

//--------------------------------------------------------------------------------------------------------------------------------------------------
string adi = "engin";
int yas = 36;

kurs kurs1 = new kurs();                        //kendımız atadık 
kurs1.kursadı = "pyton";
kurs1.egıtmeni = "sadık sunbul";
kurs1.izlenmeoranı = 68;

kurs kurs2= new kurs();                        //kendımız atadık 
kurs2.kursadı = "c#";
kurs2.egıtmeni = "sadık sunbul";
kurs2.izlenmeoranı = 69;

kurs kurs3 = new kurs();                        //kendımız atadık 
kurs3.kursadı = "c#";
kurs3.egıtmeni = "sadık sunbul";
kurs3.izlenmeoranı = 98;

Console.WriteLine(kurs1.kursadı+ " " + kurs1.egıtmeni +" " + kurs1.izlenmeoranı);

kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };  //burda new kur[] demeye gerek yok galba tam bılmıyorum ama yazmayınca degısen bısey olmuyor 
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.kursadı+" "+kurs.egıtmeni );

}


class kurs                      //burda kendımız tanım yapcagımız seyı olusturuyoruz normalde kur dıye kod yok ben atadım yandakıyle 
{
    public string kursadı { get; set; }          //prop yapıp tab tab 
    public string egıtmeni { get; set; }
    public int izlenmeoranı { get; set; }
}

