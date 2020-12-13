using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followtank : MonoBehaviour
{
    public Transform tank;
    private Vector3 offset;
    private Camera maincamera;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - tank.position;
        maincamera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = tank.position + offset;
        
    }
}
