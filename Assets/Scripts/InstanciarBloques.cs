using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.SceneManagement;

public class InstanciarBloques : MonoBehaviour
{
     public GameObject[] prefabBlock = new GameObject[3];
    void Start()
    {
        System.Random r= new System.Random ();
        //Crear bloques para la primera Escena Lineas
        if(SceneManager.GetActiveScene().name == "BrickEscena_1"){

             for (int i = -10; i <= 10; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(1.5f * i, 1 ,  -2),
                Quaternion.identity);

        for (int i = -10; i <= 10; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(1.5f * i, 1 ,  -4),
                Quaternion.identity);

        for (int i = -10; i <= 10; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(1.5f * i, 1 ,  -6),
                Quaternion.identity);

        for (int i = -10; i <= 10; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(1.5f * i, 1 ,  -8),
                Quaternion.identity);
        }
        //Crear Bloques para la segunda Escena Carita
        if(SceneManager.GetActiveScene().name == "BrickEscena_2"){

             for (int i = 0; i <= 10; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(5-i, 1 ,  -8),
                Quaternion.identity);

            for (int i = 0; i <= 10; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(5-i, 1 ,  8),
                Quaternion.identity);

            for (int i = 0; i <= 10; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(8, 1 ,  5-i),
                Quaternion.identity);

             for (int i = 0; i <= 10; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(-8, 1 ,  5-i),
                Quaternion.identity);

             for (int i = 0; i <= 1; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(7-i, 1 ,  -6-i),
                Quaternion.identity);
            
            for (int i = 0; i <= 1; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(-7+i, 1 ,  -6-i),
                Quaternion.identity);

             for (int i = 0; i <= 1; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(7-i, 1 ,  6+i),
                Quaternion.identity);
            
            for (int i = 0; i <= 1; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(-7+i, 1 ,  6+i),
                Quaternion.identity);

            for (int i = 0; i <= 6; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(3-i, 1 ,  4),
                Quaternion.identity);

            for (int i = 0; i <= 1; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(5-i, 1 ,  2+i),
                Quaternion.identity);

            for (int i = 0; i <= 1; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(-5+i, 1 ,  2+i),
                Quaternion.identity);

            for (int i = 0; i <= 2; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(4-i, 1 ,  -4),
                Quaternion.identity);

            for (int i = 0; i <= 2; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(4-i, 1 ,  -3),
                Quaternion.identity);

            for (int i = 0; i <= 2; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(4-i, 1 ,  -2),
                Quaternion.identity);

            for (int i = 0; i <= 2; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(-4+i, 1 ,  -4),
                Quaternion.identity);

            for (int i = 0; i <= 2; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(-4+i, 1 ,  -3),
                Quaternion.identity);

            for (int i = 0; i <= 2; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                new Vector3(-4+i, 1 ,  -2),
                Quaternion.identity);
        }
          //Crear Bloques para la tercera Escena Barco
        if(SceneManager.GetActiveScene().name == "BrickEscena_3"){

        for (int i = 0; i <= 26; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(13-i , 1 , 0),
                Quaternion.identity);
        
        for (int i = 0; i <= 4; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(12-i , 1 , 1+i),
                Quaternion.identity);

         for (int i = 0; i <= 4; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(-12+i , 1 , 1+i),
                Quaternion.identity);

        for (int i = 0; i <= 14; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(7-i , 1 , 6),
                Quaternion.identity);

        for (int i = 0; i <= 11; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(0 , 1 , -1-i),
                Quaternion.identity);

         for (int i = 0; i <= 5; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(-1-i, 1 , -12+i),
                Quaternion.identity);

        for (int i = 0; i <= 4; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(-5+i, 1 , -6+i),
                Quaternion.identity);
        }
        //Creamos bloqeus para la cuarta escena Corazón
        if(SceneManager.GetActiveScene().name == "BrickEscena_4"){

        for (int i = 0; i <= 11; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(11-i , 1 , i),
                Quaternion.identity);

        for (int i = 1; i <= 11; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(-11+i , 1 , i),
                Quaternion.identity);

        for (int i = 0; i <= 3; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(-11+i , 1 , -i),
                Quaternion.identity);

        for (int i = 0; i <= 3; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(11-i , 1 , -i),
                Quaternion.identity);

        for (int i = 0; i <= 4; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(-3-i , 1 , -4),
                Quaternion.identity);

         for (int i = 0; i <= 4; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(3+i , 1 , -4),
                Quaternion.identity);
        
        for (int i = 0; i <= 2; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(-i , 1 , -1-i),
                Quaternion.identity);

        for (int i = 1; i <= 2; i++)
            Instantiate(prefabBlock[r.Next (0,3)],
                 new Vector3(i , 1 , -1-i),
                Quaternion.identity);   
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
