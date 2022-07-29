// See https://aka.ms/new-console-template for more information



urun urun1 =new urun();
urun1.adı = "pantalon";
urun1.acıklama = "kot";
urun1.fiyatı = 155;

urun urun2 =new urun();
urun2.adı = "gomlek";
urun2.acıklama = "jean";
urun2.fiyatı = 88;

urun urun3 =new urun();
urun3.adı = "ayakabı";
urun3.acıklama = "nıkea";
urun3.fiyatı = 452;


urun[] uruns = new urun[] {urun1,urun2,urun3 };
foreach (var urun in uruns)
{
    Console.WriteLine(urun.adı+" : "+urun.acıklama+" : "+urun.fiyatı);
}


SepetManager sepetManager=new SepetManager();
sepetManager.Ekle(urun1);

DortIslem dortIslem=new DortIslem();
dortIslem.Topla(1,2,4,5);


sepetManager.Ekle(urun2);
dortIslem.Topla(10,45,88,98);







class urun
{
    public string Id { get; set; }
    public string adı { get; set; }
    public string acıklama { get; set; }
    public int fiyatı { get; set; }

}

class SepetManager
{
    public void Ekle(urun urun)
    {
        Console.WriteLine("Tebrikler Başarıyla Sepete Eklendi : "+urun.adı);
    }
}

class DortIslem
{
    public void Topla(int sayı1,int sayı2 , int sayı3, int sayı4)
    {
        int toplam = sayı1 + sayı2 + sayı3 + sayı4;
        Console.WriteLine("sonuç : "+toplam);
    }
}