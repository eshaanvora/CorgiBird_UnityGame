using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corgi : DeathEffectObject
{

    public bool isInPlay = true;
    public SpriteRenderer CorgiSpriteRenderer;
    public SpriteTools SpriteTools;
    public Sprite NormalSprite;
    public float CorgiMoveAmount = 1f;
    public bool isAdjustingGravity;
    public bool isMovingUp;

    private Rigidbody2D corgiRigidbody;
    private Quaternion rightRotation;
    private Quaternion leftRotation;
    private Quaternion noRotation;
    private float rotateSpeed = 2f;

    private float gravityAtStartOfJump = 6f;
    private float amountToAdjustGravity = 1.5f;
    private float gravityAtZenthOfJump = 1f;

    public void Awake()
    {
        corgiRigidbody = gameObject.GetComponent<Rigidbody2D>();
        rightRotation = Quaternion.Euler(0, 0, -70);
        leftRotation = Quaternion.Euler(0, 0, 20);
        noRotation = Quaternion.Euler(0, 0, 0);
    }

    public void Start()
    {
        Sounds.Instance.PlayGameStartSound();
        transform.rotation = noRotation;
        this.corgiRigidbody.gravityScale = 0.0f;
    }

    public void FixedUpdate()
    {
        if (isAdjustingGravity)
            AdjustGravity();
    }

    public void Jump()
    {
        Sounds.Instance.PlayHopSound();
        corgiRigidbody.velocity = Vector2.up * CorgiMoveAmount;
        isAdjustingGravity = true;
        isMovingUp = true;
        this.corgiRigidbody.gravityScale = gravityAtStartOfJump;
    }

    private void AdjustGravity()
    {
        if (this.corgiRigidbody.gravityScale >= gravityAtStartOfJump)
        {
            this.corgiRigidbody.gravityScale = gravityAtStartOfJump;
            isAdjustingGravity = false;
            return;
        }

        if (isMovingUp)
        {
            this.corgiRigidbody.gravityScale = this.corgiRigidbody.gravityScale - amountToAdjustGravity;
            if (this.corgiRigidbody.gravityScale <= gravityAtZenthOfJump)
                isMovingUp = false;
        }
        else
        {
            this.corgiRigidbody.gravityScale = this.corgiRigidbody.gravityScale + amountToAdjustGravity;
        }
    }


    public void RotateLeft()
    {
        if (isInPlay)
            transform.rotation = leftRotation;
    }

    public void RotateRight()
    {
        if (isInPlay)
            transform.rotation = Quaternion.Lerp(transform.rotation, rightRotation, rotateSpeed * Time.deltaTime);
    }

    private void ConstrainPosition()
    {
        CorgiSpriteRenderer.transform.position = SpriteTools.ConstrainToScreen(CorgiSpriteRenderer);
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }

    public void Reset()
    {
        gameObject.SetActive(true);
        isInPlay = false;
        corgiRigidbody.isKinematic = true;
        //transform.parent = new Vector3(0f, 01f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Sounds.Instance.PlayHitSound();
        //if (collision.gameObject.tag == "Ground")
        //{
        //   isInPlay = false;
        //}
    }
}