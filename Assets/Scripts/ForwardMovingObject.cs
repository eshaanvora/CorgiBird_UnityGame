using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovingObject : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(Game.Instance.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Increases the scroll speed of the background
        // as player score increases

        if (Game.Instance.score >= 10)
        {
            Game.Instance.scrollSpeed = -2f;
            rigidBody.velocity = new Vector2(Game.Instance.scrollSpeed, 0);
        }
        else if (Game.Instance.score >= 20)
        {
            Game.Instance.scrollSpeed = -3f;
            rigidBody.velocity = new Vector2(Game.Instance.scrollSpeed, 0);
        }
        else if (Game.Instance.score >= 30)
        {
            Game.Instance.scrollSpeed = -4f;
            rigidBody.velocity = new Vector2(Game.Instance.scrollSpeed, 0);
        }
        else if (Game.Instance.score >= 40)
        {
            Game.Instance.scrollSpeed = -5f;
            rigidBody.velocity = new Vector2(Game.Instance.scrollSpeed, 0);
        }

        if (Game.Instance.gameOver)
        {
            rigidBody.velocity = Vector2.zero;
        }
    }
}
