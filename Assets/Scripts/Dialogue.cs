using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject window;
    public List<string> dialogues;
    public GameObject indicator;
    public TMP_Text dialogueText;


    public float writingSpeed;
    private int index;
    private int charIndex;
    private bool isStarted;
    private bool waitForNext;
    PlayerControl controls;



    private void Awake()
    {
        ToggleIndicator(false);
        ToggleWindow(false);

        controls = new PlayerControl();
        controls.Enable();
    }

    private void Update()
    {
        if (!isStarted)
        {
            return;
        }
        if(waitForNext && controls.Ground.Interacting.triggered)
        {
            waitForNext = false;
            index++;
            if(index < dialogues.Count)
            {
                GetDialogue(index);
            }
            else
            {
                ToggleIndicator(true);
                EndDialogue();
            }
        }
    }
    private void ToggleWindow(bool show)
    {
        window.SetActive(show);
    }

    public void ToggleIndicator(bool show)
    {
        indicator.SetActive(show);
    }
    public void StartDialogue()
    {
        if (isStarted)
            return;
        isStarted = true;
        ToggleWindow(true);
        ToggleIndicator(false);
        GetDialogue(0);
    }

    private void GetDialogue(int i)
    {
        index = i;
        charIndex = 0;
        dialogueText.text = string.Empty;
        StartCoroutine(Writing());
    }

    public void EndDialogue()
    {
        isStarted = false;
        waitForNext = false;
        StopAllCoroutines();
        ToggleWindow(false);
    }

    IEnumerator Writing()
    {
        yield return new WaitForSeconds(writingSpeed);
        string currentDialogue = dialogues[index];
        dialogueText.text += currentDialogue[charIndex];
        charIndex++;
        if(charIndex < currentDialogue.Length)
        {
            yield return new WaitForSeconds(writingSpeed);
            StartCoroutine(Writing());
        }
        else
        {
            waitForNext = true;
        }
    }
    private void OnEnable() {
        controls.Enable();
    }
    private void OnDisable() {
        controls.Disable();
    }
}
