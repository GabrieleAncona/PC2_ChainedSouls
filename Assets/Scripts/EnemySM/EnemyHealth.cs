﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float health;

   public void TakeDamage(float _damage)
    {
        health -= _damage;
        if(health <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
