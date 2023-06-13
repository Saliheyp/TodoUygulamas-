using System;

namespace TodoUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Kart.Todo.Add(new TodoKart("Ütü","Gömlek ütülencek",kisiler.MevcutKisiler(2),(zorluk)3,false,false));
            Kart.Todo.Add(new TodoKart("Ayakkabı","Ayakkabı Boyancak",kisiler.MevcutKisiler(4),(zorluk)4,false,false));
            Kart.Todo.Add(new TodoKart("Kahve","Kahve yapılacak",kisiler.MevcutKisiler(1),(zorluk)2,false,false));
            bool devam = true;           
            while(devam)
            {
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Güncellemek");
            Console.WriteLine("(4) Board'dan Kart Silmek");
            Console.WriteLine("(5) Board'dan Kart Taşımak");

            
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Kart.BoardListele();
                    break;
                    case 2:
                        Kart.KartEkle();
                    break;
                    case 3:
                        Kart.KartGuncelle();
                    break;
                    case 4:
                        Kart.KartSil();
                    break;
                    case 5:
                        Kart.KartTasi();
                    break;
                }
                Console.WriteLine("Devam etmek için bir tuşa basın, çıkmak için 'E' tuşuna basın.");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.E)
                {
                    devam = false;
                }
                Console.Clear();
            }
        }
    }
}