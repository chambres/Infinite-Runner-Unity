using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    public int c=0;

    public bool b = false;

    private IEnumerator coroutine;


    void Start()
    {
        coroutine =  DestroyGems();
        StartCoroutine(coroutine);
    }

     private IEnumerator DestroyGems()
    {
        while(true){
      Spawn();
      WaitForSeconds wait = new WaitForSeconds( func(GameObject.Find("Player").GetComponent<Player>().speedofplatforms) ) ;
      //Debug.Log(func(GameObject.Find("Player").GetComponent<Player>().speedofplatforms));
      yield return wait;
        }
    }

    public void Stop(){
        StopCoroutine(coroutine);
    }
    

    float func(float x){
        if(b){
            return .5f;
        }
        else{
            return .1236f * x + 2.94f; 
        }
       
    }

    void Spawn(){
        c++;
        GameObject tmp = Instantiate(myPrefab, new Vector3(19.4f, Random.Range(-2f, 2f), 0), Quaternion.identity);
        tmp.name = "platform" + c;        
    }
}
