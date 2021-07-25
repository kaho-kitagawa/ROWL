using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public Dialogue Dialogue;

    private void OnTriggerEnter(Collider other)
    {
        Dialogue.DisplayDialogue("³–ÊŒºŠÖ‚ÌƒJƒM‚ğè‚É“ü‚ê‚½I");
    }
}
