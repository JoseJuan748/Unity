using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaE : MonoBehaviour
{
    private Transform player;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;

        if (transform.position.x < player.transform.position.x)
        {
            speed = 3;
        }
        else
        {
            speed = -3;
        }
    }

    void Update()
    {
        Vector3 unitVector = Vector3.right.normalized;
        transform.Translate(unitVector * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            TextCtrl vida = col.GetComponent<TextCtrl>();
            vida.UpdateHealth();

            Destroy(this.gameObject);
        }
    }
}
