using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellerFormClicked : MonoBehaviour
{
    // public Image image;
    public Image item_backg;

    // public GameObject background;
    // public GameObject closeButton;
    public GameObject sellerDashboard_heading;
    public GameObject productName_label;
    public GameObject productName_text;
    public GameObject description_label;
    public GameObject description_text;
    public GameObject basePrice_label;
    public GameObject basePrice_text;
    public GameObject image_label;
    public GameObject image_button;
    public GameObject startingBid_label;
    public GameObject startingBid_text;
    public GameObject auctionStartTime_label;
    public GameObject auctionStartTime_text;
    public GameObject auctionEndTime_label;
    public GameObject auctionEndTime_text;
    public GameObject submit_button;
    public GameObject closeSellerForm;


    // bool isAddToButtonActive = false;
    // bool isCloseButtonActive = false;
 
    void Start() {
        // Turns the image off.
        // image.enabled = false;
        item_backg.enabled=false;

        sellerDashboard_heading = GameObject.Find ("SellerDashboard_heading");
        productName_label = GameObject.Find ("ProductName_label");
        productName_text = GameObject.Find ("ProductName_text");
        description_label = GameObject.Find ("Description_label");
        description_text = GameObject.Find ("Description_text");
        basePrice_label = GameObject.Find ("BasePrice_label");
        basePrice_text = GameObject.Find ("BasePrice_text");
        image_label = GameObject.Find ("ProductImage_label");
        image_button = GameObject.Find ("ImageButton");
        startingBid_label = GameObject.Find ("StartingBid_label");
        startingBid_text = GameObject.Find ("StartingBid_text");
        auctionStartTime_label = GameObject.Find ("AuctionStartTime_label");
        auctionStartTime_text = GameObject.Find ("AuctionStartTime_text");
        auctionEndTime_label = GameObject.Find ("AuctionEndTime_label");
        auctionEndTime_text = GameObject.Find ("AuctionEndTime_text");
        submit_button = GameObject.Find ("SubmitButton");
        closeSellerForm = GameObject.Find("CloseSellerForm");

        sellerDashboard_heading.SetActive(false);
        productName_label.SetActive(false);
        productName_text.SetActive(false);
        description_label.SetActive(false);
        description_text.SetActive(false);
        basePrice_label.SetActive(false);
        basePrice_text.SetActive(false);
        image_label.SetActive(false);
        image_button.SetActive(false); 
        startingBid_label.SetActive(false);
        startingBid_text.SetActive(false);
        auctionStartTime_label.SetActive(false);
        auctionStartTime_text.SetActive(false);
        auctionEndTime_label.SetActive(false);
        auctionEndTime_text.SetActive(false);
        submit_button.SetActive(false); 
        closeSellerForm.SetActive(false);

    }
 
    public void sellerFormButtonClicked() {
        // Turns the image on if it is off, and off if it is on.
        // image.enabled = true;
        item_backg.enabled=true;
        // isAddToButtonActive = !isAddToButtonActive;
        // isCloseButtonActive = !isCloseButtonActive;
        // Text tempUpgradeTxt = (Text)Instantiate (price_number);
        // tempUpgradeTxt.text="30$";

        sellerDashboard_heading.SetActive(true); 
        productName_label.SetActive(true); 
        productName_text.SetActive(true);
        description_label.SetActive(true);
        description_text.SetActive(true);
        basePrice_label.SetActive(true);
        basePrice_text.SetActive(true);
        image_label.SetActive(true);
        image_button.SetActive(true);
        startingBid_label.SetActive(true);
        startingBid_text.SetActive(true);
        auctionStartTime_label.SetActive(true);
        auctionStartTime_text.SetActive(true);
        auctionEndTime_label.SetActive(true);
        auctionEndTime_text.SetActive(true);
        submit_button.SetActive(true); 
        closeSellerForm.SetActive(true);

    }
}
