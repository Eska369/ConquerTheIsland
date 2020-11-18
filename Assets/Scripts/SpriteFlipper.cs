using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlipper : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    public Transform player;


    private void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        
        if (player.transform.position.x > mySpriteRenderer.transform.position.x)
        {       
                // flip the sprite
                mySpriteRenderer.flipX = true;
        }
        else
        {
            mySpriteRenderer.flipX = false;
        }
    }
}
