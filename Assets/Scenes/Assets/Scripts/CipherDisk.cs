using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CipherDisk: MonoBehaviour
{
    public GameObject CipherPuzzle;

    void OnMouseDown() {

       CipherPuzzle.SetActive(true);
       
   }
}
