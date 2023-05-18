using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float fuerza;
    

    private Rigidbody2D rigid;
    private SpriteRenderer spriteRend;
    public Animator animator;


    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }


    public void BotonSalto()
    {
       
        rigid.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
    }

    public void BotonMoverDer()
    {
        velocidad = 5;
        spriteRend.flipX = false;
        animator.SetBool("Run", true);
    }

    public void BotonMoverIzq()
    {
        velocidad = -5;
        spriteRend.flipX = true;
        animator.SetBool("Run", true);
    }

    public void Detener()
    {
        velocidad = 0;
        animator.SetBool("Run", false);
    }

    private void OnMouseDown()
    {
        float rojo = Random.Range(0, 2);
        float verde = Random.Range(0, 2);
        float azul = Random.Range(0, 2);
        spriteRend.color = new Color(rojo, verde, azul, 1f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.CompareTag ("Ground")) 
        {
            Debug.Log("Suelo");

         
        }
        if (other.collider.CompareTag("Enemigo 1"))
        {
            Debug.Log("Golpe");
        }

    }

}
