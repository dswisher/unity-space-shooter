using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BlueBull : Enemy
{
    protected override void Juke(float delta)
    {
        transform.position = InitialPosition + new Vector3(delta, 0, 0);
    }
}
