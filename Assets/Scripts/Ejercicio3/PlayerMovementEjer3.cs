using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEjer3 : MonoBehaviour
{
    Vector3 _deltaPos = new Vector3();
    Vector3 _movementSpeed = new Vector3(10,10);
    const float MIN_X = 4f, MAX_X = 10f, MIN_Y = -4f, MAX_Y = 4f;

    public float forceValue = 5;

    public Material greenMaterial;
    public Material purpleMaterial;
    public Material orangeMaterial;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer> ().material = greenMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        _deltaPos.x = (Input.GetAxis("Horizontal") * _movementSpeed.x);
        _deltaPos.y = Input.GetAxis("Vertical") * _movementSpeed.y;
        _deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_X, MAX_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_Y, MAX_Y),
            gameObject.transform.position.z
        );
    }

    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag == "enemy"){
            if (other.gameObject.GetComponent<Renderer>().material.name == gameObject.GetComponent<Renderer>().material.name){
                GlobalScriptsEjer3.currentScore++;
            } else
            {
                GlobalScriptsEjer3.currentLife--;
            }
        }

        if(other.gameObject.tag == "colorChanger"){
            switch (Random.Range(0,3))
            {
                case 0:
                    gameObject.GetComponent<MeshRenderer> ().material = purpleMaterial;
                    break;
                case 1:
                    gameObject.GetComponent<MeshRenderer> ().material = orangeMaterial;
                    break;
                default:
                    gameObject.GetComponent<MeshRenderer> ().material = greenMaterial;
                    break;
            }
        }

        if(other.gameObject.tag == "powerUp"){
            GlobalScriptsEjer3.currentLife++;
        }

        Destroy(other.gameObject);
    }
}
