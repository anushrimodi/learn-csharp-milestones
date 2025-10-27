using UnityEngine;

/// <summary>
/// Demonstrates OOP in Unity with classes, structs, and inheritance.
/// </summary>
public class Character
{
    // Fields
    public string name;
    public int level;

    // Character constructor
    public Character(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    // Virtual method to display stats
    public virtual void PrintStatsInfo()
    {
        Debug.Log($"Character: {name}, Level: {level}");
    }
}

/// <summary>
/// A struct representing a weapon (value type).
/// </summary>
public struct Weapon
{
    public string weaponName;
    public int damage;

    // Weapon constructor
    public Weapon(string weaponName, int damage)
    {
        this.weaponName = weaponName;
        this.damage = damage;
    }

    // Method to display weapon info
    public void PrintWeaponStats()
    {
        Debug.Log($"Weapon: {weaponName}, Damage: {damage}");
    }
}

/// <summary>
/// Paladin is a subclass of Character that wields a Weapon.
/// </summary>
public class Paladin : Character
{
    public Weapon weapon;

    // Paladin constructor calls base Character constructor
    public Paladin(string name, int level, Weapon weapon) : base(name, level)
    {
        this.weapon = weapon;
    }

    // Override base class method to include weapon details
    public override void PrintStatsInfo()
    {
        Debug.Log($"Paladin: {name}, Level: {level}, Weapon: {weapon.weaponName} (Damage: {weapon.damage})");
    }
}
