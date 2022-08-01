using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerScript : MonoBehaviour
{
    public float distancia;
    public GameObject player;
    public float velocidade;
    public float tempoDeJogo;

    void Start()
    {

    }

    void Update()
    {
        distancia = Vector2.Distance(transform.position, player.transform.position);
        if (distancia <= 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, velocidade * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            tempoDeJogo -= 15;
        }
    }

}
