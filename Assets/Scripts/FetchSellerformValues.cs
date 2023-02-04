using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FetchSellerformValues : MonoBehaviour
{
    // Start is called before the first frame update
    // public string bid;
    // public GameObject inputfield;
    // public GameObject textDisplay;
    public TMP_InputField productName_text;
    public TMP_InputField description_text;
    public TMP_InputField basePrice_text;
    public TMP_InputField startingBid_text;
    public TMP_InputField auctionStartTime_text;
    public TMP_InputField auctionEndTime_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetData()
    {
        // bid = inputfield.GetComponent<Text>().text;
        Debug.Log(productName_text.text);
        Debug.Log(description_text.text);
        Debug.Log(basePrice_text.text);
        Debug.Log(startingBid_text.text);
        Debug.Log(auctionStartTime_text.text);
        Debug.Log(auctionEndTime_text.text);
        // FindObjectOfType<BidUpdater>().UpdateBid(bid.text);
    }
}
