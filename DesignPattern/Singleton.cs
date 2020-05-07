namespace DesignPattern
{
    public sealed class Singleton01         //single threading
    {
        private Singleton01 _instance;

        public Singleton01 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton01();
                }

                return _instance;
            }
        }

        private Singleton01()
        {

        }
    }

    public sealed class Singleton02         //multi threading
    {
        private volatile Singleton02 _instance;

        private static readonly object locker = new object();

        public Singleton02 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton02();
                        }
                    }
                }

                return _instance;
            }
        }

        private Singleton02()
        {

        }
    }

    //volatile修饰：编译器在编译代码的时候会对代码的顺序进行微调，用volatile修饰保证了严格意义的顺序。
    //一个定义为volatile的变量是说这变量可能会被意想不到地改变，这样，编译器就不会去假设这个变量的值了。
    //精确地说就是，优化器在用到这个变量时必须每次都小心地重新读取这个变量的值，而不是使用保存在寄存器里的备份。

    public sealed class Singleton03         //static
    {
        public static readonly Singleton03 Instance = new Singleton03();
        private Singleton03()
        {

        }
    }
}
