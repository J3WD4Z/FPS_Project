using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Health Subtracted,");
        }
        Destroy(this.gameObject);
        Debug.Log("Object should be destroyed.");
    }
}