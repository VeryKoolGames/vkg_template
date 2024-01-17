using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayBeforeSound : MonoBehaviour
{
    public GameObject Son;
    public float waitingTime;


    void Start()
    {
        StartCoroutine(WaitForSound());
        
    }

    IEnumerator WaitForSound()
    {
        yield return new WaitForSeconds(waitingTime);
        Instantiate(Son, new Vector3(0, 0, 0), Quaternion.identity);
    }

    
}
