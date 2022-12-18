using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePlayer : MonoBehaviour
{

    [SerializeField] GameObject IntroCameraObject;

    //Player
    public SC_FPSController PlayerCharacter;

    [SerializeField] GameObject ToDoListObject;
    [SerializeField] GameObject MarkerObject;

    [SerializeField] GameObject BedObject;



    void EnablePlayer()
    {
        IntroCameraObject.gameObject.SetActive(false);
        PlayerCharacter.gameObject.SetActive(true);
        ToDoListObject.gameObject.SetActive(true);
        MarkerObject.gameObject.SetActive(true);
        BedObject.gameObject.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
