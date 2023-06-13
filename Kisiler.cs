namespace TodoUygulamasi
{
    public class kisiler
    {
        public static string MevcutKisiler(int kisi)
        {
            Dictionary<int,string> Kisiler = new();
            Kisiler.Add(1,"Muhammed Salih");
            Kisiler.Add(2,"Tutanay Gamze");
            Kisiler.Add(3,"Serdar Eren");
            Kisiler.Add(4,"Akın Eğinli");
            Kisiler.Add(5,"Uğur Geleç");
            return Kisiler[kisi];
        }
    }
}