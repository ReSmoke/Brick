using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Pelota : MonoBehaviour
{
     public AudioSource efectoGolpe;
     public Rigidbody pelota;
     public int factor;
     public ParticleSystem efectoDestruye;
     private Vector3 velocidad;
     private int marcador=0;
     public TextMeshProUGUI score;
     private bool moverPelota=false;
    void Start()
    {
    }

    void Update()
    { 
     if(Input.GetKeyDown("s")){
          moverPelota=true;
          
     }
     if(moverPelota){
         velocidad = new Vector3(-5f, 0f ,-5f);
         velocidad = 20 * velocidad.normalized;
         pelota.velocity=velocidad;
         moverPelota=false;
         }
    }

    private void OnCollisionEnter(Collision colission)
    {
         efectoGolpe.Play();
         if(colission.gameObject.tag == "block"){
          marcador++;
          score.text="Score: "+ marcador;
          efectoDestruye.transform.position=colission.transform.position;
          efectoDestruye.Play();
          velocidad = pelota.velocity;
          velocidad.z += 2.5f * (pelota.velocity.z/Mathf.Abs(pelota.velocity.z));
          velocidad.x += 5f * (pelota.velocity.x/Mathf.Abs(pelota.velocity.x));
          velocidad = 20 * velocidad.normalized;
          pelota.velocity = velocidad;
         }
         if(colission.gameObject.tag == "barraInf"){
          UnityEngine.SceneManagement.SceneManager.LoadScene("BrickEscena_1");
         }
         if(SceneManager.GetActiveScene().name=="BrickEscena_1"){
          if(marcador==84){
               UnityEngine.SceneManagement.SceneManager.LoadScene("BrickEscena_2");
          }
         }
         else if(SceneManager.GetActiveScene().name=="BrickEscena_2"){
          if(marcador==81){
               UnityEngine.SceneManagement.SceneManager.LoadScene("BrickEscena_3");
          }
         }
         else if(SceneManager.GetActiveScene().name=="BrickEscena_3"){
          if(marcador==75){
               UnityEngine.SceneManagement.SceneManager.LoadScene("BrickEscena_4");
          }
         }
    }
}
