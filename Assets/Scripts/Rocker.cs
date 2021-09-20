using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Rocker : Enemy
{
    protected override void Juke(float delta)
    {
        transform.position = InitialPosition + new Vector3(0, 0, delta);
    }
}
