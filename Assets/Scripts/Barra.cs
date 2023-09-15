using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    public KeyCode teclaLeft;
    public KeyCode teclaRight;
    void Start()
    {   
    }
    void Update()
    {
        if(Input.GetKey(teclaLeft)){
            if(transform.position.x<16){
                transform.Translate(new Vector3(0.2f,0,0));
            }
        }
        if(Input.GetKey(teclaRight)){
            if(transform.position.x>-16){
            transform.Translate(new Vector3(-0.2f,0,0));
            }
        }
        if(Input.GetButton("botonX")){
            if(transform.position.x<16){
                transform.Translate(new Vector3(0.2f,0,0));
            }
        }
        if(Input.GetButton("botonB")){
            if(transform.position.x>-16){
            transform.Translate(new Vector3(-0.2f,0,0));
            }
        }
    }
}

