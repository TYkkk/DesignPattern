using System;

namespace DesignPattern
{
    public abstract class PhoneFactory
    {
        public abstract AndroidPhone CreateAndroidPhone();
        public abstract IOSPhone CreateIOSPhone();
    }

    public abstract class AndroidPhone
    {
        public abstract void PrintOrigin();
    }

    public abstract class IOSPhone
    {
        public abstract void PrintOrigin();
    }

    public class ChinaPhoneFactory : PhoneFactory
    {
        public override AndroidPhone CreateAndroidPhone()
        {
            return new ChinaAndroidPhone();
        }

        public override IOSPhone CreateIOSPhone()
        {
            return new ChinaIOSPhone();
        }
    }

    public class ChinaAndroidPhone : AndroidPhone
    {
        public override void PrintOrigin()
        {
            Console.WriteLine("This Android Phone Made In China");
        }
    }

    public class ChinaIOSPhone : IOSPhone
    {
        public override void PrintOrigin()
        {
            Console.WriteLine("This IOS Phone Made In China");
        }
    }

    public class AmericaPhoneFactory : PhoneFactory
    {
        public override AndroidPhone CreateAndroidPhone()
        {
            return new AmericaAndroidPhone();
        }

        public override IOSPhone CreateIOSPhone()
        {
            return new AmericaIOSPhone();
        }
    }

    public class AmericaAndroidPhone : AndroidPhone
    {
        public override void PrintOrigin()
        {
            Console.WriteLine("This Android Phone Made In America");
        }
    }

    public class AmericaIOSPhone : IOSPhone
    {
        public override void PrintOrigin()
        {
            Console.WriteLine("This IOS Phone Made In America");
        }
    }
}
