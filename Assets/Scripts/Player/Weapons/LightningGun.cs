using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningGun : Weapon
{
    public override string Name { get; set; } = "Lightning Gun"; 
    public override int Ammo { get; set; } = int.MaxValue;
    public override float ShotInterval { get; set; } = 0.05f;
    public override int Damage { get; set; } = 5;
    public override bool isHitscan { get; set; } = true;
    public override bool isAutomatic { get; set; } =  true;
}
