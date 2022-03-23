using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destory(gameObject);,
        Destory(other.gameObject);
    }
}
