using System.Reflection.Metadata.Ecma335;

namespace Methods_6._12
{
    internal class Program
    {
        static void numCounter()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void numCounterV2(int num)
        {
            for (int j = 1; j <= num; j++)
            {
                Console.WriteLine(j);
            }
        }

        static void evenOddChecker(int num1, int num2, int num3)
        {
            if (num1 %2 == 0) Console.WriteLine(num1 + " is even");
            else Console.WriteLine(num1 + " is odd");
            if (num2 % 2 == 0) Console.WriteLine(num2 + " is even");
            else Console.WriteLine(num1 + " is odd");
            if (num3 % 2 == 0) Console.WriteLine(num3 + " is even");
            else Console.WriteLine(num1 + " is odd");
        }

        static double multiplication (double num1, double num2)
        {
            return num1 * num2;
        }
        static void addition (double num1, double num2)
        {
            double toplama = num1 + num2;
            Console.WriteLine("Addition of 2 numbers : " + toplama);
            Console.WriteLine("Multiplication of 2 numbers : " + multiplication(num1, num2));
        }

        static void addTriple (int num1, int num2)
        {
            int toplam = num1 + num2;
            Console.WriteLine("İki sayının toplamı : " + toplam);
            int kup = toplam * toplam * toplam;
            Console.WriteLine("Toplamın küpü : " + kup);
        }

        static void biggerNum()
        {
            Console.WriteLine("Birinci sayıyı giriniz");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            int num2 = int.Parse(Console.ReadLine());
            if (num1>num2) Console.WriteLine(num1 + " is bigger");
            else Console.WriteLine(num2 + " is bigger");
        }

        static void mailCreator()
        {
            Console.WriteLine("Adınızı giriniz.");
            String name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            String surname = Console.ReadLine();
            Console.WriteLine("Your mail address is : " + name + surname + "@bilgeadamgod.com");
        }

        static void taxCalculator()
        {
            Console.WriteLine("Ürününüzün fiyatını giriniz.");
            decimal fiyat = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ürünün belirtilen KDV oranını giriniz");
            decimal tax = int.Parse(Console.ReadLine());
            while(tax!=1 && tax!=8 && tax!=18)
            {
                Console.WriteLine("Geçersiz bir KDV oranı girdiniz. 1, 8 veya 18 olabilir sadece.");
                tax = int.Parse(Console.ReadLine());
            }
            if(tax==1) Console.WriteLine("Ürününüzün KDV dahil fiyatı : " + (fiyat * 1.01m));
            else if (tax == 8) Console.WriteLine("Ürününüzün KDV dahil fiyatı : " + (fiyat * 1.08m));
            else Console.WriteLine("Ürününüzün KDV dahil fiyatı : " + (fiyat * 1.18m));
        }

            static void Main(string[] args)
        {
            #region 1'den 100'e kadar sayıları ekrana yazdıran metodu çağıran Uygulamayı yapınız
            numCounter();
            #endregion

            #region 1'den başlayan ve dışarıdan gönderilen değere kadar ekrana yazdıran metodu çağıran program.(void)
            numCounterV2(500);
            #endregion

            #region Kullanıcıdan öğrenilen sayının tek mi çift mi olduğunu söyleyen bir metodu çağıran programı yazdırınız
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int num3 = int.Parse(Console.ReadLine());
            evenOddChecker(num1, num2, num3);
            #endregion

            #region Çarpma ve toplama işlemlerini iki ayrı metotta yapan, fakat çarpma metodunu, topla metodunda çağıran uygulamayı yapınız.
            addition(56.87, 89.18);
            #endregion

            #region Kullanıcının girdiği iki sayıyı toplayan ve bu toplamın küpünü geriye döndüren metodu çağıran programı yazınız
            addTriple(51, 96);
            #endregion

            #region Klavyeden kullanıcı tarafından girilen iki sayıdan büyük olanı metot içinde bulup sonucu ana metotta ekrana yazdıran programı yazınız.
            biggerNum();
            #endregion

            #region Kullanıcıdan isim ve soyisim bilgisini alarak mail adresi oluşturan algoritmayı metot kullanarak yazalım.
            mailCreator();
            #endregion

            #region Kullanıcının gireceği ürün fiyatı ve KDV oranına göre ürünün KDV'li fiyatını hesaplayan algoritmayı metotlar ile yazalım.
            //(%1, %8 ve %18 olmak üzere 3 çeşit KDV oranı vardır.)
            taxCalculator();
            #endregion

        }
    }
}
