using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnim;

    public bool doorOpen = false;
    public bool doorLocked = false;

    [SerializeField] private string openAnimationName = "DoorOpen";
    [SerializeField] private string closeAnimationName = "DoorClose";

    [SerializeField] private int waitTimer = 1;
    [SerializeField] private bool pauseInteraction = false;


    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    private IEnumerator PauseDoorInteraction()
    {
        pauseInteraction = true;
        yield return new WaitForSeconds(waitTimer);
        pauseInteraction = false;
    }
    public void OpenDoor()
    {
        if (!doorOpen && !doorLocked && !pauseInteraction)
        {
            //SoundEffectManager.GlobalSFXManager.PlaySFX(OpenSound);
            doorAnim.Play(openAnimationName, 0, 0.0f);
            doorOpen = true;
            StartCoroutine(PauseDoorInteraction());
        }

        else if (doorOpen && !pauseInteraction)
        {
            //SoundEffectManager.GlobalSFXManager.PlaySFX(OpenSound);
            doorAnim.Play(closeAnimationName, 0, 0.0f);
            doorOpen = false;
            StartCoroutine(PauseDoorInteraction());
        }
    }
}
