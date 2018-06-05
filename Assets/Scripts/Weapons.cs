using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public struct RangedWeapon
    {
        public readonly string name;
        public readonly int range;
        public readonly int dice;
        public readonly int damage;
        public bool used;
        public RangedWeapon(string name, int range, int dice, int damage)
        {
            this.name = name;
            this.range = range;
            this.dice = dice;
            this.damage = damage;
            used = false;
        }
    }

    public struct MeleeWeapon
    {
        public readonly string name;
        public readonly int dice;
        public readonly int damage;
        public bool used;
        public MeleeWeapon(string name, int dice, int damage)
        {
            this.name = name;
            this.dice = dice;
            this.damage = damage;
            used = false;
        }
    }

    private static List<RangedWeapon> _rangeWeapons = new List<RangedWeapon>();
    private static List<MeleeWeapon> _meleeWeapons = new List<MeleeWeapon>();

    public static void LoadWeapons()
    {
        //0 : No value
        //-1 : health
        _rangeWeapons.Add(new RangedWeapon("NULL"           , 0 , 0 , 0));
        _rangeWeapons.Add(new RangedWeapon("Mortar"         , 20, 2 , 4));
        _rangeWeapons.Add(new RangedWeapon("Flame Thrower"  , 3 , 1 , 3));
        _rangeWeapons.Add(new RangedWeapon("Fancy Pistol"   , 5 , 1 , 2));
        _rangeWeapons.Add(new RangedWeapon("Cannon"         , 14, 1 , 8));
        _rangeWeapons.Add(new RangedWeapon("Machine Gun"    , 6 , 6 , 1));
        _rangeWeapons.Add(new RangedWeapon("Rifle"          , 6 ,-1 , 1));

        //-1 : health
        //-2 : health * 2
        _meleeWeapons.Add(new MeleeWeapon("NULL"                , 0 , 0));
        _meleeWeapons.Add(new MeleeWeapon("Improvised Weapon"   , 1 , 1));
        _meleeWeapons.Add(new MeleeWeapon("Sword"               , 4 , 2));
        _meleeWeapons.Add(new MeleeWeapon("Shovel"              ,-2 , 1));
        _meleeWeapons.Add(new MeleeWeapon("Bayonnet"            ,-1 , 1));
    }


    public static List<MeleeWeapon> MeleeWeapons
    {
        get
        {
            return _meleeWeapons;
        }
    }

    public static List<RangedWeapon> RangedWeapons
    {
        get
        {
            return _rangeWeapons;
        }
    }
}