// See https://aka.ms/new-console-template for more information
string sayi = "999";

bool sonuc = int.TryParse(sayi, out int outSayi);
if (sonuc)
{
    Console.WriteLine("Başarılı");
    Console.WriteLine(sayi);

}
else
{
    Console.WriteLine("Başarısız");
}

Metotlar instance = new Metotlar();
instance.Topla(2, 3, out int toplamSonucu);
Console.WriteLine(toplamSonucu);

// Metot Aşırı Yükleme - Overloading 

int ifade = 1654;
instance.EkranaYazdir(ifade);
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir("Melih", "Özaslan");







class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;

    }

    public void EkranaYazdir (string veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1+" "+veri2);

    }

}