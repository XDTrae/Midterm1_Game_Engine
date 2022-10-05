using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EditorManager : MonoBehaviour
{
    public static EditorManager instance;

    public PlayerInput inputAction;

    public Camera mainCam;
    public Camera editorCam;

    public bool editorMode;

    Vector3 mousePos;
    public GameObject prefab1;
    public GameObject prefab2;
    GameObject item;
    public bool instantiated = false;

   

    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }

    // Start is called before the first frame update
    void Awake()
    {
       
    }

    public void EnterEditorMode()
    {
        mainCam.enabled = !mainCam.enabled;
        editorCam.enabled = !editorCam.enabled;
    }

   

    public void DropItem()
    {
        if (editorMode && instantiated)
        {
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Collider>().enabled = true;
            instantiated = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCam.enabled == false && editorCam.enabled == true)
        {
            Time.timeScale = 0;
            editorMode = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1;
            editorMode = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (instantiated)
        {
            mousePos = Mouse.current.position.ReadValue();
            mousePos = new Vector3(mousePos.x, mousePos.y, 40f);

            item.transform.position = editorCam.ScreenToWorldPoint(mousePos);

            
        }

    }
}
