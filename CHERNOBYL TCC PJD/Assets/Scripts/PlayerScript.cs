using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("Movimento Player")]
    private Rigidbody2D rB;
    public float speed;
    [Header("Atirar")]
    public GameObject projetil;
    public GameObject pontoDeTiro;
    private Animator anim;
    private bool verificarDirecao;

    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        float movimentoHorizontal = Input.GetAxisRaw("Horizontal");
        float movimentoVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * movimentoHorizontal);
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime * movimentoVertical);

        if(movimentoHorizontal > 0 && verificarDirecao == true)
        {
            flipX();
        }
        if (movimentoHorizontal < 0 && verificarDirecao == false)
        {
            flipX();
        }


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Instantiate(projetil, pontoDeTiro.transform.position, projetil.transform.rotation);
        }
        anim.SetInteger("Horizontal", (int)movimentoHorizontal);
    }
    void flipX()
    {

        verificarDirecao = !verificarDirecao;
        float x = transform.localScale.x * -1;
        transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
    }
    
}




