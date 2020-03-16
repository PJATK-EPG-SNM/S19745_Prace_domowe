using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour { 
public Transform Followplatform;
public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Followplatform.position = new Vector3(Player.position.x, 0, 0);
    }
}
