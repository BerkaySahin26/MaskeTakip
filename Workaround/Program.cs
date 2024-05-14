
using Business.Concrete;
using Entities.Concrete;

class Program
{
    public static void Main(string[] args)
    {


        //SelamVer(isim: "Mehmet");
        //SelamVer(isim:"Ali");
        //SelamVer(isim:"Cengiz");
        //SelamVer();

        //Topla(sayı1: 12, sayı2: 12);

        //Console.ReadLine();


        //Vatandas vatandas1 = new Vatandas(); /// Yeni bir vatandaş oluştu


        //boşbeleş();


        List<string> Sehirler = new List<string> {"Ankara","İstanbul","İzmir"};  //List de bir referans 
        Sehirler.Add("Eskişehir");
        foreach (string s in Sehirler) 
        {
        Console.WriteLine(s);
        }

        Person person1 = new Person();
        person1.FirstName = "BERKAY";
        person1.LastName = "ŞAHİN";
        person1.NationalIdentitiy =11111111111;
        person1.DateOfBirthYear = 1555;

       

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();
    }

    public static void SelamVer(string isim = "NoName")
    {
        Console.WriteLine("Selam"+isim);
    }

    private static void bos()
    {
        string[] a = { "Merhaba1", "Merhaba2", "Merhaba3", "Merhaba4" };
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }

    static int Topla(int sayı1=0, int sayı2=0)
    {
        int sonuc = sayı1 + sayı2;
        Console.WriteLine(sonuc);
        return sonuc;
    }
}



public class Vatandaslar
{
    public string ad = "Engin";
    public string Soyad = "Demiroğ";
    public int DoğumYılı = 1985;
    public long tcNo = 12345678910;
    
}

public class Vatandas   //pascal casing ilk harf büyük
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Dogumyili { get; set; }
    public long TcNo { get; set; }
}

