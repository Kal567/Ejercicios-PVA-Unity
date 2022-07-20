using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorEjer4Vertical : MonoBehaviour
{
    Animator currentAnimator;
    float maxRunningSpeed = 15f, maxEWalkingSpeed = 8f, currentSpeed;
    Vector3 _deltaPos = new Vector3();
    Vector3 _movementSpeed = new Vector3(5,5);
    const float MIN_X = 0f, MAX_X = 33f, MIN_Y = 0f, MAX_Y = 33f;
    
    private void Awake()
    {
        currentAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            currentAnimator.SetBool("isAttacking", true);
        }
        else{
            currentAnimator.SetBool("isAttacking", false);
        }

        currentSpeed = Input.GetAxis("Vertical") * (Input.GetButton("Fire3") ? maxRunningSpeed : maxEWalkingSpeed);
        _deltaPos.y = currentSpeed * Time.deltaTime;
        
        if(_deltaPos.y > 0 || _deltaPos.y < 0){
            currentAnimator.SetBool("isWalking", true);
        } else{
            currentAnimator.SetBool("isWalking", false);
        }

        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_X, MAX_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_Y, MAX_Y),
            gameObject.transform.position.z
        );
    }
}
