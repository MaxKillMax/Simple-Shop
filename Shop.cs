using System;
using System.Collections.Generic;
using System.Text;

namespace Storage
{
    class Shop
    {
        // Condoms
        public Condom Invisible = new Condom
            (
            "Invisible",
            "Dyrex",
            260,
            4,
            14
            );
        public Condom Embossed = new Condom
            (
            "Embossed",
            "Kontex",
            170,
            75,
            12
            );

        // Lubricants
        public Lubricant Light = new Lubricant
            (
            "Light",
            "Lubricio",
            185,
            52,
            "Water",
            75
            );
        public Lubricant HotChery = new Lubricant
            (
            "Hot Chery",
            "Dyrex",
            520,
            23,
            "Oil",
            120
            );

        // Clothes
        public Сlothing Policeman = new Сlothing
            (
            "Policeman",
            "MinFin",
            4000,
            12,
            60
            );
        public Сlothing BDSM = new Сlothing
            (
            "BDSM",
            "eRotic",
            1800,
            10,
            56
            );

        public List<Product> Products = new List<Product>();

        public Shop()
        {
            Products.Add(Invisible);
            Products.Add(Embossed);
            Products.Add(Light);
            Products.Add(HotChery);
            Products.Add(Policeman);
            Products.Add(BDSM);
        }
    }
}
