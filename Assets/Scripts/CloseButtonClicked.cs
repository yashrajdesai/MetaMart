using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButtonClicked : ItemClick
{

    void Start() {
        background = GameObject.Find ("item_background");
        closeButton = GameObject.Find ("Close");
        product_name = GameObject.Find ("Product_Name");
        description = GameObject.Find ("Description");
        price_label = GameObject.Find ("Price_label");
        price_number = GameObject.Find ("Price_number");
        current_bid_label = GameObject.Find ("Current_Bid_label");
        current_bid_number = GameObject.Find ("Current_Bid_number");
        your_bid_label = GameObject.Find ("Your_Bid_Label");
        your_bid_inputfield = GameObject.Find ("Your_Bid_InputField");
        addToCartButton = GameObject.Find ("add_to_cart");
        item_panel=GameObject.Find("item_back_panel");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked() {

        background.SetActive(false); 
        closeButton.SetActive(false); 
        product_name.SetActive(false);
        description.SetActive(false);
        price_label.SetActive(false);
        price_number.SetActive(false);
        current_bid_label.SetActive(false);
        current_bid_number.SetActive(false);
        your_bid_label.SetActive(false);
        your_bid_inputfield.SetActive(false);
        addToCartButton.SetActive(false); 
        item_panel.SetActive(false);

        image.enabled = false;
    }
}
