
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public GameObject gameObject;
    void OnTriggerEnter(Collider collisionInfo)
    {
        
        if (collisionInfo.name == "FPSController")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

    }
}
