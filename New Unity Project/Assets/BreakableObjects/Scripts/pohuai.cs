using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohuai : MonoBehaviour
{
    public GameObject pohuaiVersion;
    
    void OnMouseDown()
    {
        Instantiate(pohuaiVersion, transform.position, transform.rotation);
        Destroy(gameObject);
        print("click");
    }

}
