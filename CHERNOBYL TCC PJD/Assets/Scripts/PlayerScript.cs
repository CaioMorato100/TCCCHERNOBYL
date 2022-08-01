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
    
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float movimentoHorizontal = Input.GetAxisRaw("Horizontal");
        float movimentoVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * movimentoHorizontal);
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime * movimentoVertical);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Instantiate(projetil, pontoDeTiro.transform.position, projetil.transform.rotation);
        }
       
        }
    }

      

