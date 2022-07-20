using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorEjer4 : MonoBehaviour
{
    Animator currentAnimator;
    float maxRunningSpeed = 15f, maxEWalkingSpeed = 8f, currentSpeed;
    Vector3 _deltaPos = new Vector3();
    Vector3 _movementSpeed = new Vector3(5,5);
    const float MIN_X = 0f, MAX_X = 33f, MIN_Y = 0f, MAX_Y = 33f;
    SpriteRenderer _renderer;
    
    private void Awake()
    {
        currentAnimator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            currentAnimator.SetBool("isAttacking", true);
        }
        else{
            currentAnimator.SetBool("isAttacking", false);
        }

        currentSpeed = Input.GetAxis("Horizontal") * (Input.GetButton("Fire3") ? maxRunningSpeed : maxEWalkingSpeed);
        _deltaPos.x = currentSpeed * Time.deltaTime;
        //print(currentSpeed);
        if(currentSpeed > 0 || currentSpeed < 0){
            currentAnimator.SetBool("isWalking", true);
        } else{
            currentAnimator.SetBool("isWalking", false);
        }

        if(currentSpeed > 14 || currentSpeed < -14){
            currentAnimator.SetBool("isRunning", true);
        } else{
            currentAnimator.SetBool("isRunning", false);
        }

        _renderer.flipX = currentSpeed < 0;        

        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_X, MAX_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_Y, MAX_Y),
            gameObject.transform.position.z
        );
    }
}
