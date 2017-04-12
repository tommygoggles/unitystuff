using UnityEngine;
using System.Collections;

public class TGColComp : TGComp {

	// Use this for initialization
	void Start () {
        init();
	}
	
	// Update is called once per frame
	void Update () {
        update();
    }

    new public static void update()
    {
        foreach (TGComp thecomp in allthecomps)
        {
            Debug.Log(thecomp.gameObject.name);
        }
    }
}
