using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    private int score = 0;
    public Sprite Portal1;
    public Sprite Portal2;



    private void OnCollisionTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Beer")
        {
            //score = score + 0.5f;
            score++;
            Destroy(collision.gameObject);
            print("HI");
        }
        print("HI");
    }


    public void Update(){

        SwitchSprites();

    }

    public float GetCurrentScore()
    {
        return score;
    }

    private void SwitchSprites()
    {

        if (SpriteRenderer.sprite == Portal1)
            SpriteRenderer.sprite = Portal2;

        if (SpriteRenderer.sprite == Portal2)
            SpriteRenderer.sprite = Portal1;

    }

}
