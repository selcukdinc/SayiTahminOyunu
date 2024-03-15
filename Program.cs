namespace TahminOyunu;

class Program
{
    static void Main(string[] args)
    {
        // TAHMiN OYUNU
        // OYUNUN AMACI
        // Uygulama olarak bu örnekte yapacağımız basit bir tahmin oyununun genel olarak amacı ve yapacağı işlemler aşağıdaki gibidir.
        // 
        // • Program, açıldığında 1 ile 1000 arasında bir sayı üretsin ve bu sayı "n" değişkenine atansın.
        // • Kullanıcının 11 hakkı vardır. Bu nedenle hak adında bir değişken tanımlansın ve ilk değeri 11 yapılsın.
        // • Bir döngü açılsın ve "sayi" adında tanımlanmış bir değişkenin değeri klavyeden okunsun. Eğer "n" sayısı girilen sayıdan büyük ise kullanıcıya "Sayıyı Yükset"
        // şeklinde bir yazı, küçük ise "Sayıyı Küçült" şeklinde bir yazı gösterilsin ve sayı bilinemediği için hak değişkeninin değeri bir küçültülsün. Ancak girilen sayı,
        // üretilmiş olan n sayısına eşit ise ekrana "Tebrikler" şeklinde bir yazı gösteriir ve oyun bitirilsin.
        // • Eğer kullanıcı sahip olduğu 11 hak ile "n" sayısını tahmin edemediyse ekrana
        // "Kaybettin" şeklinde bir yazı gösterilsin ve oyun bitirilsin.
        Console.Clear();
        Random RastgeleSayi = new Random();
        int secim, hak = 11, _hak = 1, min = 1, maks = 10001, n = RastgeleSayi.Next(min,maks);
        string VarKaldi = "var";
        Console.Write("---   {0}-{1} arasında sayı tahmin oyunu ---\n", min, maks-1);
        do
        {
            Console.Write("\t{0} Hakkın {1}.\n", hak, VarKaldi);
            if (hak == 0)
            {
                Console.Write("Hakların bitti, oyunu kaybettin... tahmin ettiğim sayı: {0} \n",n);
                break;
            }else
            {
                Console.Write("\t\t{0}. tahminin: ",_hak);
                secim = Convert.ToInt32(Console.ReadLine());
                if (secim == n)
                {
                    Yazdir.KR("Yeşil", "T E B R İ K L E R,", "Beyaz", "oyunu kazandın...");
                    break;
                }else if (secim < n)    Yazdir.KR("tahminimden", "Kırmızı", "D Ü Ş Ü K", "Beyaz", "sayı girdin, tekrar dene...\n");
                else                    Yazdir.KR("tahminimden", "Turkuaz", "Y Ü K S E K", "Beyaz", "sayı girdin, tekrar dene...\n");
                hak--;_hak++;
            }
            VarKaldi = "kaldı";
        } while (true);
       Console.ReadLine();
    }
}