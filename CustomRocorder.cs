using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomRocorder : MonoBehaviour {
	public SteamVR_TrackedController vt;
	public BVHBase bvhScript;
	public bool startedRecord =false;
	// Use this for initialization
	void Start () {
		vt.PadClicked += HandlePadGripped;
	}

	// Update is called once per frame
	void Update () {

	}



	private void HandlePadGripped(object sender, ClickedEventArgs e)
	{
		if (!startedRecord) {
			bvhScript.CaptureStart ();
			this.GetComponent<TextMesh>().text = "Recording!!!";
			this.GetComponent<TextMesh> ().color = Color.red;
			startedRecord = true;
		} else {
			bvhScript.CaptureEnd ();
			this.GetComponent<TextMesh>().text = "Record End\nFile saved:" + bvhScript.fileName;
			this.GetComponent<TextMesh> ().color = Color.blue;
			startedRecord = false;
		}
	}
}
