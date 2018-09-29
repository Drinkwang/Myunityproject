using System.Collections;
using System.Collections.Generic;

public class Goodproxy : Baseproxy<Goodsmodel> {

	private static Goodproxy  instance;
	public static Goodproxy instances()
	{
		if (instance == null) {
			instance = new Goodproxy ();

		} 
			return instance;

	}
	// Use this for initialization
	public Goodproxy():base()
	{
		this.addmodeltolist (new Goodsmodel ("xxx", this.getMaxid () + 1));
		this.addmodeltolist (new Goodsmodel ("xxx2", this.getMaxid () + 1));
		this.addmodeltolist (new Goodsmodel ("xxx3", this.getMaxid () + 1));
		this.addmodeltolist (new Goodsmodel ("xxx4", this.getMaxid () + 1));
	}
}
