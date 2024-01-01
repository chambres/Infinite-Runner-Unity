using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float xOffset = 0f;

    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {           
        
        xOffset += -GameObject.Find("Player").GetComponent<Player>().speedofplatforms/3 * Time.deltaTime;
        spriteRenderer.material.mainTextureOffset = new Vector2(xOffset, spriteRenderer.material.mainTextureOffset.y);
        
    }

    
}