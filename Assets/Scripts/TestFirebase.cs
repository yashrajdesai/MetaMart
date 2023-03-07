using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestFirebase : MonoBehaviour
{
    public TMP_InputField text;

    [DllImport("__Internal")]
    public static extern string GetJSON(string path, string objectName, string callback, string fallback);

    // Start is called before the first frame update
    void Start()
    {
        GetJSON("example", gameObject.name, "OnRequestSuccess", "OnRequestFailed");
    }

    private void OnRequestSuccess(string data){
        text.text = data;
        Debug.Log(data);
    }

    private void OnRequestFailed(string error){
        Debug.Log(error);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
