using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    private BoxCollider2D floorCollider;
    private float lengthOfFloor;

    void Start()
    {
        floorCollider = GetComponent<BoxCollider2D>();

        //Instantiate(prefab, BeerTowerLocation, Quaternion.identity);

        lengthOfFloor = floorCollider.size.x;

        
    }

    void Update()
    {
        if (transform.position.x < -lengthOfFloor)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(lengthOfFloor * 2, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }

}
