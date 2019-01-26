using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowKeyCollsion : MonoBehaviour
{
   public GameObject FlowerPotWithKey;
 public GameObject FlowerPotWithKeyPresent;
   public GameObject FlowerPotDigged;
 public GameObject FlowerPotDiggedPresent;

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.name == "flower_digged"&& ShovelCollsion.BeDigged == true) {
			FlowerPotDigged.SetActive(false);
            FlowerPotWithKey.SetActive(true);
            FlowerPotDiggedPresent.SetActive(false);
            FlowerPotWithKeyPresent.SetActive(true);
			}
		}
    }
