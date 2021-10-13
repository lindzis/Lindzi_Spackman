using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float yPos;
    [SerializeField]
    [Range(0, 5)]
    float yRange;
    [SerializeField]
    float floatSpeed;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //Code which moves objects up and down on the Y axis
    //Speed at which objects are moved up and down on the Y axis.
    void Update()
    {
        yPos = Mathf.PingPong(Time.time * floatSpeed, 1) * yRange;
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }

}