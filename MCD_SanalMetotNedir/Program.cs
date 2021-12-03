using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetotNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sanal Metot Nedir?
            *Sanal metot dediğimiz baseclass içerisinde bulunan bir metotun istenirse türeyen sınıf içerisnde nasıl yeniden şekillenebileceğini inceleyeceğiz.
            *Sanal metot anlatımına object içerisinde bize standart olarak gelen toString metodunu inceleyerek başlayacağız.
            *Sanal metotları, X-men filminde bulunan mystique karakterine benzetebilirizç
            *Ortama göre kendi şeklini değiştirebilen bir karakter olması buna bir örnek olabilir.
            *
            *Object => ToString();
            *Musteri M1 = new Musteri();
            *Object => Musteri 
            *          M1.ToString();
            *          
            *Namespace.
            */

            Musteri M1 = new Musteri();
            M1.isim = "Emre";
            M1.soyisim = "Gemici";
            string toStringMesaj = M1.ToString();
            Console.WriteLine(toStringMesaj );

            Console.ReadLine();
        }
    }
}
