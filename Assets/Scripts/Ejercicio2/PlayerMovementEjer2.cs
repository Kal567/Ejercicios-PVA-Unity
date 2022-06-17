using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEjer2 : MonoBehaviour
{
    Vector3 _deltaPos = new Vector3();
    Vector3 _movementSpeed = new Vector3(10,10);
    const float MIN_X = -10f, MAX_X = 10f, MIN_Y = -4.18f, MAX_Y = -4.18f;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
       {
           GameObject ball = Instantiate(projectile, transform.position, 
                                                     transform.rotation);
       }

        _deltaPos.x = Input.GetAxis("Horizontal") * _movementSpeed.x;
        _deltaPos.y = Input.GetAxis("Vertical") * _movementSpeed.y;
        _deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_X, MAX_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_Y, MAX_Y),
            gameObject.transform.position.z
        );
    }
}
