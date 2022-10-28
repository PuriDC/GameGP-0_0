using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField, Tooltip("Health of enamy")] private int health;
    [SerializeField, Tooltip("Enemy's Movement Speen")] private float speed;


    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
