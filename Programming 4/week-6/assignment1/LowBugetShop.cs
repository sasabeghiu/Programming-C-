
namespace assignment1
{
    public class LowBugetShop : ComputerShop
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
