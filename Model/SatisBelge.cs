namespace Update.Mapper.Model
{
    public class SatisBelge : BelgeBaslik
    {
        public int TeslimHesap { get; set; }
        public List<BelgeVergi> BelgeVergiler { get; set; }
        public List<BelgeIskonto> BelgeIskontolar { get; set; }

    }
}
