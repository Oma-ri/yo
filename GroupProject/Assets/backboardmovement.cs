using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backboardmovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
