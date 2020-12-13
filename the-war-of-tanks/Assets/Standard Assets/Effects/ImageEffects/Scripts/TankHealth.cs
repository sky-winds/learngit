using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    public int HP = 100;
    public GameObject tankdistoryexplosion;
    public AudioClip tankexplosionaudio;
    public Slider HPslider;
    private int HPtotal;
    // Start is called before the first frame update
    void Start()
    {
        HPtotal = HP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void getattach()
    {
        if(HP > 0)
        {
            HP -= Random.Range(20,30);
            HPslider.value =(float) HP / HPtotal;
        }
        if(HP<= 0)
        {
            AudioSource.PlayClipAtPoint(tankexplosionaudio,transform.position);
            GameObject.Instantiate(tankdistoryexplosion,transform.position+Vector3.up,transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}
