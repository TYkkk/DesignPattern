using System.Collections.Generic;
using System.IO;

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

    public class TestData02 : PrototypePattern
    {
        public override PrototypePattern Copy()
        {
            using (MemoryStream writeMs = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(writeMs);

                binaryWriter.Write(ID);
                binaryWriter.Write(Data.Count);

                for (int i = 0; i < Data.Count; i++)
                {
                    binaryWriter.Write(Data[i]);
                }

                binaryWriter.Close();
                byte[] copyData = writeMs.ToArray();

                using (MemoryStream readerMs = new MemoryStream(writeMs.ToArray()))
                {
                    BinaryReader binaryReader = new BinaryReader(readerMs);
                    TestData02 copyResult = new TestData02();
                    copyResult.ID = binaryReader.ReadInt32();
                    copyResult.Data = new List<int>(binaryReader.ReadInt32());

                    for (int i = 0; i < copyResult.Data.Count; i++)
                    {
                        var data = binaryReader.ReadInt32();
                        copyResult.Data.Add(data);
                    }

                    binaryReader.Close();

                    return copyResult;
                }
            }
        }
    }

    //可使用序列化方式进行深复制
}
