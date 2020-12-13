using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protectenemy : MonoBehaviour
{
    public float enemynumber=10;
    public GameObject enemytank;
    
    
// Start is called before the first frame update
void Start()
    {
        

        for (int i=1;i<=enemynumber ; i++)
        {
            Random random1 = new Random();
            Random random2 = new Random();
            
            GameObject.Instantiate(enemytank,transform.position , transform.rotation);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
