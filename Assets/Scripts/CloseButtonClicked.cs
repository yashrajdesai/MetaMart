using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButtonClicked : ItemClick
{

    void Start() {
        addToCartButton = GameObject.Find ("add_to_cart");
        closeButton = GameObject.Find ("Close");
        price_label = GameObject.Find ("Price_label");
        price_number = GameObject.Find ("Price_number");
        description = GameObject.Find ("Description");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked() {

        addToCartButton.SetActive(false); 
        closeButton.SetActive(false); 
        price_label.SetActive(false);
        price_number.SetActive(false);
        description.SetActive(false);

        image.enabled = false;
    }
}
