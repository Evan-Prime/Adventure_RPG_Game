using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;

    public virtual void Hit() { }

    public void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Sword>() != null)
        {

        }
    }
}
