using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class WeaponShoot : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Transform eyePosition;
    void Update()
    {
        if (player.CurrentWeapon.isAutomatic)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Shoot();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Shoot();
            }
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(eyePosition.position, transform.forward, out hit);

        if(hit.collider.CompareTag("Player"))
        {
            player.TargetDealDamage(player.CurrentWeapon.Damage, hit.collider.GetComponent<NetworkIdentity>());
        }
    }
}
