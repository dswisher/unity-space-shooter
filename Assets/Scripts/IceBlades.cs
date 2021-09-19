using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance
public class IceBlades : Enemy
{
    protected override void Juke(float delta)
    {
        transform.position = InitialPosition + new Vector3(0, delta, 0);
    }
}
