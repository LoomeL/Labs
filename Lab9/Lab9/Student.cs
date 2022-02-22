namespace Lab9
{
    public class Student : Human, IQRcode, ICanPutOnMask, ICanDisinfectHand
    {
        public bool IsHaveQR { get; set; }
        public bool IsHaveMask { get; set; }
    }
}