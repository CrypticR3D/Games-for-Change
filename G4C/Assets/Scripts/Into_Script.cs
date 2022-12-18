using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Into_Script : MonoBehaviour
{
    public bool IsOnIntro;

    [SerializeField] GameObject ToDoListObject;
    [SerializeField] GameObject MarkerObject;

    [SerializeField] GameObject IntroCameraObject;

    //Player
    public SC_FPSController PlayerCharacter;
    
    public Animator IntroAnim;
    [SerializeField] private string IntroAnimationName = "IntroAnimation";

    private void Awake()
    {
        PlayerCharacter = FindObjectOfType<SC_FPSController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        IsOnIntro = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOnIntro)
        {
            IntroAnim.Play(IntroAnimationName, 0, 0f);
        }
    }


}
