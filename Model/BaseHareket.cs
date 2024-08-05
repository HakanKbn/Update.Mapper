namespace Update.Mapper.Model
{
    public class BaseHareket : BaseEntity
    {
        public int SiraNo { get; set; }
        public  List<HareketEkler> HareketEkler { get; set; }
        public List<HareketVergi> HareketVergiler { get; set; }
        public List<HareketIskonto> HareketIskontolar { get; set; }
    }
}
