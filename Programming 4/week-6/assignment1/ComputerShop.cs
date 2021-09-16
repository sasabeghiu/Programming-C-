
namespace assignment1
{
    public class ComputerShop
    {
        public Computer AssembleComputer()
        {
            IProcessor processor = MakeProcessor();
            IHardDisk hardDisk = MakeHardDisk();
            IMonitor monitor = MakeMonitor();
            Computer computer = new Computer(processor, hardDisk, monitor);
            return computer;
        }

        public virtual IProcessor MakeProcessor() { return new LowBugetProcessor(); }
        public virtual IHardDisk MakeHardDisk() { return new LowBugetHardDisk(); }
        public virtual IMonitor MakeMonitor() { return new LowBugetMonitor(); }
    }
}
