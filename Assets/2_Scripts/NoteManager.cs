using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public static NoteManager instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    public void OnInput(KeyCode keyCode)
    {
        Debug.Log("Keycode = " +  keyCode);
    }
}
