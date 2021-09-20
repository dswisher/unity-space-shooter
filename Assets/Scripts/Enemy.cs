using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    // Encapsulation
    protected Vector3 InitialPosition { get; private set; }

    private float phase;
    private EnemyGun[] guns;
    private float nextShoot;

    [SerializeField]
    private float fireRate;


    void Start()
    {
        // Save the initial position, for juking
        InitialPosition = transform.position;

        // Generate a random phase, so ships move independently
        phase = Random.Range(-Mathf.PI, Mathf.PI);

        // Find all the guns (if any) for this ship
        guns = gameObject.GetComponentsInChildren<EnemyGun>();

        // Shoot the next time we're able
        nextShoot = fireRate;

        Debug.Log($"Fire rate: {fireRate}, gun count: {guns.Length}");
    }


    void Update()
    {
        // Move the ship
        var delta = Mathf.Sin((2 * Time.time) + phase);

        Juke(delta);

        // If it is time to fire, do so, otherwise decrement the count.
        if (nextShoot > 0)
        {
            nextShoot -= Time.deltaTime;
        }
        else
	    {
            nextShoot += fireRate;
            foreach (var gun in guns)
            {
                gun.Shoot();
	        }
	    }
    }


    // Polymorphism
    protected abstract void Juke(float delta);
}
