using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Affect : MonoBehaviour
{
    [SerializeField] private Stat stat;
    
    [Header("Health Relate Effect")]
    [Header("Stamina Relate Effect")]
    [SerializeField] private float timeBetweenHeal;
    [SerializeField] private float timeBetweenStamina;

    private Coroutine _healthFX;
    private Coroutine _staminaFX;

    private float _healthFXDuration; 
    private bool _healthFXInProgress; 

    private float _staminaFXDuration; 
    private bool _staminaFXInProgress; 


    private void Update()
    {
        if (_healthFXInProgress) _healthFXDuration += Time.deltaTime;
        if (_staminaFXInProgress) _staminaFXDuration += Time.deltaTime;
    }

    public void HealthBuff(int power, float limiter)
    {
        if(_healthFX != null) StopCoroutine(_healthFX);
        _healthFX = StartCoroutine(Adrenaline(limiter, timeBetweenHeal, power));
    }

    public void StaminaBuff(int power, float limiter)
    {
        if(_staminaFX != null) StopCoroutine(_staminaFX);
        _staminaFX = StartCoroutine(Stamina(limiter, timeBetweenStamina, power));
    }

    IEnumerator Adrenaline(float limiter, float timeBetweenFX, int power)
    {
        _healthFXDuration = 0f;
        _healthFXInProgress = true; 

        while (_healthFXDuration <= limiter)
        {
            stat.CalculateHealth(power);
            yield return new WaitForSeconds(timeBetweenFX);
        }
        _healthFX = null;
        _healthFXInProgress = false;
    }

    IEnumerator Stamina(float limiter, float timeBetweenFX, int power)
    {
        _staminaFXDuration = 0f;
        _staminaFXInProgress = true; 

        while (_staminaFXDuration <= limiter)
        {
            stat.CalculateStamina(power);
            yield return new WaitForSeconds(timeBetweenFX);
        }
        _staminaFX = null;
        _staminaFXInProgress = false;
    }
}
