using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireScript : MonoBehaviour {
    public Transform refillBar;
    public float currentAmount;
    public float reloadSpeed;
    public float multiplyer;
	
	// Update is called once per frame
	void Update () {
		if (currentAmount < 100) {
            currentAmount += reloadSpeed * Time.deltaTime * multiplyer;
        }

        refillBar.GetComponent<Image>().fillAmount = currentAmount / 100;
	}
}
