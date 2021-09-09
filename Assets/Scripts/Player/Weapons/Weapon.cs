using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    public abstract string Name { get; set; }
    public abstract int Ammo { get; set; }
    public abstract float ShootInterval { get; set; }
    public abstract int Damage { get; set; } // should make damage numbers more complexi
    public abstract bool isHitscan { get; set; }
    public abstract bool isAutomatic { get; set; }
}
