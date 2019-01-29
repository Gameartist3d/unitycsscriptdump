using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Mat_Dropdown : MonoBehaviour {

    public Dropdown mdropdown;
    public GameObject Mycar;//designates the model who's material is being changed
    public Color mcolor;
    MeshRenderer mRender;
    List<string> names = new List<string>() { "Red", "Blue", "Green", "Yellow" };//list of options for dropdown menu
    int listindex;

    void Start () {
        PopulateList();
	}

    private void Update()
    {
        mRender = GetComponent<MeshRenderer>();
        mRender.material.color = mcolor;
	    //TODO Use index values of names list to change material assigned
    }

    void PopulateList()
    {
        mdropdown.AddOptions(names);
    }
	
}
