using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtack2 : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private int ReloadTime;
    private bool canShoot = true;

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Q) && canShoot)
        {
            StartCoroutine(Reload());
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }

    IEnumerator Reload()
    {
        canShoot = false;
        yield return new WaitForSeconds(ReloadTime);
        canShoot = true;
    }
}
