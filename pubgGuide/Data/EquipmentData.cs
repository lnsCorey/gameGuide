using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pubgGuide.Data
{

    public class PubgEquipmentCategory
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String ImageRef { get; set; }
    }

    public class PubgEquipment
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Capacity { get; set; }
        public String ImageRef { get; set; }
    }


    public class PubgWeapon
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public String Ammo { get; set; }
        public Int32 MagazineCapacity { get; set; }
        public Int32 Damage { get; set; }
        public Int32 Range { get; set; }
        public Int32 Stability { get; set; }
        public Int32 Firerate { get; set; }
        public Int32 AttachmentPoints { get; set; }
        public String ImageRef { get; set; }
    }


    class EquipmentData
    {
        public static String Name = "Static PUBG Weapon Data";

        public static List<PubgWeapon> GetWeapons()
        {
            //Debug.WriteLine("GET for Weapons.");
            return new List<PubgWeapon>()
                {
                    new PubgWeapon() { Name="AKM",Type="Assault Rifle",Ammo="7.62",MagazineCapacity=30,Damage=48,Range=62,Stability=34,Firerate=61,AttachmentPoints=3},
                    new PubgWeapon() { Name="Groza",Type="Assault Rifle", Ammo="7.62",MagazineCapacity=30,Damage=48,Range=60,Stability=21,Firerate=65,AttachmentPoints=3},
                    new PubgWeapon() { Name="M16A4",Type="Assault Rifle", Ammo="5.56",MagazineCapacity=30,Damage=41,Range=62,Stability=36,Firerate=81,AttachmentPoints=3},
                    new PubgWeapon() { Name="M416",Type="Assault Rifle", Ammo="5.56",MagazineCapacity=30,Damage=41,Range=57,Stability=36,Firerate=77,AttachmentPoints=5},
                    new PubgWeapon() { Name="SCAR-L",Type="Assault Rifle", Ammo="5.56",MagazineCapacity=30,Damage=41,Range=55,Stability=31,Firerate=71,AttachmentPoints=4},

                    new PubgWeapon() { Name="Crossbow", Type="Bow", Ammo="Bolt",MagazineCapacity=1,Damage=60,Range=4,Stability=0,Firerate=3,AttachmentPoints=3},

                    new PubgWeapon() { Name="Mini 14", Type="DMR", Ammo="5.56",MagazineCapacity=20,Damage=44,Range=63,Stability=39,Firerate=46,AttachmentPoints=3},
                    new PubgWeapon() { Name="Mk14 EBR", Type="DMR", Ammo="7.62",MagazineCapacity=10,Damage=60,Range=82,Stability=58,Firerate=25,AttachmentPoints=4},
                    new PubgWeapon() { Name="SKS", Type="DMR", Ammo="7.62",MagazineCapacity=10,Damage=55,Range=64,Stability=48,Firerate=32,AttachmentPoints=4},

                    new PubgWeapon() { Name="M249", Type="LMR", Ammo="5.56",MagazineCapacity=100,Damage=44,Range=71,Stability=44,Firerate=77,AttachmentPoints=1},

                    new PubgWeapon() { Name="P18C", Type="Pistol", Ammo="9mm",MagazineCapacity=17,Damage=19,Range=11,Stability=25,Firerate=70,AttachmentPoints=3},
                    new PubgWeapon() { Name="P1911", Type="Pistol", Ammo=".45",MagazineCapacity=7,Damage=35,Range=15,Stability=26,Firerate=29,AttachmentPoints=3},
                    new PubgWeapon() { Name="P92", Type="Pistol", Ammo="9mm",MagazineCapacity=15,Damage=29,Range=15,Stability=24,Firerate=54,AttachmentPoints=3},
                    new PubgWeapon() { Name="R1895", Type="Pistol", Ammo="7.62",MagazineCapacity=7,Damage=46,Range=32,Stability=30,Firerate=11,AttachmentPoints=1},

                    new PubgWeapon() { Name="S12K", Type="Shotgun", Ammo="12 gauge",MagazineCapacity=5,Damage=198,Range=9,Stability=86,Firerate=15,AttachmentPoints=3},
                    new PubgWeapon() { Name="S1897", Type="Shotgun", Ammo="12 gauge",MagazineCapacity=5,Damage=225,Range=7,Stability=77,Firerate=7,AttachmentPoints=2},
                    new PubgWeapon() { Name="S686", Type="Shotgun", Ammo="12 gauge",MagazineCapacity=27,Damage=225,Range=12,Stability=77,Firerate=7,AttachmentPoints=2},

                    new PubgWeapon() { Name="KRISS Vector", Type="SMG", Ammo=".45",MagazineCapacity=13,Damage=31,Range=18,Stability=27,Firerate=51,AttachmentPoints=4},
                    new PubgWeapon() { Name="Micro Uzi", Type="SMG", Ammo="9mm",MagazineCapacity=25,Damage=23,Range=22,Stability=31,Firerate=70,AttachmentPoints=3},
                    new PubgWeapon() { Name="Tommy Gun", Type="SMG", Ammo=".45",MagazineCapacity=100,Damage=35,Range=46,Stability=31,Firerate=100,AttachmentPoints=1},
                    new PubgWeapon() { Name="UMP9", Type="SMG", Ammo="9mm",MagazineCapacity=30,Damage=35,Range=30,Stability=31,Firerate=62,AttachmentPoints=4},

                    new PubgWeapon() { Name="AWM", Type="Sniper Rifle", Ammo=".300",MagazineCapacity=5,Damage=100,Range=132,Stability=34,Firerate=6,AttachmentPoints=4},
                    new PubgWeapon() { Name="Kar98k", Type="Sniper Rifle", Ammo="7.62",MagazineCapacity=5,Damage=72,Range=80,Stability=34,Firerate=52,AttachmentPoints=3},
                    new PubgWeapon() { Name="M24", Type="Sniper Rifle", Ammo="7.62",MagazineCapacity=5,Damage=84,Range=96,Stability=32,Firerate=6,AttachmentPoints=4},
                    new PubgWeapon() { Name="VSS", Type="Sniper Rifle", Ammo="9mm",MagazineCapacity=10,Damage=35,Range=100,Stability=37,Firerate=26,AttachmentPoints=2},

                    new PubgWeapon() { Name="Crowbar", Type="Melee", Ammo="",MagazineCapacity=0,Damage=0,Range=0,Stability=0,Firerate=0,AttachmentPoints=0},
                    new PubgWeapon() { Name="Machete", Type="Melee", Ammo="",MagazineCapacity=0,Damage=0,Range=0,Stability=0,Firerate=0,AttachmentPoints=0},
                    new PubgWeapon() { Name="Pan", Type="Melee", Ammo="",MagazineCapacity=0,Damage=0,Range=0,Stability=0,Firerate=0,AttachmentPoints=0},
                    new PubgWeapon() { Name="Sickle", Type="Melee", Ammo="",MagazineCapacity=0,Damage=0,Range=0,Stability=0,Firerate=0,AttachmentPoints=0}
                };
        }

        public static List<PubgEquipmentCategory> GetEquipmentCategories()
        {
            //Debug.WriteLine("GET for Weapons.");
            return new List<PubgEquipmentCategory>()
                {
                    new PubgEquipmentCategory() { Id=1,Name="Weapons",Description="There are a variety of Weapons in PUBG",ImageRef=""},
                    new PubgEquipmentCategory() { Id=2,Name="Equipment",Description="There is a variety of Equipment in PUBG, varying from protective gear to various utilities used to aid players throughout the game.",ImageRef=""},
                    new PubgEquipmentCategory() { Id=3,Name="Items",Description="There are a variety of Items in PUBG, ranging from munitions to consumable items.",ImageRef=""},
                    new PubgEquipmentCategory() { Id=4,Name="Vehicles",Description="There are a variety of Vehicles in PUBG. The vehicles in BATTLEGROUNDS are vitally important to map movement, largely because of how far apart players are often placed. Once the initial close groupings of players are dealt with, movement into the center of the map is important, as the outer limits will shrink. Additionally, unless a headshot or other body shot is directly targeted, the player won't take significant damage while moving in a vehicle, hugely increasing their longevity.",ImageRef=""},
                };
        }




        public static void AddCategory(PubgEquipmentCategory category)
        {
            Debug.WriteLine("INSERT category with name " + category.Name);
        }

        public static void DeleteCategory(PubgEquipmentCategory category)
        {
            Debug.WriteLine("DELETE category with name " + category.Name);
        }
    }
}

