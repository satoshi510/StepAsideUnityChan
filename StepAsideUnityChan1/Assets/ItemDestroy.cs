using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    private GameObject Maincamera;

    // Start is called before the first frame update
    void Start()
    {
        this.Maincamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.Maincamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
