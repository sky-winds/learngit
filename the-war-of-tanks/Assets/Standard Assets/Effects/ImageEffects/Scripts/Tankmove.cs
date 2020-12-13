using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankmove : MonoBehaviour
{
    public float speed = 5;
    public float angularspeed = 3;
    private Rigidbody rigid;
    
    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Verticalplayer");
        float h = Input.GetAxisRaw("Horizontalplayer");
        rigid.velocity = transform.forward * v* speed;
        rigid.angularVelocity =transform.up * h * angularspeed;
        
    }
    void Update()
    {
        
    }
}
