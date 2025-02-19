using System.Runtime.Serialization;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ObjectShooter : MonoBehaviour
{
    
    void Start()
    {
       
    }
    public void Shoot(Vector3 speed)
    {

        GetComponent<Rigidbody>().AddForce(speed);
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponentInChildren<ParticleSystem>().Play();

        if (collision.gameObject.tag == "terrain")
        {
            Destroy(gameObject, 1.0f);
        }
       

    }



}
