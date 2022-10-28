using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Rigidbody arrowPrefab;
    public Transform muzzle;
    public float chargeLimit;
    public float chargeSpeed;

    private bool _isCharge;
    private float _chargePower;

     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isCharge = true;
        }

        if (_isCharge && _chargePower <= chargeLimit)
        {
            _chargePower += Time.deltaTime * chargeLimit;
        }

        if (_isCharge && Input.GetMouseButtonUp(0))
        {
            Rigidbody arrow = Instantiate(arrowPrefab, muzzle.position, muzzle.rotation) as Rigidbody;
            arrow.AddForce(transform.forward * _chargePower, ForceMode.Impulse);
            _chargePower = 0f;
            _isCharge = false;
        }
    }
}
