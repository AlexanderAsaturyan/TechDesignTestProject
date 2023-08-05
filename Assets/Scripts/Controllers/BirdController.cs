using System.Collections;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] sprites;

    private WaitForSeconds delay = new WaitForSeconds(0.1f); 

    private int frame;
    public IEnumerator Animate()
    {
        while (true)
        {
            yield return delay;
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
