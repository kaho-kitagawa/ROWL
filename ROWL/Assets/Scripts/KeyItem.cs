using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public Dialogue Dialogue;

    private void OnTriggerEnter(Collider other)
    {
        Dialogue.DisplayDialogue("正面玄関のカギを手に入れた！");
    }
}
