using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GameObject.Find("Player").GetComponent<Player>().speedofplatforms, 0f);
        //transform.Translate(-3f * Time.deltaTime, 0, 0);
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == "end"){
            Destroy(gameObject);
        }
    }
}
