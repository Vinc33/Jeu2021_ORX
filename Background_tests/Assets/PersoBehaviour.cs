using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoBehaviour : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 10;
    public HealthBarBehaviour HealthBar;

    void Start()
    {
        Hitpoints = MaxHitpoints;
        HealthBar.SetHealth(Hitpoints,MaxHitpoints);
    }

    // Update is called once per frame
    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        HealthBar.SetHealth(Hitpoints,MaxHitpoints);

        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
