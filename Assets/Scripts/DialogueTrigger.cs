using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogueScript;
    private bool isDetected;
    PlayerControl controls;

    void Awake()
    {
        controls = new PlayerControl();
        controls.Enable();
    }
    private void Update()
    {
        if (isDetected && controls.Ground.Interacting.triggered)
        {
            dialogueScript.StartDialogue();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isDetected = true;
            dialogueScript.ToggleIndicator(isDetected);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isDetected = false;
            dialogueScript.ToggleIndicator(isDetected);
            dialogueScript.EndDialogue();
        }
    }

    private void OnEnable() {
        controls.Enable();
    }
    private void OnDisable() {
        controls.Disable();
    }
}
