namespace Task2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Automobile AudiA7 = new Automobile("130000 lv.", "8 L/100 km.");
            Automobile BMW740 = new Automobile("120000 lv.", "8 L/100 km.");
            Automobile MaseratiGranCabrio = new Automobile("250000 lv.", "14.5 L/100 km.");
            Automobile HyundaiI30 = new Automobile("25000 lv.", "6 L/100 km.");
            Automobile GreatWallC30 = new Automobile("22000 lv.", "7 L/100 km.");
            SUV InfinitiQX50 = new SUV("80000 lv.", true);
            SUV VolkswagenTouareg = new SUV("90000 lv.", true);
            SUV PorscheCayenne = new SUV("100000 lv.", true);
            SUV ToyotaLandCruiser = new SUV("90000 lv.", true);
            SUV MercedesGLK = new SUV("80000 lv.", true);
            
            Car[] array = new Car[]
            {
                AudiA7, BMW740, MaseratiGranCabrio, HyundaiI30, GreatWallC30, InfinitiQX50,
                VolkswagenTouareg, PorscheCayenne, ToyotaLandCruiser, MercedesGLK
            };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(HyundaiI30);
        }
    }
}
