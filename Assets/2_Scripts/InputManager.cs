using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) == true) 
        {
            NoteManager.instance.OnInput(KeyCode.A);
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            NoteManager.instance.OnInput(KeyCode.S);
        }

        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            NoteManager.instance.OnInput(KeyCode.D);
        }
    }
}
