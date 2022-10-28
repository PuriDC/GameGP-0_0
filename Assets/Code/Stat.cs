using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    [SerializeField] private HP_Bar hpBar;
    [SerializeField] private MP_Bar mpBar;
    [SerializeField] private int maxHealth;
    [SerializeField] private int maxStamina;
    private int _health;
    private int _stamina;

    private void Awake()
    {
        _health = maxHealth;
        _stamina = maxStamina;
    }
    
    void Start()
    {
        hpBar.SetUp(maxHealth);
        mpBar.SetUp(maxStamina);
    }

    public void CalculateHealth(int value)
    {
        _health += value;


        if(_health >= maxHealth)
        {
            _health = maxHealth;
        }
        
        else if(_health <= 0)
        {
            _health = 0;
        }

        hpBar.Setvalue(_health);


        #region Debug
        
        [ContextMenu("Health/Set Health to One")]
        void SetHealthToOne()
        {
            _health =1;

            hpBar.Setvalue(_health);
        }

        #endregion
    }


    public void CalculateStamina(int value)
    {
        _stamina += value;


        if(_stamina >= maxStamina)
        {
            _stamina = maxStamina;
        }
        
        else if(_stamina <= 0)
        {
            _stamina = 0;
        }
        
        mpBar.Setvalue(_stamina);


        #region Debug
        
        [ContextMenu("Health/Set Stamina to One")]
        void SetStaminaToOne()
        {
            _stamina =1;
            
            mpBar.Setvalue(_stamina);
        }

        #endregion
    }
}
