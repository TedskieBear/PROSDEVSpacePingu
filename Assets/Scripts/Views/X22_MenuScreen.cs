using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X22_MenuScreen : View {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisplayTestDialog(){
		Debug.Log (("Test"));

        //Display a UI using the View handler system
        LoadManager.Instance.LoadScene("MainScene");
		/* DialogInterface dialog = DialogBuilder.Create(DialogBuilder.DialogType.NOTIFICATION);
		dialog.SetMessage ("Hello");
		dialog.SetOnDismissListener (() => {
			DialogInterface dialog2 = DialogBuilder.Create(DialogBuilder.DialogType.NOTIFICATION);
			dialog2.SetMessage("Another dialog popup!");
		}); */
		//ViewHandler.Instance.Show ("X22_OtherScreen");
	}

    public void load3DScene()
    {
        LoadManager.Instance.LoadScene("ARTest");
    }

    public void loadTrackingScene()
    {
        LoadManager.Instance.LoadScene("ExtendedTrackingScene");
    }
}

