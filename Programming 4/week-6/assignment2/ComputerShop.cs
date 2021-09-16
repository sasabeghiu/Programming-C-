
namespace assignment2
{
    public class ComputerShop
    {
        public Computer AssembleComputer(ComputerFactory factory)
        {
            IProcessor processor = factory.MakeProcessor();
            IHardDisk hardDisk = factory.MakeHardDisk();
            IMonitor monitor = factory.MakeMonitor();

            Computer computer = new Computer(processor, hardDisk, monitor);
            return computer;
        }
    }
}
