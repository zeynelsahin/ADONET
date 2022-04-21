using _19._04._22_ADONET.Model;

namespace _19._04._22_ADONET.Data
{
    public class KitapDB
    {
        public KitapDB(Kitaplar kitaplar, Kategoriler kategoriler)
        {
            Kitaplar = kitaplar;
            Kategoriler = kategoriler;
        }

        private Kitaplar Kitaplar { get; set; }
        private Kategoriler Kategoriler { get; set; }
    }
}