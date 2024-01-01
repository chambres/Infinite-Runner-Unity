using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float xOffset = 0f;
    public float speedofplatforms = -3f;

    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {           
        
        xOffset += -speedofplatforms/3 * Time.deltaTime;
        spriteRenderer.material.mainTextureOffset = new Vector2(xOffset, spriteRenderer.material.mainTextureOffset.y);
        if(Input.GetKeyDown(KeyCode.W))
        {
            InvokeRepeating("restartingSpeed", .5f, .5f);
        }
    }

    void restartingSpeed()
    {
        speedofplatforms -= 1f;

        if (speedofplatforms < -20f)
        {
            speedofplatforms = -20f;
            CancelInvoke("restartingSpeed");
            SceneManager.LoadScene("SampleScene");
        }
    }


}