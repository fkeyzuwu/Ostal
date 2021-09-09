using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class WeaponShoot : MonoBehaviour
{
    [SerializeField] private Player player;
    private Transform eyePosition;

    private float timer = 0;

    void Start()
    {
        eyePosition = Camera.main.transform;
    }

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

    public void UpdateWeaponShotInterval(float shotInterval)
    {
        timer = shotInterval;
    }

    private void Shoot()
    {
        if(timer < player.CurrentWeapon.ShotInterval)
        {
            timer += Time.deltaTime;
            return;
        }

        timer = 0f;

        RaycastHit hit;
        Physics.Raycast(eyePosition.position, transform.forward, out hit);

        if (hit.collider == null) return;

        if (hit.collider.CompareTag("Player"))
        {
            player.CmdDealDamage(player.CurrentWeapon.Damage, hit.collider.GetComponent<NetworkIdentity>());
        }
    }
}
