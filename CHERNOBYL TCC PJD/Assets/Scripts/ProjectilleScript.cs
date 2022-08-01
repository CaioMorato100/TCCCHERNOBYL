using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilleScript : MonoBehaviour
{
    [Header("Atirar")]

    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Parede")
        {
           // Destroy(gameObject);
           // Destroy(collision.gameObject);
        }
        else
        {
            Destroy(gameObject, 2f);
        }
        }
    }

