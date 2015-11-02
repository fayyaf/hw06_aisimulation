using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Update is called once per frame
	public void restart ()
	{
		Application.LoadLevel("scene01");
	}
}
