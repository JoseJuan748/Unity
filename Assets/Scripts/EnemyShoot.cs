using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject bala;
    private int index = 0;
    private float delay = 1, burstDelay = .2f;
    void Start()
    {
        Invoke(nameof(Shoot), delay);
    }

    private void Shoot()
    {
        Instantiate(bala, transform.position , Quaternion.identity);
        if (index < 2)
        {
            index++;
            Invoke(nameof(Shoot), burstDelay);
        }
        else
        {
            index = 0;
            Invoke(nameof(Shoot), delay);
        }
    }
}
