using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitControllerEjer2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "projectile"){
            Destroy(other.gameObject);
        }
    }
}
