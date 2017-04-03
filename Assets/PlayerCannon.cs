using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCannon : MonoBehaviour {
    public GameObject cannonballPrefab;
    public float enemyDmg = 25f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var instance = Instantiate(cannonballPrefab, transform.position, transform.rotation);
            var rigidbody = instance.GetComponent<Rigidbody>();
            rigidbody.AddForce(transform.forward * 2000);

            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);

            

            if (Physics.Raycast(ray, out hit, 100f ))
            {
                if (hit.transform.tag == "Enemy")
                {
                    hit.transform.GetComponent<EnemyHealth>().RemoveHealth(enemyDmg);
                }
            }


        }
	}
}
