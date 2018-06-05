﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEngineers : MonoBehaviour, iUnit {

    private string _name = "Combat Enginneers";

    private int _movement = 3;
    private int _health = 10;
    private int _rangedSkill = 20;
    private int _combarSkill = 8;
    private int _armourSkill = 14;
    private int _points = 30;
    private int _faction = 0;

    private Map.HexCooridnates _startingPosition = new Map.HexCooridnates(0, 0);
    private Map.HexCooridnates _currentPosition = new Map.HexCooridnates(0, 0);

    private List<Weapons.RangedWeapon> _rangedWeapons = new List<Weapons.RangedWeapon>();
    private List<Weapons.MeleeWeapon> _meleeWeapons = new List<Weapons.MeleeWeapon>();

    public string Name { get { return _name; } }

    public int Movement { get { return _movement; } }
    public int Health { get { return _health; } }
    public int RangedSkill { get { return _rangedSkill; } }
    public int CombatSkill { get { return _combarSkill; } }
    public int ArmourSkill { get { return _armourSkill; } }
    public int Points { get { return _points; } }

    public Map.HexCooridnates TurnStartingPosition
    {
        get
        {
            return _startingPosition;
        }
        set
        {
            _startingPosition = value;
        }
    }
    public Map.HexCooridnates CurrentPosition
    {
        get
        {
            return _currentPosition;
        }
        set
        {
            _currentPosition = value;
        }
    }

    public List<Weapons.RangedWeapon> RangedWeapons { get { return _rangedWeapons; } }
    public List<Weapons.MeleeWeapon> MeleeWeapons { get { return _meleeWeapons; } }

    public int Faction
    {
        get
        {
            return _faction;
        }
        set
        {
            _faction = value;
        }
    }

}