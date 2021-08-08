using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool IsGirlOnly = true;
    public SetDoorAction.DoorOpenRestriction DoorOpenRestriction;

    void Start()
    {
        var CapsulCollider = this.transform.parent.gameObject.AddComponent<CapsuleCollider>();
        CapsulCollider.radius = 1.5f;
        CapsulCollider.height = 1f;
        CapsulCollider.isTrigger = true;
        var doorAction = CapsulCollider.gameObject.AddComponent<SetDoorAction>();
        doorAction.ThisDoorOpenRestriction = DoorOpenRestriction;
    
        var Animator = GetComponent<Animator>();
        doorAction.animator = Animator;
    }
}