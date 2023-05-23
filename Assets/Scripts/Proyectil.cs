using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemigo 1"))
        {

            EnemyLife enemy = col.GetComponent<EnemyLife>();

            enemy.GetDamage();

            Destroy(this.gameObject);
        }
    }
}
