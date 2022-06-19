namespace angularnetcoreweb.Models
{
    public class kullanici
    {
        //kullanici eklendi
        public kullanici()
        {
            AdSoyad = "";
            Telefon = "";
        }
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public List<kullanici> KullaniciGetir()
        {
            List<kullanici> kullaniciList = new List<kullanici>();
            for (int i = 0; i < 25; i++)
            {
                kullaniciList.Add(new kullanici
                {
                    Id = i,
                    AdSoyad = "Furkan Gonul" + i,
                    Telefon = "0525 222 35 4" + i

                });
            }
            return kullaniciList;
        }
    }

}
