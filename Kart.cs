namespace TodoUygulamasi
{
    
    public class TodoKart
    {
        public string Ad {get; set;}
        public string Icerik {get; set;}
        public string AtananKisi {get; set;}
        public zorluk Buyukluk {get; set;}
        public bool Bittimi{get; set;}
        public bool Yapilmaktami{get; set;}
            public TodoKart(string ad,string icerik,string atanankisi,zorluk buyukluk,bool bittimi,bool yapilmaktami)
            {
                Ad = ad;
                Icerik = icerik;
                AtananKisi = atanankisi;
                Buyukluk = buyukluk;
                Bittimi = bittimi;
                Yapilmaktami = yapilmaktami;
            }
    }
    
    public class Kart
    {
        public static List<TodoKart> Todo = new List<TodoKart>();
        public static List<TodoKart> inProgres = new List<TodoKart>();
        public static List<TodoKart> done = new();
        public static void KartEkle()
        {   
            Console.WriteLine("Kartın başlığını giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine("Kartın içerğini giriniz:");
            string icerik = Console.ReadLine();
            Console.WriteLine("Kartın atanacağı kişinin sırasını yazınız:");
            int atanankisi = int.Parse(Console.ReadLine());
            Console.WriteLine("Kartın zorluğunu giriniz:");
            int buyukluk =int.Parse(Console.ReadLine());
            Todo.Add(new TodoKart(ad,icerik,kisiler.MevcutKisiler(atanankisi),(zorluk)buyukluk,false,false));

        }
        public static void KartGuncelle()
        {
            Console.WriteLine("Hangi Listedeki kartı güncellemek istersiniz: (1)Todo List,(2)InProgres(3)Done");
            int secim = int.Parse(Console.ReadLine());
            if(secim == 1)
            {
                Console.WriteLine("güncelelmek istediğniiz kartın adını giriniz");
                string guncellenecekKart = Console.ReadLine();
                foreach (var item in Todo)
                {
                    if(guncellenecekKart == item.Ad)
                    {   
                        Console.WriteLine("Yeni ad giriniz");
                        item.Ad = Console.ReadLine();
                        Console.WriteLine("Yeni icerik giriniz");
                        item.Icerik = Console.ReadLine();
                        Console.WriteLine("Yeni atanan kisi giriniz");
                        int atananKisiNo = int.Parse(Console.ReadLine());
                        item.AtananKisi = kisiler.MevcutKisiler(atananKisiNo);
                        Console.WriteLine("Yeni büyüklük giriniz");
                        int x = int.Parse(Console.ReadLine());
                        item.Buyukluk=(zorluk)x;
                    }
                }
            }
            else if(secim ==2)
            {
                Console.WriteLine("güncelelmek istediğniiz kartın adını giriniz");
                string guncellenecekKart = Console.ReadLine();
                foreach (var item in inProgres)
                {
                    if(guncellenecekKart == item.Ad)
                    {   
                        Console.WriteLine("Yeni ad giriniz");
                        item.Ad = Console.ReadLine();
                        Console.WriteLine("Yeni icerik giriniz");
                        item.Icerik = Console.ReadLine();
                        Console.WriteLine("Yeni atanan kisi giriniz");
                        int atananKisiNo = int.Parse(Console.ReadLine());
                        item.AtananKisi = kisiler.MevcutKisiler(atananKisiNo);
                        Console.WriteLine("Yeni büyüklük giriniz");
                        int x = int.Parse(Console.ReadLine());
                        item.Buyukluk=(zorluk)x;
                    }
                }
            }
            else if(secim==3 )
            {
                Console.WriteLine("güncelelmek istediğniiz kartın adını giriniz");
                string guncellenecekKart = Console.ReadLine();
                foreach (var item in done)
                {
                    if(guncellenecekKart == item.Ad)
                    {   
                        Console.WriteLine("Yeni ad giriniz");
                        item.Ad = Console.ReadLine();
                        Console.WriteLine("Yeni icerik giriniz");
                        item.Icerik = Console.ReadLine();
                        Console.WriteLine("Yeni atanan kisi giriniz");
                        int atananKisiNo = int.Parse(Console.ReadLine());
                        item.AtananKisi = kisiler.MevcutKisiler(atananKisiNo);
                        Console.WriteLine("Yeni büyüklük giriniz");
                        int x = int.Parse(Console.ReadLine());
                        item.Buyukluk=(zorluk)x;
                    }
                }
            }
            else
            Console.WriteLine("Girdiğiniz liste bulunamadı.");


           
        }
        public static void KartSil()
        {
            Console.WriteLine("Silinecek kartın adını giriniz");
            string silinecekKart = Console.ReadLine();
            bool kartBulundu = false;
            for (int i = 0; i < Todo.Count; i++)
            {
                var item = Todo[i];
                if (silinecekKart == item.Ad)
                {
                    Todo.Remove(item);
                    Console.WriteLine(silinecekKart+" başarıyla silindi");
                    kartBulundu = true;
                    break;
                }
            }
            for (int i = 0; i < inProgres.Count; i++)
            {
                var item = inProgres[i];
                if (silinecekKart == item.Ad)
                {
                    inProgres.Remove(item);
                    Console.WriteLine(silinecekKart+" başarıyla silindi");
                    kartBulundu = true;
                    break;
                }
          
            }
            for (int i = 0; i < done.Count; i++)
            {
                var item = done[i];
                if (silinecekKart == item.Ad)
                {
                    done.Remove(item);
                    Console.WriteLine(silinecekKart+" başarıyla silindi");
                    kartBulundu = true;
                    break;
                }
               
            }
            if(!kartBulundu)
            {
                Console.WriteLine(silinecekKart + " isimli kart bulunamadı. Tekrar denemek için 1, çıkmak için 2'ye basınız");
                int secim = int.Parse(Console.ReadLine());
                if (secim == 1)
                {
                    KartSil();
                }
                else
                {
                    return;
                }
            }
        }
        public static void KartTasi()
        {
            bool kartBulundu = false;
            Console.WriteLine("Hangi listedeki kartı taşımak istersiniz (1)Todo List (2)InProgres List. İptal etmek için (3)");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("Taşımak istediğiniz kartın adını yazınız");
                string taşınacakKart = Console.ReadLine();
                for (int i = 0; i < Todo.Count; i++)
                {
                    if (Todo[i].Ad==taşınacakKart)
                    {
                        MoveToInProgress(Todo[i]);
                        kartBulundu = true;
                    }
                }
                if(!kartBulundu)
                {
                    Console.WriteLine("Aradğınız kart bulunamadı");
                    return;
                }
            }
            else if (secim ==2)
            {
                Console.WriteLine("Taşımak istediğiniz kartın adını yazınız");
                string taşınacakKart = Console.ReadLine();
                for (int i = 0; i < inProgres.Count; i++)
                {
                    if (Todo[i].Ad==taşınacakKart)
                    {
                        MoveToDone(inProgres[i]);
                        kartBulundu = true;

                    }
                }
                if (!kartBulundu)
                {
                    Console.WriteLine("Aradğınız kart bulunamadı");
                    return;
                }
            }
            else
            {
            return;
            }
        
        }
        public static void BoardListele()
        {
            Console.WriteLine("Todo Line");
            Console.WriteLine("*****************");
            for (int i = 0; i < Todo.Count; i++)
            {
                Console.WriteLine("Baslik:".PadRight(15)+":"+Todo[i].Ad);
                Console.WriteLine("İçerik".PadRight(15)+": "+Todo[i].Icerik);
                Console.WriteLine("Atanan Kişi".PadRight(15)+": "+Todo[i].AtananKisi);
                Console.WriteLine("Büyüklük".PadRight(15)+": "+Todo[i].Buyukluk);
                
            }
            Console.WriteLine("InProgres");
            Console.WriteLine("*****************");
            for (int i = 0; i < inProgres.Count; i++)
            {
                Console.WriteLine("Baslik".PadRight(15)+": "+inProgres[i].Ad);
                Console.WriteLine("İçerik".PadRight(15)+": "+inProgres[i].Icerik);
                Console.WriteLine("Atanan Kişi".PadRight(15)+": "+inProgres[i].AtananKisi);
                Console.WriteLine("Büyüklük".PadRight(15)+": "+inProgres[i].Buyukluk);
            } 
            Console.WriteLine("Done");
            Console.WriteLine("*****************");
            for (int i = 0; i < done.Count; i++)
            {
                Console.WriteLine("Baslik".PadRight(15)+": "+done[i].Ad);
                Console.WriteLine("İçerik".PadRight(15)+": "+done[i].Icerik);
                Console.WriteLine("Atanan Kişi".PadRight(15)+": "+done[i].AtananKisi);
                Console.WriteLine("Büyüklük".PadRight(15)+": "+done[i].Buyukluk);
            }           
           

        }
        public static void MoveToInProgress(TodoKart kart)
        {
            Todo.Remove(kart);
            inProgres.Add(kart);
        }
        public static void MoveToDone(TodoKart kart)
        {
            inProgres.Remove(kart);
            done.Add(kart);
        }      
   
    }
    public enum zorluk
       {
            XS =1,
            S,
            M,
            L,
            XL
       }

}