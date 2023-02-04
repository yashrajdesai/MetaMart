using UnityEngine;
using UnityEngine.UI;
 
public class ItemClick : MonoBehaviour {

    // public TextMeshProUGUI my_text;
 
    public Image image;
    // public Image item_backg;

    public GameObject background;
    public GameObject closeButton;
    public GameObject product_name;
    public GameObject description;
    public GameObject price_label;
    public GameObject price_number;
    public GameObject current_bid_label;
    public GameObject current_bid_number;
    public GameObject your_bid_label;
    public GameObject your_bid_inputfield;
    public GameObject addToCartButton;
    public GameObject item_panel;


    // bool isAddToButtonActive = false;
    // bool isCloseButtonActive = false;
 
    void Start() {
        // Turns the image off.
        image.enabled = false;
        // item_backg.enabled=false;

        background = GameObject.Find ("item_background");
        closeButton = GameObject.Find ("Close");
        product_name = GameObject.Find ("Product_Name");
        description = GameObject.Find ("Description");
        price_label = GameObject.Find ("Price_label");
        price_number = GameObject.Find ("Price_number");
        // my_text = price_number.GetComponent<TMPro.TextMeshProUGUI>(); 
        current_bid_label = GameObject.Find ("Current_Bid_label");
        current_bid_number = GameObject.Find ("Current_Bid_number");
        your_bid_label = GameObject.Find ("Your_Bid_Label");
        your_bid_inputfield = GameObject.Find ("Your_Bid_InputField");
        addToCartButton = GameObject.Find ("add_to_cart");
        item_panel=GameObject.Find("item_back_panel");

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

    }
 
    void OnMouseDown() {
        // Turns the image on if it is off, and off if it is on.
        image.enabled = true;
        // item_backg.enabled=true;
        // isAddToButtonActive = !isAddToButtonActive;
        // isCloseButtonActive = !isCloseButtonActive;
        // Text tempUpgradeTxt = (Text)Instantiate (price_number);
        // tempUpgradeTxt.text="30$";

        background.SetActive(true); 
        closeButton.SetActive(true); 
        product_name.SetActive(true);
        description.SetActive(true);
        price_label.SetActive(true);
        price_number.SetActive(true);
        current_bid_label.SetActive(true);
        current_bid_number.SetActive(true);
        your_bid_label.SetActive(true);
        your_bid_inputfield.SetActive(true);
        addToCartButton.SetActive(true); 
        item_panel.SetActive(true);

        // my_text.text = "30$";

    }
}