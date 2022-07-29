// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int sayı1 = 10;
int sayı2 = 30;

sayı1 = sayı2; // sayı 2 degerı once ve sonrasına yazılması durumumnda deger degısır
sayı2 = 65;

Console.WriteLine(sayı1);


int[] sayılar1 = new int[] {10,20,30 };                         // new yenı adres bellek olustur demek 
int[] sayılar2 = new int[] { 100, 200, 300 };
sayılar1 = sayılar2;                   // burda referans numarasını degıstırır burası deger tıpı degıl 
sayılar2[0] = 999;

Console.WriteLine(sayılar1[0]);

//int , decimol , flood , double, bool =deger tıpı

// aray , class , interface = referans tıpı


