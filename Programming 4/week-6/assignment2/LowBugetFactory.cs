
namespace assignment2
{
    public class LowBugetFactory : ComputerFactory
    {
        public override IProcessor MakeProcessor()
        {
            return new LowBugetProcessor();
        }

        public override IHardDisk MakeHardDisk()
        {
            return new LowBugetHardDisk();
        }

        public override IMonitor MakeMonitor()
        {
            return new LowBugetMonitor();
        }
    }
}
