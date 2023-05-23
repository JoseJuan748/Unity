using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Vector3 offset;

    private bool canShoot = true;
    
    public void ShootFunc()
    {
        if(canShoot == false) return;
        
        Vector3 shootPosition = offset;
        float speed = 5;

        if (_spriteRenderer.flipX)
        {
            shootPosition.x = -shootPosition.x;
            speed = speed * -1;
        }

        Proyectil bulletScript = Instantiate(bullet, transform.position + shootPosition, Quaternion.identity).GetComponent<Proyectil>();
        
        bulletScript.speed = speed;
        
        canShoot = false;
        Invoke(nameof(RestoreShoot), .3f);
    }

    void RestoreShoot()
    {
        canShoot = true;
    }
}
