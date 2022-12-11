using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaky : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Shake(1f, 10f));
    }

    public IEnumerator Shake(float duration, float magnitude){
        Vector3 originalPos = new Vector3(transform.position.x , transform.position.y, transform.position.z);
        float elapsedTime = 0f;
        while(elapsedTime<duration){
            float xOff = Random.Range(-.05f, .05f) * magnitude;
            float yOff = Random.Range(-.05f, .05f) * magnitude;

            transform.localPosition = new Vector3(xOff, 0.00000008940697f+yOff, -10);
            elapsedTime += Time.deltaTime;

            yield return null;
        }
        transform.localPosition = originalPos;
    }
}
