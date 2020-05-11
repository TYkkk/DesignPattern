using System;

namespace DesignPattern
{
    /// <summary>
    /// 希望复用一些现存的类，但是接口又与复用环境要求不一致的情况
    /// </summary>
    class AdapterPattern
    {
        #region 对象适配器模式
        public class TwoHoleTarget
        {
            public virtual void Request()
            {
                Console.WriteLine("Two Hole");
            }
        }

        public class ThreeHoleAdaptee
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Three Hole");
            }
        }

        public class ThreeToTwoAdapter : TwoHoleTarget
        {
            private ThreeHoleAdaptee threeHoleAdaptee = new ThreeHoleAdaptee();

            public override void Request()
            {
                threeHoleAdaptee.SpecificRequest();
            }
        }
        #endregion

        #region 类适配器模式
        public interface ITwoHoleTarget
        {
            void Request();
        }

        public abstract class ThreeHoleAdaptee_I
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Three Hole");
            }
        }

        public class ThreeToTwoAdapter_I : ThreeHoleAdaptee_I, ITwoHoleTarget
        {
            public void Request()
            {
                this.SpecificRequest();
            }
        } 
        #endregion
    }
}
