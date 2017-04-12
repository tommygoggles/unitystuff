using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class TGComp : MonoBehaviour
{
    protected static List<TGComp> allthecomps = new List<TGComp>();

    public static void update()
    {
        foreach (TGComp thecomp in allthecomps)
        {
            Debug.Log(thecomp.gameObject.name);
        }
    }


    void Start()//inherrited ones can't call base.start due to private..
    {
        init();
    }

    protected void init () {
        //add to the compmaster
        allthecomps.Add(this);

    }


    void OnDestroy()//inherrited ones can't call base.
    {
        remove();
    }

    protected void remove()
    {
        allthecomps.Remove(this);
    }
}
