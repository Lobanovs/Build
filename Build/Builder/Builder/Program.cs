using Builder.Builders;

namespace Builder

{
    class Program
    {
        static void Main(string[] args)
        {
            var cpu = new CPU { Model = "Intel i5" };
            var motherboard = new Motherboard { Model = "ASUS Prime" };
            var ram = new RAM { Model = "Kingston 16GB" };
            var storage = new Storage { Model = "Samsung SSD 512GB" };
            var gpu = new GPU { Model = "NVIDIA GTX 1660" };

            var computerBuilder = new ComputerBuilder();
            var computer = computerBuilder
                .SetCPU(cpu)
                .SetMotherboard(motherboard)
                .SetRAM(ram)
                .SetStorage(storage)
                .SetGPU(gpu)
                .Build();

            Console.WriteLine(computer);
        }
    }
}
