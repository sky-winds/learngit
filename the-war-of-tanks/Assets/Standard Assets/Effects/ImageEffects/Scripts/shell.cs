using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shellexplosion;
    public AudioClip shellexplotionaudio;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collider)
    {
        AudioSource.PlayClipAtPoint(shellexplotionaudio, transform.position);
        GameObject.Instantiate(shellexplosion, transform.position, transform.rotation);
        if(collider.tag == "Tank")
        {
            collider.SendMessage("getattach");
        }
        
        GameObject.Destroy(this.gameObject);
    }
}
