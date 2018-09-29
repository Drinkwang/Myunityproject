using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class packageComponent : MonoBehaviour {
	public static packageComponent instante;
	public void Awake()
	{instante = this;
	}

	// Use this for initialization
	void Start () {
		showPackage (new List<Packagemodel> ());
		
	}
	public void showPackage(List<Packagemodel> model)
	{
		foreach (Transform t in this.transform)
		{//print (t.name);
			Destroy (t.gameObject);
		}
		foreach(var i in model)
		{GameObject obj=GameObject.Instantiate (Resources.Load<GameObject> ("item"));
			obj.transform.SetParent (this.gameObject.transform);
			obj.GetComponent<item>().Model=i;
		}}
	
	// Update is called once per frame

}
