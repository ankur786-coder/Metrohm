using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float x, y, z;
    Vector3 vect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vect = new Vector3(x, y, z);
        transform.Rotate(vect * Time.deltaTime);
    }
}
