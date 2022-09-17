using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterByPlayer : MonoBehaviour
{
    [SerializeField] private Animator _animator; 
    private void OnTriggerEnter(Collider other)
    {
        _animator.SetTrigger("2");
    }
}
