using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float xOffset = 0f, speed = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {           
        
        xOffset += speed * Time.deltaTime;
        spriteRenderer.material.mainTextureOffset = new Vector2(xOffset, spriteRenderer.material.mainTextureOffset.y);
        
    }
}