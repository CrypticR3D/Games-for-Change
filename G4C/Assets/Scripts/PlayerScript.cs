using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    //Raycast
    public float rayRange = 4;

    //Raycasted Objects
    private DoorController raycastedDoor;
    private IInteractable raycastedObject;

    //Tags
    private const string DoorTag = "Door";
    private const string InteractTag = "InteractiveObject";

    //UI
    public UIManager HUDManager;

    void Awake()
    {
        HUDManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        CastRay();
    }

    void CastRay()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, rayRange);
        if (hit)
        {
            GameObject hitObject = hitInfo.transform.gameObject;


            if (Input.GetMouseButtonDown(0))
            {
                if (hitObject.CompareTag(DoorTag))
                {
                    hitObject.GetComponent<DoorController>()?.OpenDoor();
                }

                if (hitObject.CompareTag(InteractTag))
                {
                    hitObject.GetComponent<IInteractable>()?.Interact();
                }
            }
        }

    }
}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class PlayerScript : MonoBehaviour
//{

//    //Raycast
//    public float rayRange = 4;
//    [SerializeField] private LayerMask layerMaskInteract;
//    [SerializeField] private string excludeLayerName = null;

//    //Raycasted Objects
//    private DoorController raycastedDoor;
//    private IInteractable raycastedObject;

//    //Tags
//    private const string DoorTag = "Door";
//    private const string InteractTag = "InteractiveObject";

//    //UI
//    public UIManager HUDManager;
//    [SerializeField] private Image crosshair = null;
//    private bool isCrosshairActive;
//    private bool doOnce;

//    void Awake()
//    {
//        HUDManager = FindObjectOfType<UIManager>();
//    }

//    void Update()
//    {
//        CastRay();
//    }

//    void CastRay()
//    {
//        RaycastHit hitInfo = new RaycastHit();
//        //bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, rayRange);
//        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;
//        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, rayRange, mask))
//        {
//            if (hitInfo.transform != null)
//            {

//                print(hitInfo.transform.name);
//                //GameObject hitObject = hitInfo.transform.gameObject;

//                //Interaction
//                if (hitInfo.collider.CompareTag(DoorTag))
//                {
//                    if (!doOnce)
//                    {
//                        raycastedDoor = hitInfo.transform.gameObject.GetComponent<DoorController>();
//                        CrosshairChange(true);
//                    }

//                    isCrosshairActive = true;
//                    doOnce = true;

//                    if (Input.GetMouseButtonDown(0))
//                    {
//                        raycastedDoor.GetComponent<DoorController>()?.OpenDoor();
//                    }

//                }

//                if (hitInfo.collider.CompareTag(InteractTag))
//                {
//                    if (!doOnce)
//                    {
//                        raycastedObject = hitInfo.collider.gameObject.GetComponent<IInteractable>();
//                        CrosshairChange(true);
//                    }

//                    isCrosshairActive = true;
//                    doOnce = true;

//                    if (Input.GetMouseButtonDown(0))
//                    {
//                        //raycastedObject.GetComponent<IInteractable>()?.Interact();
//                    }

//                }


//            }

//            else
//            {
//                if (isCrosshairActive)
//                {
//                    CrosshairChange(false);
//                    doOnce = false;
//                }
//            }

//        }

//        else
//        {
//            if (isCrosshairActive)
//            {
//                CrosshairChange(false);
//                doOnce = false;
//            }
//        }

//    }

//    void CrosshairChange(bool on)
//    {
//        if (on && !doOnce)
//        {
//            crosshair.color = Color.red;
//        }

//        else
//        {
//            crosshair.color = Color.white;
//            isCrosshairActive = false;
//        }
//    }
//}