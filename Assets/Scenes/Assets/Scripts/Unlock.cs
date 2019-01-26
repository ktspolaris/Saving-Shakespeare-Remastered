using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public GameObject EndArrow;
    public GameObject Locker;
 void OnMouseDown() {
if( CipherPuzzle.ShowLocker == true)

   {
EndArrow.SetActive(true);
Locker.SetActive(false);
     }
}
}
