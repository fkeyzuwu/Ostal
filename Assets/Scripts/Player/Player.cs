using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    [SerializeField] private Movement movement;
    [SerializeField] private MouseLook mouseLook;

    [SyncVar] public int health = 100;

    private Weapon[] weapons;
    private Weapon currentWeapon;

    [TargetRpc]
    public void TargetDealDamage(int damage, NetworkIdentity identity)
    {
        identity.GetComponent<Player>().health -= damage;

        if(health <= 0)
        {
            //player shud dieded
        }
    }

    public Weapon CurrentWeapon
    {
        get { return currentWeapon; }
    }
}
