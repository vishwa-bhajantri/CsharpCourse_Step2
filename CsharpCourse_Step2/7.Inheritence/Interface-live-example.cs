using System;

namespace RemotingSystem
{
    interface IRemote
    {
        void PowerOn();
        void ChangeVolume(int ChannelNumber);
        void IncreaseVolume();
    }

    interface IPrice
    {
        double GetPrice();
        
    }

    interface IRemoteManufacturer : IRemote, IPrice
    {
        void GetManufacturDetails();
    }

    class SonyRemote : IRemote, IPrice
    {
        public void PowerOn()
        {
            Console.WriteLine("Sony TV is On");
        }

        public void ChangeVolume(int ChannelNumber)
        {
            Console.WriteLine($"Sony TV changed to the volume {ChannelNumber}");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Sony TV Volume Increased");
        }

        public double GetPrice()
        {
            return 1000.99;
        }
    }

    class LGRemote : IRemote
    {
        public void ChangeVolume(int ChannelNumber)
        {
            Console.WriteLine($"LG TV changed to the volume {ChannelNumber}");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("LG TV Volume Increased");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG TV is On");
        }
    }

    class SamsungRemote : IRemoteManufacturer
    {
        public void ChangeVolume(int ChannelNumber)
        {
            Console.WriteLine($"Samsung TV changed to the volume {ChannelNumber}");
        }

        public void GetManufacturDetails()
        {
            Console.WriteLine("Manufacturer Samsung Electronics");
            Console.WriteLine("Country : South Korea");
        }

        public double GetPrice()
        {
            return 545.38;
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Samsung TV Volume Increased");
        }

        public void PowerOn()
        {
            Console.WriteLine("Samsung TV is On");
        }
    }

    class Program
    {
        public static void Main()
        {
            IRemote sony = new SonyRemote();
            sony.PowerOn();
            sony.IncreaseVolume();
            sony.ChangeVolume(1226);

            IPrice sonyPrice = new SonyRemote();
            Console.WriteLine(sonyPrice.GetPrice());

            IRemote lg = new LGRemote();
            lg.PowerOn();
            lg.IncreaseVolume();
            lg.ChangeVolume(1554);

            IRemoteManufacturer samsungRemote = new SamsungRemote();
            samsungRemote.GetManufacturDetails();
            samsungRemote.ChangeVolume(456);
            samsungRemote.IncreaseVolume();
            samsungRemote.PowerOn();
            Console.WriteLine(samsungRemote.GetPrice());
        }
    }
}