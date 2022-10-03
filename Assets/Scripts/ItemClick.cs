using UnityEngine;
using UnityEngine.UI;
 
public class ItemClick : MonoBehaviour {
 
    public Image image;
    public GameObject addToCartButton;
    public GameObject closeButton;

    // bool isAddToButtonActive = false;
    // bool isCloseButtonActive = false;
 
    void Start() {
        // Turns the image off.
        image.enabled = false;

        addToCartButton = GameObject.Find ("add_to_cart");
        closeButton = GameObject.Find ("Close");

        addToCartButton.SetActive(false); 
        closeButton.SetActive(false); 
    }
 
    void OnMouseDown() {
        // Turns the image on if it is off, and off if it is on.
        image.enabled = true;

        // isAddToButtonActive = !isAddToButtonActive;
        // isCloseButtonActive = !isCloseButtonActive;

        addToCartButton.SetActive(true); 
        closeButton.SetActive(true); 
    }
}