namespace Lab9
{
    public class Teacher : Human, IQRcode, ICanPutOnMask, ICanDisinfectHand
    {
        public bool IsHaveQR { get; set; }
        public bool IsHaveMask { get; set; }
    }
}