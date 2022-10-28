using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalAnimation : MonoBehaviour
{
    private Animator _anim;
    void Awake()
    {
        _anim = this.gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _anim.SetBool("isWalk", true);
        }

        if(Input.GetKeyUp(KeyCode.A))
        {
            _anim.SetBool("isWalk", false);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            _anim.SetBool("isSit", true);
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            _anim.SetBool("isSit", false);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            _anim.SetBool("isRoll", true);
        }

        if(Input.GetKeyUp(KeyCode.D))
        {
            _anim.SetBool("isRoll", false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _anim.SetBool("Jump", true);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            _anim.SetBool("Jump", false);
        }
    }
}
