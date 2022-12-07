using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationControl : MonoBehaviour
{
    public Rigidbody theBall;
    public float accelerationMultiplier = 0.5f;
    public float ballGravity = 1.0f;
    public float smoothTime = 0.3f;


    private Vector3 planarAcceleration;
    private Vector3 currentAcceleration;
    private Vector3 velocity;

    private float myRotation;
    void Start()
    {
        
    }

    
    void Update()
    {
        //Restringir la direccion de la aceleracion en el plano
        planarAcceleration = new Vector3(Input.acceleration.x, Input.acceleration.y, 0.0f);

        //Suavizar la direccion de la aceleracion
        currentAcceleration = Vector3.SmoothDamp(currentAcceleration, planarAcceleration, ref velocity, smoothTime);

        //Girar el objeto en la direccion de la la aceleracion
        transform.LookAt((transform.position - planarAcceleration), Vector3.forward);

       
        //Empujar la bola en la direccion del acelerometro

        theBall.AddForce(planarAcceleration * ballGravity);
    }
}
