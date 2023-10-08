using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingTraffic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // moves vechiles towards player (backwards in global environment)
        transform.Translate(Vector3.back * Time.deltaTime * 10);
    }
}
