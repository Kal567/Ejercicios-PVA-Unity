using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    private GameObject speedUp;
    float _initialTime;
    int SpeedPowerUpActive = 5;
    public GameObject PurpleSphere, GreenSphere, OrangeSphere, colorChanger, powerUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > _initialTime + SpeedPowerUpActive){
            modifyAcceleration(new Vector3(2,0,0));
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            _initialTime = Time.time;
           modifyAcceleration(new Vector3(15,0,0));
        }
    }

    private void modifyAcceleration(Vector3 acceleration){
        PurpleSphere.GetComponent<ConstantForce>().force = acceleration;
        GreenSphere.GetComponent<ConstantForce>().force = acceleration;
        OrangeSphere.GetComponent<ConstantForce>().force = acceleration;
        colorChanger.GetComponent<ConstantForce>().force = acceleration;
        powerUp.GetComponent<ConstantForce>().force = acceleration;
        gameObject.GetComponent<ConstantForce>().force = acceleration;
    }




}
