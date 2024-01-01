using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Camera : MonoBehaviour
{

    public PostProcessVolume volume;
    private Vignette _V;

    public float desired = 0f;
    public float current = 0f;


    
    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings(out _V);
        _V.intensity.value = 0;

        //StartCoroutine(Shake(1f, 10f));
    }

    public void Intensity(float value){
        desired = value;
        InvokeRepeating("inch", .01f, .01f);
    }


    static float t = 0.0f;

    void inch(){
        volume.profile.TryGetSettings(out _V);
        current = _V.intensity.value;

        if(desired > current){
            _V.intensity.value = Mathf.Lerp(current, desired, t);
        }
        else if(desired < current){
            _V.intensity.value = Mathf.Lerp(desired, current, -t);
        }


        t += .5f;


        if (_V.intensity.value == desired)
        {
            CancelInvoke("inch");
        }
        

    }

    

    // Update is called once per frame
    void Update()
    {
        volume.profile.TryGetSettings(out _V);
        current = _V.intensity.value;
    }

    public IEnumerator Shake(float duration, float magnitude){
        Vector3 originalPos = new Vector3(0,0, transform.position.z);
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
