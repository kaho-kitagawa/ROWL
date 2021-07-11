using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    void Start()
    {
        var CapsulCollider = this.transform.parent.gameObject.AddComponent<CapsuleCollider>();
        CapsulCollider.radius = 1.5f;
        CapsulCollider.height = 1f;
        CapsulCollider.isTrigger = true;
        var doorAction = CapsulCollider.gameObject.AddComponent<SetDoorAction>();
        var Animator = GetComponent<Animator>();
        doorAction.animator = Animator;
    }
}