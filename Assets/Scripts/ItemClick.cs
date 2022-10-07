using UnityEngine;
using UnityEngine.UI;
 
public class ItemClick : MonoBehaviour {
 
    public Image image;
    public GameObject addToCartButton;
    public GameObject closeButton;
    public GameObject price_label;
    public GameObject price_number;
    public GameObject description;

    // bool isAddToButtonActive = false;
    // bool isCloseButtonActive = false;
 
    void Start() {
        // Turns the image off.
        image.enabled = false;

        addToCartButton = GameObject.Find ("add_to_cart");
        closeButton = GameObject.Find ("Close");
        price_label = GameObject.Find ("Price_label");
        price_number = GameObject.Find ("Price_number");
        description = GameObject.Find ("Description");
        addToCartButton.SetActive(false); 
        closeButton.SetActive(false); 
        price_label.SetActive(false);
        price_number.SetActive(false);
        description.SetActive(false);
    }
 
    void OnMouseDown() {
        // Turns the image on if it is off, and off if it is on.
        image.enabled = true;

        // isAddToButtonActive = !isAddToButtonActive;
        // isCloseButtonActive = !isCloseButtonActive;
        // price_number.text="30$";
        addToCartButton.SetActive(true); 
        closeButton.SetActive(true); 
        price_label.SetActive(true);
        price_number.SetActive(true);
        description.SetActive(true);
    }
}