using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButtonClicked : ItemClick
{

    void Start() {
        addToCartButton = GameObject.Find ("add_to_cart");
        closeButton = GameObject.Find ("Close");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked() {

        addToCartButton.SetActive(false); 
        closeButton.SetActive(false); 

        image.enabled = false;
    }
}
