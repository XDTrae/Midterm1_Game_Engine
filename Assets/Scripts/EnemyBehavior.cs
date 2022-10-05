using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public HealthScript EnemyHealth;
    public GameObject PlayerMarker = null;
    public float walkSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        if ( PlayerMarker == null)
        {
            PlayerMarker = GameObject.Find("Character_Gun");
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed, Space.Self);
        transform.LookAt(PlayerMarker.transform);

     }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            {
                other.collider.GetComponent<PlayerController>().PlayerHealth.TakeDamage(100);
            }
        }
    }



}
