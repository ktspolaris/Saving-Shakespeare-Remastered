using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelCollsion : MonoBehaviour
{
    
public GameObject FlowerPotWhole;
public GameObject FlowerPotDigged;

public GameObject FlowerPotWholePresent;
public GameObject FlowerPotDiggedPresent;
public  static bool BeDigged = false;


  //void Start()
  // {       FlowerPotWhole = GameObject.Find(flowerpot_whole);
  // FlowerPotDigged = GameObject.Find(flower_digged);
   //FlowerPotWholePresent = GameObject.Find(flowerpot_whole_present);
  // FlowerPotDiggedPresent = GameObject.Find(flowerpot_digged_present);
   //}
void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.name == "flowerpot_whole") {
			FlowerPotWhole.SetActive(false);
            FlowerPotDigged.SetActive(true);
            FlowerPotWholePresent.SetActive(false);
            FlowerPotDiggedPresent.SetActive(true);
            gameObject.SetActive(false);
          BeDigged = true;
			}
		}
	

}
