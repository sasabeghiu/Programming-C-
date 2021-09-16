
namespace assignment1
{
    public class HighBugetShop : ComputerShop
    {
        public override IProcessor MakeProcessor()
        {
            return new HighBugetProcessor();
        }

        public override IHardDisk MakeHardDisk()
        {
            return new HighBugetHardDisk();
        }

        public override IMonitor MakeMonitor()
        {
            return new HighBugetMonitor();
        }
    }
}
