using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X22_ARScreen : View {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            DialogInterface dialog = DialogBuilder.Create(DialogBuilder.DialogType.CHOICE_DIALOG);
            dialog.SetMessage("Move back to menu?");
            dialog.SetOnConfirmListener(() =>
            {
                LoadManager.Instance.LoadScene("UIScene");
            });
     
        }
    } 
}
