﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
public class PackProxy : Baseproxy<Packagemodel> {
	private static PackProxy  instance;
	public static PackProxy instances()
	{
		if (instance == null) {
			instance = new PackProxy ();
		
		} 
			return instance;
		
	}
	public PackProxy():base()
	{
		for (int i = 0; i <= 15; i++) {
			this.addmodeltolist (new Packagemodel (i));
		}
		//.

	}
	internal bool isfull()
	{
		int count = this.modellist.Count (a => a.goodid == 0);
		if (count == 0) {
			return true;
		} else
			return false;
	}
	public Packagemodel getback()
	{
		return this.modellist.FirstOrDefault (a=>a.goodid==0);
	}
	public  bool TryGeGoodtModel(int id,out Packagemodel model)
	{model = null;
		model= modellist.FirstOrDefault (a => a.goodid == id);
		if (model != null)
			return true;
		else
			return false;
	}
}
