using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sdfa : MonoBehaviour
{
    float x, y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(-10,10)/10f;
        y = Random.Range(-8, 8) / 10f;

        transform.position = new Vector3(x, y, 0);
    }
}
