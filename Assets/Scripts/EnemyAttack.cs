using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour {

    public static float Puntos;


    private void start ()
    {
        Puntos = 0;
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
         
            SceneManager.LoadScene("Derrota");
        }
        else if(other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Puntos += 1;
        }

        if (Puntos == 4)
        {
            SceneManager.LoadScene("Victoria");
        }

    }

}
