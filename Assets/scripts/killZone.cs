using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Destroy everything that enters the trigger
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
        other.gameObject.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
    }
}
