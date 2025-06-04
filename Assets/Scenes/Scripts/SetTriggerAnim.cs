using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTriggerAnim : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public string TriggerName;

    void start()
    {
        _animator = GetComponent<Animator>();
    }


    public void SetTriggerNow()
    {
        _animator.SetTrigger(TriggerName);
    }
}
