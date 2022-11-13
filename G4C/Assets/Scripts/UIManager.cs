using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image crosshair = null;
    private bool isCrosshairActive;
    private bool doOnce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InteractIcon()
    {
        crosshair.color = Color.red;
    }

    public void DefaultIcon()
    {
        crosshair.color = Color.white;
    }


}
