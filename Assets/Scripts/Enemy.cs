using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    // Encapsulation
    [SerializeField]
    protected Vector3 InitialPosition { get; private set; }

    [SerializeField]
    private float phase;

    void Start()
    {
        InitialPosition = transform.position;

        phase = Random.Range(-Mathf.PI, Mathf.PI);
    }


    void Update()
    {
        var delta = Mathf.Sin((2 * Time.time) + phase);

        Juke(delta);
    }


    // Polymorphism
    protected abstract void Juke(float delta);
}
