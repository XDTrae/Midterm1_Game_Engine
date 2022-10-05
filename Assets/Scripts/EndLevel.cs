using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{

   public  GameObject PlayerC;


    private void Start()
    {
        PlayerC = GameObject.Find("Character_Gun");
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            {
                Destroy(gameObject);
                         Destroy(PlayerC);
            }
        }
    }
}


