using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] weapons;

    private int _weaponQuantity;

    private int _activeWeapon = 0;
    private int _lastWeapon;
    void Start()
    {
        _weaponQuantity = weapons.Length;
        _lastWeapon = _activeWeapon;
    }

    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            _lastWeapon = _activeWeapon;

            _activeWeapon++;
            if (_activeWeapon >= _weaponQuantity)
            {
                _activeWeapon = 0;
            }
            
            weapons[_lastWeapon].SetActive(false);
            weapons[_activeWeapon].SetActive(true);
        }

        else if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            _lastWeapon = _activeWeapon;

            _activeWeapon--;
            if(_activeWeapon <= 0) 
            {
                _activeWeapon = _weaponQuantity - 1 ;
            }

            weapons[_lastWeapon].SetActive(false);
            weapons[_activeWeapon].SetActive(true);
        }
    }
}
