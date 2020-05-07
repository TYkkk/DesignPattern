using System.Collections.Generic;

namespace DesignPattern
{
    public abstract class PrototypePattern
    {
        public int ID { get; set; }

        public List<int> Data { get; set; }

        public abstract PrototypePattern Copy();
    }

    public class TestData01 : PrototypePattern
    {
        public override PrototypePattern Copy()
        {
            return (TestData01)this.MemberwiseClone();
        }
    }

    //此处MemberwiseClone是浅复制
}
