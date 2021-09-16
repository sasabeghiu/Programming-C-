
namespace assignment2
{
    public class ComputerFactory
    {
        public virtual IProcessor MakeProcessor() { return new LowBugetProcessor(); }
        public virtual IHardDisk MakeHardDisk() { return new LowBugetHardDisk(); }
        public virtual IMonitor MakeMonitor() { return new LowBugetMonitor(); }
    }
}
