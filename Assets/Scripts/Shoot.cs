using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public string fireButton = "Fire1";
    public float fireForce = 500f;
    public GameObject bullet;
    public float shotInterval;

    float timer = 0f;

    // Update is called once per frame
   void Update()
    {
        

        if (Input.GetButtonDown(fireButton))
        {
            timer = shotInterval;
        }

        if (Input.GetButton(fireButton))
        {
            timer += Time.deltaTime;
            if (timer < shotInterval)
                return;

            timer = 0f;
            Vector3 firePosition = transform.position + transform.forward;
            GameObject b = GameObject.Instantiate(bullet, firePosition, transform.rotation) as GameObject;

            if (b != null)
            {
                Rigidbody rb = b.GetComponent<Rigidbody>();
                Vector3 force = transform.forward * fireForce;
                rb.AddForce(force);
            }
        }
    }
}
