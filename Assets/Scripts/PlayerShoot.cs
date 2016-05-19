using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{
    public float shotForce = 500.0f;
    public GameObject Bullet;
    private float RateOfFire;
    

    private float TimerForBullets = 0;
	
	// Update is called once per frame
	void Update ()
    {
        TimerForBullets = RateOfFire;
        TimerForBullets -= Time.fixedDeltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log( "Left Mouse Clicked!" );
            Debug.Log( string.Format( "The Current Bullet Timer is: {0}", TimerForBullets ) );

            if (TimerForBullets > 0)
            {
                return;
            }
            if (TimerForBullets < 0 || TimerForBullets == 0)
            {
                Vector3 firePosition = transform.position + transform.forward;
                GameObject b = GameObject.Instantiate(Bullet, firePosition, transform.rotation) as GameObject;
                Debug.Log("Bullet Instantiated!");
                TimerForBullets = 5.0f;

                if (b != null)
                {
                    Rigidbody rb = b.GetComponent<Rigidbody>();
                    Vector3 force = transform.forward * shotForce;
                    rb.AddForce(force);
                    Debug.Log( "Bullet Fired!" );
                }
            }
        }
    }
    
}
