using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iUnit
{
    string Name { get; }
    int Movement{ get; }
    int Health { get; }
    int RangedSkill { get; }
    int CombatSkill { get; }
    int ArmourSkill { get; }
    int Points { get; }
    int Faction { get; set; }
    List<Weapons.RangedWeapon> RangedWeapons { get; }
    List<Weapons.MeleeWeapon> MeleeWeapons { get; }
    Map.HexCooridnates TurnStartingPosition { get; set; }
    Map.HexCooridnates CurrentPosition { get; set; }
}