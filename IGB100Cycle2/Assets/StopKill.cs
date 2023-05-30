using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopKill : MonoBehaviour
{
    public GameObject kill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(kill);
        }
    }
}
