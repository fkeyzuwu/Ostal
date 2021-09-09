using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    [SerializeField] private Movement movement;
    [SerializeField] private MouseLook mouseLook;
    [SerializeField] private WeaponShoot weaponShoot;

    [SyncVar] public int health = 100;

    private Weapon[] weapons;
    private Weapon currentWeapon;

    void Start()
    {
        CurrentWeapon = new LightningGun();
    }

    [Command]
    public void CmdDealDamage(int damage, NetworkIdentity identity)
    {
        identity.GetComponent<Player>().health -= damage;

        if(health <= 0)
        {
            Debug.Log("ded");
        }
    }

    public Weapon CurrentWeapon
    {
        get { return currentWeapon; }
        private set
        {
            currentWeapon = value;
            weaponShoot.UpdateWeaponShotInterval(currentWeapon.ShotInterval);
        }
    }
}
