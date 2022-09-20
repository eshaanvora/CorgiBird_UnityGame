using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTools : MonoBehaviour
{
    public Camera Camera;

    public Vector3 ConstrainToScreen(SpriteRenderer spriteRenderer)
    {
        Vector3 screenPosition = Camera.WorldToScreenPoint(spriteRenderer.transform.position);

        if (SpriteRight(spriteRenderer) > Screen.width)
            screenPosition.x = Screen.width - SpriteHalfWidth(spriteRenderer);

        if (SpriteLeft(spriteRenderer) < 0)
            screenPosition.x = SpriteHalfWidth(spriteRenderer);

        if (SpriteTop(spriteRenderer) > Screen.height)
            screenPosition.y = Screen.height - SpriteHalfHeight(spriteRenderer);

        if (SpriteBottom(spriteRenderer) < 0)
            screenPosition.y = SpriteHalfHeight(spriteRenderer);

        return Camera.ScreenToWorldPoint(screenPosition);
    }

    private float SpriteRight(SpriteRenderer spriteRenderer)
    {
        Vector3 screenPosition = Camera.WorldToScreenPoint(spriteRenderer.transform.position);
        return screenPosition.x + SpriteHalfWidth(spriteRenderer);
    }

    private float SpriteLeft(SpriteRenderer spriteRenderer)
    {
        Vector3 screenPosition = Camera.WorldToScreenPoint(spriteRenderer.transform.position);
        return screenPosition.x - SpriteHalfWidth(spriteRenderer);
    }

    private float SpriteTop(SpriteRenderer spriteRenderer)
    {
        Vector3 screenPosition = Camera.WorldToScreenPoint(spriteRenderer.transform.position);
        return screenPosition.y + SpriteHalfHeight(spriteRenderer);
    }

    private float SpriteBottom(SpriteRenderer spriteRenderer)
    {
        Vector3 screenPosition = Camera.WorldToScreenPoint(spriteRenderer.transform.position);
        return screenPosition.y - SpriteHalfHeight(spriteRenderer);
    }

    private float SpriteHalfWidth(SpriteRenderer spriteRenderer)
    {
        return spriteRenderer.sprite.rect.width / 4;
    }

    private float SpriteHalfHeight(SpriteRenderer spriteRenderer)
    {
        return spriteRenderer.sprite.rect.height / 4;
    }








}
