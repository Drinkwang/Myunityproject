using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGoodscommand : IC {
	PackProxy packproxy=PackProxy.instances();
	Goodproxy goodproxy=Goodproxy.instances();

	// Use this for initialization
	public void Todo(Observer io)
	{//Debug.Log ("as2sa");
		int id = 1;
		Packagemodel model = null;
		if (!int.TryParse (io.body.ToString (), out id)) {
			return;}
		if (packproxy.TryGeGoodtModel (id, out model)) {
			model.count++;
			packproxy.update (id,model);
		} else if (packproxy.isfull ()) {
			return;
		} else 
		{model = packproxy.getback ();
			model.goodid = id;
			
		}
		AppFactory.instances.Todo (new Observer ("RendertoViewcommand"));
//		Debug.Log ("assa");

	}
}
