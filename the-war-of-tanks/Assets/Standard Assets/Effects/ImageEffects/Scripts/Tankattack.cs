using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankattack : MonoBehaviour
{
    public GameObject shellPrefad;
    public KeyCode firekey = KeyCode.Keypad1;
    public float shellspeed = 15;
    
    private Transform Fireposition;
    // Start is called before the first frame update
    void Start()
    {
        Fireposition = transform.Find("fireposition");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(firekey))
        {
            
            GameObject go = GameObject.Instantiate(shellPrefad,Fireposition.position,Fireposition.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellspeed;
        };
    }
}
