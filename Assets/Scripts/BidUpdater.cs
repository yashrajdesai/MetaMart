using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BidUpdater : MonoBehaviour
{

    private TextMeshProUGUI textMesh;
    private int bid;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        bid = 30;
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = bid.ToString() + "ETH";
        // bid++;
    }

    public void UpdateBid(string userBid){
        bid = Convert.ToInt16(userBid);;
    }
}
