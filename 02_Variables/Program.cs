using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Lİstesi ****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potato, tomato;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;
            //Console.WriteLine("----- Elma Birim Fiyatı: "+ applePrice+" TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: "+strawberryPrice + " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: "+potato + " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: "+tomato + "  TL");
            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram,orangeGram,strawberryGram,potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Alınan Ürün : Elma" + " Birim Fiyat: " + applePrice + " Gramaj: " + appleGram +
            //    " Toplam Tutar: " + appleTotalPrice + " TL");

            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Alınan Ürün : Portakal" + " Birim Fiyat: " + orangePrice + " Gramaj: " + orangeGram +
            //    " Toplam Tutar: " + orangeTotalPrice + " TL");

            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Alınan Ürün : Çilek" + " Birim Fiyat: " + strawberryPrice + " Gramaj: " + strawberryGram +
            //    " Toplam Tutar: " + strawberryTotalPrice + " TL");

            //double potatoTotalPrice = potatoGram * potato;
            //Console.WriteLine("Alınan Ürün : Patates" + " Birim Fiyat: " + potato + " Gramaj: " + potatoGram +
            //    " Toplam Tutar: " + potatoTotalPrice + " TL");

            //double tomatoTotalPrice = tomatoGram * tomato;
            //Console.WriteLine("Alınan Ürün : Domates" + " Birim Fiyat: " + tomato + " Gramaj: " + tomatoGram +
            //    " Toplam Tutar: " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice +
            //    potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: "+ shoppingTotalPrice+" TL");

            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri
            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict,
            //    passengerCity, passengerAge,passengerIdentityNumber;

            //Console.WriteLine("Yolcu Adı: ");
            //passengerName=Console.ReadLine();

            //Console.WriteLine("Yolcu Soyadı: ");
            //passengerSurname=Console.ReadLine();

            //Console.WriteLine("İlçe Bilgisi: ");
            //passengerDistrict=Console.ReadLine();

            //Console.WriteLine("Şehir Bilgisi: ");
            //passengerCity=Console.ReadLine();

            //Console.WriteLine("Yaş Bilgisi: ");
            //passengerAge=Console.ReadLine();

            //Console.WriteLine("Kimlik Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("----------------------");
            //Console.Write("Yolcu TC Kimlik No: "+ passengerIdentityNumber+" - Yolcu Ad Soyad: "+
            //    passengerName+" "+passengerSurname+" "+passengerDistrict+" / "+
            //    passengerCity+" "+passengerAge);




            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computersCount, chairsCount, tvsCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computersCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairsCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvsCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoePrice+computerPrice*computersCount+chairPrice*chairsCount
            //    + tvPrice*tvsCount;
            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL ");


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2,exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result); 


            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);

            #endregion
            Console.Read();
        }
    }
}
