using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
// using System.Threading.Tasks;
// using Nethereum.Web3;
// using Nethereum.Web3.Accounts;
// using UnityEngine;

public class BidContract : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void auctionBid()
    {
    //     // string chain = "ethereum";
    //     // set network mainnet, testnet
    //     // string network = "goerli";
    //     // smart contract method to call
    //     // string method = "bid";
    //     // // abi in json form
    //     // // address of contract
    //     // string contract = "0x598d7Ba48C368D13408E7a46c8171659e1915297";
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

        string method = "bid";
        // abi in json format
        // address of contract
        string abi = "[ { \"inputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"constructor\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"address\", \"name\": \"approved\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"Approval\", \"type\": \"event\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"address\", \"name\": \"operator\", \"type\": \"address\" }, { \"indexed\": false, \"internalType\": \"bool\", \"name\": \"approved\", \"type\": \"bool\" } ], \"name\": \"ApprovalForAll\", \"type\": \"event\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"approve\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" }, { \"internalType\": \"uint256\", \"name\": \"amount\", \"type\": \"uint256\" }, { \"internalType\": \"address\", \"name\": \"bidder\", \"type\": \"address\" } ], \"name\": \"bid\", \"outputs\": [], \"stateMutability\": \"payable\", \"type\": \"function\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"sender\", \"type\": \"address\" }, { \"indexed\": false, \"internalType\": \"uint256\", \"name\": \"amount\", \"type\": \"uint256\" } ], \"name\": \"Bid\", \"type\": \"event\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"end\", \"outputs\": [], \"stateMutability\": \"payable\", \"type\": \"function\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": false, \"internalType\": \"address\", \"name\": \"winner\", \"type\": \"address\" }, { \"indexed\": false, \"internalType\": \"uint256\", \"name\": \"amount\", \"type\": \"uint256\" } ], \"name\": \"End\", \"type\": \"event\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"previousOwner\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"address\", \"name\": \"newOwner\", \"type\": \"address\" } ], \"name\": \"OwnershipTransferred\", \"type\": \"event\" }, { \"inputs\": [], \"name\": \"renounceOwnership\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"startingBid\", \"type\": \"uint256\" }, { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"string\", \"name\": \"name\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"description\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"image\", \"type\": \"string\" }, { \"internalType\": \"uint256\", \"name\": \"endingOn\", \"type\": \"uint256\" } ], \"name\": \"safeMint\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"payable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"safeTransferFrom\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" }, { \"internalType\": \"bytes\", \"name\": \"data\", \"type\": \"bytes\" } ], \"name\": \"safeTransferFrom\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"operator\", \"type\": \"address\" }, { \"internalType\": \"bool\", \"name\": \"approved\", \"type\": \"bool\" } ], \"name\": \"setApprovalForAll\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"start\", \"outputs\": [], \"stateMutability\": \"payable\", \"type\": \"function\" }, { \"anonymous\": false, \"inputs\": [], \"name\": \"Start\", \"type\": \"event\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"indexed\": true, \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"Transfer\", \"type\": \"event\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"from\", \"type\": \"address\" }, { \"internalType\": \"address\", \"name\": \"to\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"transferFrom\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"newOwner\", \"type\": \"address\" } ], \"name\": \"transferOwnership\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"withdraw\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"anonymous\": false, \"inputs\": [ { \"indexed\": true, \"internalType\": \"address\", \"name\": \"bidder\", \"type\": \"address\" }, { \"indexed\": false, \"internalType\": \"uint256\", \"name\": \"amount\", \"type\": \"uint256\" } ], \"name\": \"Withdraw\", \"type\": \"event\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" } ], \"name\": \"balanceOf\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" }, { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"name\": \"bids\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"name\": \"endAt\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"getApproved\", \"outputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"getTokenMetadata\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" }, { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" }, { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"name\": \"highestBid\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"name\": \"highestBidder\", \"outputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" }, { \"internalType\": \"address\", \"name\": \"operator\", \"type\": \"address\" } ], \"name\": \"isApprovedForAll\", \"outputs\": [ { \"internalType\": \"bool\", \"name\": \"\", \"type\": \"bool\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"name\": \"listNFTs\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"name\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"description\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"image\", \"type\": \"string\" }, { \"internalType\": \"uint256\", \"name\": \"startingBid\", \"type\": \"uint256\" }, { \"internalType\": \"uint256\", \"name\": \"endAt\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"mint_rate\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"name\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"nft\", \"outputs\": [ { \"internalType\": \"contract IERC721\", \"name\": \"\", \"type\": \"address\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"nftList\", \"outputs\": [ { \"components\": [ { \"internalType\": \"string\", \"name\": \"name\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"description\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"image\", \"type\": \"string\" }, { \"internalType\": \"uint256\", \"name\": \"startingBid\", \"type\": \"uint256\" }, { \"internalType\": \"uint256\", \"name\": \"endAt\", \"type\": \"uint256\" } ], \"internalType\": \"struct MyToken.TokenMetadata[]\", \"name\": \"\", \"type\": \"tuple[]\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"owner\", \"outputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"ownerOf\", \"outputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"name\": \"seller\", \"outputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"name\": \"started\", \"outputs\": [ { \"internalType\": \"bool\", \"name\": \"\", \"type\": \"bool\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"bytes4\", \"name\": \"interfaceId\", \"type\": \"bytes4\" } ], \"name\": \"supportsInterface\", \"outputs\": [ { \"internalType\": \"bool\", \"name\": \"\", \"type\": \"bool\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"symbol\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"index\", \"type\": \"uint256\" } ], \"name\": \"tokenByIndex\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"name\": \"tokenMetadata\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"name\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"description\", \"type\": \"string\" }, { \"internalType\": \"string\", \"name\": \"image\", \"type\": \"string\" }, { \"internalType\": \"uint256\", \"name\": \"startingBid\", \"type\": \"uint256\" }, { \"internalType\": \"uint256\", \"name\": \"endAt\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"owner\", \"type\": \"address\" }, { \"internalType\": \"uint256\", \"name\": \"index\", \"type\": \"uint256\" } ], \"name\": \"tokenOfOwnerByIndex\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"uint256\", \"name\": \"tokenId\", \"type\": \"uint256\" } ], \"name\": \"tokenURI\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"totalSupply\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";
        string contract = "0xFe2E64D05651F6B4FC90499EEdF749ae88c10595";
        // array of arguments for contract
        string value = "15000";
        // array of arguments for contract you can also add a nonce here as optional parameter
        string bidder = "0xb4cDf4f2674B81b79BA944b256Dafc7b7885aB0B";
        string tokenId = "0";
        string[] obj = {tokenId, value, bidder};

        // var currentAccount = await GetCurrentAccount();

        // Log the current account to the Unity console
        // Debug.Log("Current account: " + currentAccount);

        // Debug.Log(account);
        // string[] obj = {""};
        string args = JsonConvert.SerializeObject(obj);
        Debug.Log(args);
        // string args = "[]";
        // string args = "[msg.value,msg.sender]";
        // object[] args = new object[] { (uint)12000, to};
        // string args = "[12000,0x7EFb396d9cf6060e089576B394d5c571BCcD4291]";
        // connects to user's browser wallet to call a transaction
        string response = await Web3GL.SendContract(method, abi, contract, args, value, "", "");
        // connects to user's browser wallet to call a transaction
        Debug.Log(response);
        // string response = await EVM.Call(chain, network, contract, abi, value, method, args);
        // display response in game
        print(response);
    }

    // private async Task<string> GetCurrentAccount()
    // {
    //     // Create a Web3 instance using the injected MetaMask provider
    //     var web3 = new Web3(Nethereum.Web3.Web3.ConvertToEtherumClient(Web3.Web3ClientFactory.GetClient()));

    //     // Get the list of available accounts from MetaMask
    //     var accounts = await web3.Eth.Accounts.SendRequestAsync();

    //     // Get the current account from the list
    //     var currentAccount = accounts[0];

    //     return currentAccount;
    // }

}