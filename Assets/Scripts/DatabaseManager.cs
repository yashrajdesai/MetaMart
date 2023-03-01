// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Firebase.Database;

// public class DatabaseManager : MonoBehaviour
// {
//     public InputField Name;
//     public InputField Gold;
//     private string userID;
//     private DatabaseReference dbReference;
//     // Start is called before the first frame update
//     void Start()
//     {
//         userID=SystemInfo.deviceUniqueIdentifier;
//         dbReference = FirebaseDatabase.DefaultInstance.RootReference;
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     private void CreateUser()
//     {
//         User newUser=new User(Name.text,int.Parse(Gold.text));
//         string json=JsonUtility.ToJson(newUser);

//         dbReference.Child("users").Child(userID).SetRawJsonValueAsync(json);
//     }
// }
