using System;
using System.Collections.Generic;

namespace DesignPattern
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartCPU();
            builder.BuildPartGPU();
            builder.BuildPartVentilation();
        }
    }

    public class Computer
    {
        private IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("检查电脑");

            foreach (var part in parts)
            {
                Console.WriteLine($"已装上{part}组件");
            }

            Console.WriteLine("检查结束");
        }
    }

    public abstract class Builder
    {
        public abstract void BuildPartCPU();
        public abstract void BuildPartGPU();
        public abstract void BuildPartVentilation();

        public abstract Computer GetComputer();
    }

    public class HighConfigComputerBuilder : Builder
    {
        Computer computer = new Computer();

        public override void BuildPartCPU()
        {
            computer.Add("I9-9900K");
        }

        public override void BuildPartGPU()
        {
            computer.Add("GTX2080");
        }

        public override void BuildPartVentilation()
        {
            computer.Add("水冷系统");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }

    public class LowConfigComputerBuilder : Builder
    {
        Computer computer = new Computer();

        public override void BuildPartCPU()
        {
            computer.Add("I3-3300");
        }

        public override void BuildPartGPU()
        {
            computer.Add("GTX660");
        }

        public override void BuildPartVentilation()
        {
            computer.Add("小风扇");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
