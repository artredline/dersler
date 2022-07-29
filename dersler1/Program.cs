// See https://aka.ms/new-console-template for more information
//metotlar



urun urun1 = new urun();
urun1.adı = "valo";
urun1.fıyatı = 25;

urun urun2= new urun();
urun2.adı = "csgo";
urun2.fıyatı= 26;

urun urun3=new urun();
urun3.adı = "lol";
urun3.fıyatı = 0;

SepetManeger sepetManeger = new SepetManeger();

urun[] uruns = new urun[]{urun1, urun2,urun3};


foreach (var urun in uruns)
{
    Console.WriteLine(urun.adı + " / " + urun.fıyatı + "/ ");
    Console.WriteLine("-------------------------------");
}

sepetManeger.Ekle(urun1);  //alttakı syussulu ıcı gelır buraya
sepetManeger.Ekle(urun2);


DortIslem dortIslem = new DortIslem();
dortIslem.Topla(5, 6);













class urun
{
    public string adı { get; set; }
    public int fıyatı { get; set; }
}


class SepetManeger
{
    public void Ekle(urun urun)             //() varsa metot vardır
    {
        Console.WriteLine("tebrıkler . sepete eklendi!:"+ urun.adı);  //degısıklerı kolay yapmak ıcın kulanırız burda degıstırınce her yerde degısır 
    }
}


internal class DortIslem
{
    public void Topla(int sayı1, int sayı2)
    {
        int toplam = sayı1 + sayı2;
        Console.WriteLine("sonuç : " + toplam);
    }
}
