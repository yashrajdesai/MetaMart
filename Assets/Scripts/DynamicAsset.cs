using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicAsset : MonoBehaviour
{
    public GameObject tv;
    public bool execute;
    public float sizeX, sizeY, sizeZ;

    private GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(execute){
            SetupScene();
            execute = false;
        }
    }

    public void SetupScene(){
        if(parent != null){
            Destroy(parent);
        }

        parent = new GameObject("Parent");

        // for(int i = 0; i < sizeX; i++){
        //     for(int j = 0; j < sizeZ; j++){
                GameObject go = Instantiate(tv, new Vector3(sizeX, sizeY, sizeZ), Quaternion.identity);
                go.transform.parent = parent.transform;
                go.name = string.Format("Ground : ({0}, {1})", sizeX, sizeZ);

        //     }
        // }
    }
}
