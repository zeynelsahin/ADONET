namespace _19._04._22_ADONET.Model
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public int KategoriId { get; set; }
        public int? SayfaSayisi { get; set; }
        public string Ozet { get; set; }
    }
}