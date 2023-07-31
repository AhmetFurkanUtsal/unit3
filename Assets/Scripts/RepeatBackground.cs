using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        //başlangıç noktası arkaplanımızın mevcut konumu

        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        // arkaplanımıza box col. ekledik. bunun x inin tam yarısı için 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPos.x -repeatWidth)
            // arkaplanın x i başlangıç noktasından  ileri gidince 
        {
            transform.position = startPos;

        }
    }
}
