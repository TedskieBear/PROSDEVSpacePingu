using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X22_MainScreen : View {

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

    public void DisplayTestDialog(){
		Debug.Log (("Test"));


        
        //Display a UI using the View handler system
        //LoadManager.Instance.LoadScene("MainScene");
		
        /*DialogInterface dialog = DialogBuilder.Create(DialogBuilder.DialogType.NOTIFICATION);
		dialog.SetMessage ("Hello");
		dialog.SetOnDismissListener (() => {
			DialogInterface dialog2 = DialogBuilder.Create(DialogBuilder.DialogType.NOTIFICATION);
			dialog2.SetMessage("Another dialog popup!");
		}); */
		//ViewHandler.Instance.Show ("X22_OtherScreen");
	}

    void listener()
    {
        
    }

}

