using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemyLife : MonoBehaviour
{
    public int lifes = 3;
    public void GetDamage()
    {
        lifes--;
            
        if(lifes <= 0) Destroy(this.gameObject);
    }
}
