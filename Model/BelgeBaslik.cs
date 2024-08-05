namespace Update.Mapper.Model
{
    public class BelgeBaslik : BaseEntity
    {
        public string BelgeNo { get; set; }
        public List<StokHareket> StokHareketler { get; set; }
        public List<CariHareket> CariHareketler { get; set; }
        public List<SiparisHareket> SiparisHareketler { get; set; }
        public List<BelgeEkler> BelgeEkler { get; set; }

    }
}
