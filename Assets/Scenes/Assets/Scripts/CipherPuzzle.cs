using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CipherPuzzle : MonoBehaviour
{
public GameObject cipher;


public GameObject RightAnswer;
public GameObject WrongAnswer1;
public GameObject WrongAnswer2;
public GameObject WrongAnswer3;
public GameObject Cipherbigpicture;

public GameObject Locker;

public static bool ShowLocker = false;
     void OnTriggerEnter2D(Collider2D coll) {
         if (coll.gameObject.name == "QDIFGZQ")
         
         {
             Cipherbigpicture.SetActive(false);
             cipher.SetActive(false);
             Locker.SetActive(true);
             ShowLocker = true;

         }
         else if (coll.gameObject.name == "IYJGRBN")
         {
             WrongAnswer1.SetActive(false);
         }
        
        else if (coll.gameObject.name == "RTYHNBV")
         {
             WrongAnswer2.SetActive(false);
         }
else 
         {
             WrongAnswer3.SetActive(false);
         }
    }
}
