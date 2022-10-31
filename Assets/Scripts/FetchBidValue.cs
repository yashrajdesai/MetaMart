using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using TMPro;

public class FetchBidValue : MonoBehaviour
{

    // public string bid;
    // public GameObject inputfield;
    // public GameObject textDisplay;
    public TMP_InputField bid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setBid(string s)
    {
        // bid = inputfield.GetComponent<Text>().text;
        Debug.Log(bid.text);
        FindObjectOfType<BidUpdater>().UpdateBid(bid.text);
    }
}
