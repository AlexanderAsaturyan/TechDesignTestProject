using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] sprites;

    private int frame;
    public IEnumerator Animate()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            frame++;
            if (frame >= sprites.Length)
            {
                frame = 0;
            }

            if (frame >= 0 && frame < sprites.Length)
            {
                spriteRenderer.sprite = sprites[frame];
            }
        }
    }
}
