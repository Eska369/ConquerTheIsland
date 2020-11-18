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
            //mySpriteRenderer.transform.localScale = new Vector3(-1, 1, 1);
            mySpriteRenderer.flipX = true;
        }
        else
        {
            mySpriteRenderer.flipX = false;
        }
    }
}
