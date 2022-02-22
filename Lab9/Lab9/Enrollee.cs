namespace Lab9
{
    public class Enrollee : Human, IQRcode, ICanPutOnMask, ICanDisinfectHand
    {
        public bool IsHaveQR { get; set; }
        public bool IsHaveMask { get; set; }
    }
}