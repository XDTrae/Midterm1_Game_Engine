using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float health = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damagedealt)
    {

        health -= damagedealt;
        if (health <= 0)
        {

            Destroy(gameObject);

        }

    }

    private  void HealthScore( other)
    {


        if (other.collider.tag == Player)
        {

            if (health < 50)
            {
                ScoreManager.instance.ChangeScore2(50);

            }

            if (health > 50)
            {
                ScoreManager.instance.ChangeScore2(150);
            }
        }
      

    }



}
