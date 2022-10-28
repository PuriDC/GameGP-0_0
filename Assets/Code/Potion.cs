using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    [SerializeField] private int power;
    [SerializeField] private float duration;

    [SerializeField] private Affect affect;

    [SerializeField] private PotionType type;

    private enum PotionType
    {
        Health,
        Stamina,
        Poison,
    }


    private void UsePotion()
    {
        switch (type)
        {
            case PotionType.Health:
                affect.HealthBuff(power, duration);
                break;
            case PotionType.Stamina:
                affect.StaminaBuff(power, duration);
                break;
            case PotionType.Poison:
                affect.HealthBuff(power, duration);
                break;
        }
    }

    private PlayerInput _playerInput;  //playerInput จำเป็นต้อง Enable ก่อนทุกรอบ****  ชื่อ PlayerInput อ้างอิงมาจากชื่อที่ตั้งใน Unity

    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Start()
    {
        _playerInput.Player.Interact.started += _ => UsePotion();
    }
}
