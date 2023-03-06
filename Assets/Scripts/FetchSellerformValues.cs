using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Newtonsoft.Json;
// using Firebase.Database;

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
    public TMP_Dropdown dropdown;

    public GameObject tv;
    private int tvNo = 4;
    private float tvPosX = 20.52F, tvPosY = 2.06F, tvPosZ = 4.02F;

    public GameObject fridge;
    private int fridgeNo = 3;
    private float fridgePosX = 12.32F, fridgePosY = -0.38F, fridgePosZ = 3.09F;

    public GameObject oven;
    private int ovenNo = 3;
    private float ovenPosX = 26.793F, ovenPosY = 0.69F, ovenPosZ = -0.8F;

    public GameObject washing_machine;
    private int washing_machineNo = 4;
    private float washing_machinePosX = 24.73F, washing_machinePosY = 1.293382F, washing_machinePosZ = 3.28F;

    public GameObject speaker;
    private int speakerNo = 4;
    private float speakerPosX = 35.2F, speakerPosY = 1.48F, speakerPosZ = -4.150001F;

    
    // private DatabaseReference dbReference;

    // Start is called before the first frame update
    void Start()
    {

    //    dbReference = FirebaseDatabase.DefaultInstance.RootReference;

    //  dbReference=DatabaseReference GetReferenceFromUrl("https://metamart-ce022-default-rtdb.firebaseio.com/");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetData()
    {
        // bid = inputfield.GetComponent<Text>().text;
        // Debug.Log(dbReference); 
        Debug.Log(productName_text.text);
        Debug.Log(description_text.text);
        Debug.Log(basePrice_text.text);
        Debug.Log(startingBid_text.text);
        Debug.Log(auctionStartTime_text.text);
        Debug.Log(auctionEndTime_text.text);
        Debug.Log(dropdown.options[dropdown.value].text);
        
        string ItemName = productName_text.text;
        string ItemChosen = dropdown.options[dropdown.value].text;

        if(ItemChosen == "TV"){
            GameObject newTV = Instantiate(tv, new Vector3(tvPosX, tvPosY, tvPosZ), Quaternion.Euler(0.0f, 90.0f, 0.0f));
            newTV.transform.localScale = new Vector3(2.0f, 1.8951f, 2.281913f);
            GameObject tvParent = GameObject.Find("TVs");
            newTV.transform.SetParent(tvParent.transform);
            newTV.name = "TV" + tvNo.ToString();
        }

        if(ItemChosen == "Fridge"){
            GameObject newFridge = Instantiate(fridge, new Vector3(fridgePosX, fridgePosY, fridgePosZ), Quaternion.Euler(0.0f, 0.0f, 0.0f));
            newFridge.transform.localScale = new Vector3(1.234561f, 2.514076f, 2.957339f);
            GameObject fridgeParent = GameObject.Find("Refrigerators");
            newFridge.transform.SetParent(fridgeParent.transform);
            newFridge.name = "Refrigerator" + fridgeNo.ToString();
        }

        if(ItemChosen == "Oven"){
            GameObject newOven = Instantiate(oven, new Vector3(ovenPosX, ovenPosY, ovenPosZ), Quaternion.Euler(0.0f, 180.0f, 0.0f));
            newOven.transform.localScale = new Vector3(2.8126f, 3.017389f, 3.726974f);
            GameObject ovenParent = GameObject.Find("Microwaves");
            newOven.transform.SetParent(ovenParent.transform);
            newOven.name = "Microwave" + ovenNo.ToString();
        }

        if(ItemChosen == "Washing Machine"){
            GameObject newwashing_machine = Instantiate(washing_machine, new Vector3(washing_machinePosX, washing_machinePosY, washing_machinePosZ), Quaternion.Euler(0.0f, 90.0f, 0.0f));
            newwashing_machine.transform.localScale = new Vector3(1.515879f, 1.917931f, 2.2939f);
            GameObject washing_machineParent = GameObject.Find("Washing_machines");
            newwashing_machine.transform.SetParent(washing_machineParent.transform);
            newwashing_machine.name = "Washing_machine" + washing_machineNo.ToString();
        }

        if(ItemChosen == "Speaker"){
            GameObject newSpeaker = Instantiate(speaker, new Vector3(speakerPosX, speakerPosY, speakerPosZ), Quaternion.Euler(0.0f, -173.085f, 0.0f));
            newSpeaker.transform.localScale = new Vector3(1.2922f, 1.711726f, 1f);
            GameObject speakerParent = GameObject.Find("Speakers");
            newSpeaker.transform.SetParent(speakerParent.transform);
            newSpeaker.name = "Washing_machine" + speakerNo.ToString();
        }
        
        // string json1=JsonUtility.ToJson(productName_text.text);
        // dbReference.Child("items").Child("item1").SetRawJsonValueAsync(json1);
        // auctionBid();
        // FindObjectOfType<BidUpdater>().UpdateBid(bid.text);
    }

    // public async void auctionBid()
    // {
    //     string chain = "polygon";
    //     // set network mainnet, testnet
    //     string network = "testnet";
    //     // smart contract method to call
    //     // string method = "bid";
    //     // // abi in json form
    //     // // address of contract
    //     // string contract = "0x8051ac1647785029e69C43E8A37C0Fc00c557c79";
    //     // // array of arguments for contract
    //     // string value = "30";
    //     // // array of arguments for contract you can also add a nonce here as optional parameter
    //     // string[] obj = {value};
    //     // // string[] obj = {""};
    //     // string args = JsonConvert.SerializeObject(obj);
    //     // // string args = "[]";
    //     // // connects to user's browser wallet to call a transaction
    //     // string response = await Web3GL.SendContract(method, abi, contract, args, "30", "", "");
    //     // // connects to user's browser wallet to call a transaction
    //     // // string response = await EVM.Call(contract, abi, value, method, args);
    //     // // display response in game
    //     // print(response);

    //     string method = "safeMint";
    //     // abi in json format
    //     string abi = "[ { \"inputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"constructor\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"address\", \"name\": \"approved\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"Approval\", \"type\": \"event\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"address\", \"name\": \"operator\", \"type\": \"address\" }, { \"indexed\": false, \"internalType\": \"bool\", \"name\": \"approved\", \"type\": \"bool\" } ], \"name\": \"ApprovalForAll\", \"type\": \"event\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"approve\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" }, { \"internalType\": \"uint256\", \"name\": \"startingBid\", \"type\": \"uint256\" } ], \"name\": \"engAuctionMethod\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"previousOwner\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"address\", \"name\": \"newOwner\", \"type\": \"address\" } ], \"name\": \"OwnershipTransferred\", \"type\": \"event\" }, { \"inputs\": [], \"name\": \"renounceOwnership\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"startingBid\", \"type\": \"uint256\" }, { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"string\", \"name\": \"name\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"description\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"image\", \"type\": \"string\" }, { \"internalType\": \"uint256\", \"name\": \"endAt\", \"type\": \"uint256\" } ], \"name\": \"safeMint\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"payable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"safeTransferFrom\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" }, { \"internalType\": \"bytes\", \"name\": \"data\", \"type\": \"bytes\" } ], \"name\": \"safeTransferFrom\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"operator\", \"type\": \"address\" }, { \"internalType\": \"bool\", \"name\": \"approved\", \"type\": \"bool\" } ], \"name\": \"setApprovalForAll\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"Transfer\", \"type\": \"event\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"transferFrom\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"newOwner\", \"type\": \"address\" } ], \"name\": \"transferOwnership\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" } ], \"name\": \"balanceOf\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"engAuction\", \"outputs\": [ { \"internalType\": \"contract EnglishAuction\", \"name\": \"\", \"type\": \"address\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"getApproved\", \"outputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"getTokenMetadata\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" }, { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" }, { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" }, { \"internalType\": \"address\", \"name\": \"operator\", \"type\": \"address\" } ], \"name\": \"isApprovedForAll\", \"outputs\": [ { \"internalType\": \"bool\", \"name\": \"\", \"type\": \"bool\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"mint_rate\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"name\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"owner\", \"outputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"ownerOf\", \"outputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"bytes4\", \"name\": \"interfaceId\", \"type\": \"bytes4\" } ], \"name\": \"supportsInterface\", \"outputs\": [ { \"internalType\": \"bool\", \"name\": \"\", \"type\": \"bool\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"symbol\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"index\", \"type\": \"uint256\" } ], \"name\": \"tokenByIndex\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"name\": \"tokenMetadata\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"name\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"description\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"image\", \"type\": \"string\" }, { \"internalType\": \"uint256\", \"name\": \"startingBid\", \"type\": \"uint256\" }, { \"internalType\": \"uint256\", \"name\": \"endAt\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"index\", \"type\": \"uint256\" } ], \"name\": \"tokenOfOwnerByIndex\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"tokenURI\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"totalSupply\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";

    //     // address of contract
    //     string contract = "0x768d1ef9D21E4A3586a781EF219eF6D5094382e7";
    //     // array of arguments for contract
    //     string value = "12000";
    //     // array of arguments for contract you can also add a nonce here as optional parameter
    //     string to = "0x7EFb396d9cf6060e089576B394d5c571BCcD4291";
    //     // string[] obj = {basePrice_text.text + "000", to, productName_text.text, description_text.text, "image", auctionEndTime_text.text};
    //     string[] obj = {"14000", "0x7EFb396d9cf6060e089576B394d5c571BCcD4291", "Mobile", "Best Mobile", "image", "5"};

    //     // string[] obj = {""};
    //     string args = JsonConvert.SerializeObject(obj);
    //     Debug.Log(args);
    //     string response = await Web3GL.SendContract(method, abi, contract, args, "0", "", "");
    //     // connects to user's browser wallet to call a transaction

    //     // read token id
    //     string response1 = await EVM.Call(chain, network, contract, abi, method, args);

    //     Debug.Log(response1);
    //     // string response = await EVM.Call(chain, network, contract, abi, value, method, args);
    //     // display response in game
    //     print(response);
    // }
}
