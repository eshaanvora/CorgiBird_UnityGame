using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerTower : MonoBehaviour
{
    private Rigidbody2D beerRigidbody;

    //public void Awake()
    //{
        //beerRigidbody = gameObject.GetComponent<Rigidbody2D>();
        //print("HI");
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.gameObject.tag == "corgi")
        {
            Destroy(collision.gameObject);
            Game.Instance.OutOfPlay();
            
        }

        if (collision.gameObject.gameObject.tag == "portal")
        {
            print("HELLO");

        }


    }
}

