using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCube : MonoBehaviour

{
    public GameObject cube;
    private Vector3 _offset = new Vector3(0, 20, -100);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cube.transform.position + _offset;
    }
}
