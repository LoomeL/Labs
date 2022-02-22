
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Checkpoint
    {
        public List<IVisitor> VisitirsWantToISIT = new();
        public List<IVisitor> VisitirsCanToISIT = new();

        public int Mask = 10;
        public int Antiseptic = 10;

        public Checkpoint()
        {
            VisitirsWantToISIT.Add(new Student() { Name = "Лера", IsHaveMask = true, IsHaveQR = true});
            VisitirsWantToISIT.Add(new Student() { Name = "Эмир", IsHaveMask = true, IsHaveQR = false });
            VisitirsWantToISIT.Add(new Teacher() {  Name = "Алена", IsHaveMask = false, IsHaveQR = true });
            VisitirsWantToISIT.Add(new Dog() { Name = "Хатико", IsHaveMask = false });
            VisitirsWantToISIT.Add(new Dove() { Name = "НАТАША" });
            VisitirsWantToISIT.Add(new Squirrel() { Name = "Просто белка" });
        }

        public void Check()
        {
            List<IVisitor> VisitirsWantToISITnew = new();
            VisitirsWantToISIT.ForEach(x =>
            {
                VisitirsWantToISITnew.Add(x);
                // Проверка условий, если карантинные меры не соблюдены не пускаем.
                if (x is IQRcode)
                    if (!(x as IQRcode).IsHaveQR)
                    {
                        Console.WriteLine(x.GetType().ToString().Split(".")[1] + ": " + x.Name + " - отсутствует QR код");
                        return;
                    }

                if (x is ICanPutOnMask)
                    if (!(x as ICanPutOnMask).IsHaveMask)
                    {
                        if (Mask > 0)
                        {
                            Mask--;
                            (x as ICanPutOnMask).IsHaveMask = true;
                        }
                        else 
                        {
                            Console.WriteLine(x.GetType().ToString().Split(".")[1] + ": " + x.Name + " - на КПП закончились маски, не можем пропустить сущность.");
                            return;
                        }
                    }

                if (x is ICanDisinfectHand)
                    if (Antiseptic > 0) Antiseptic--;
                    else 
                    {
                        Console.WriteLine(x.GetType().ToString().Split(".")[1] + ": " + x.Name + " - на КПП закончились порции антисептика, не можем пропустить сущность.");
                        return;
                    }

                VisitirsCanToISIT.Add(x);
                VisitirsWantToISITnew.Remove(x);
            });
            VisitirsWantToISIT.Clear();
            VisitirsWantToISIT = VisitirsWantToISITnew;
        }
    }
}
