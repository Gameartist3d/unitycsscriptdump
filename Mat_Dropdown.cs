using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Mat_Dropdown : MonoBehaviour {

    public Dropdown mdropdown;
    public GameObject Mycar;
    public Color mcolor;
    MeshRenderer mRender;
    List<string> names = new List<string>() { "Red", "Blue", "Green", "Yellow" };
    int listindex;

    void Start () {
        PopulateList();
	}

    private void Update()
    {
        mRender = GetComponent<MeshRenderer>();
        mRender.material.color = mcolor;
    }

    void PopulateList()
    {
        mdropdown.AddOptions(names);
    }
	
}
