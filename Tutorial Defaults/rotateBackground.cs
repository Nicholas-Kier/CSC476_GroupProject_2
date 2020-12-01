using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBackground : MonoBehaviour
{
    float speed = 1.17f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
