using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class CSBridge : MonoBehaviour
{

    [SerializeField] Text text;

#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void ShowMessage(string message);

    [DllImport("__Internal")]
    private static extern void CloseWindow();
#endif

    // Start is called before the first frame update
    void Start()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        WebGLInput.captureAllKeyboardInput = false;
#endif
    }
    public void LoadWayneStateMainPage()
    {
        Application.OpenURL("http://Wayne.edu/");
    }

    public void SendBackgroundColorToJS(string message)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
    ShowMessage(message);
#endif
    }

    public void SendCloseMessageToJS()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
    CloseWindow();
#endif
    }

    public void SetText(string message)
    {
        text.text = message;
    }
}
