using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppFactory : MonoBehaviour {
	public static AppFactory instances;
	public controller c;
	public view v;
	public RendertoViewcommand render;
	public AddGoodscommand add;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			
			///i t wait change
		}
		if (Input.GetKeyDown (KeyCode.S)) {

			//Todo (new Observer ("AddGoodscommand", 2));
		}
	}
	void Awake()
	{instances = this;
	}
	public void	AdjustCommand(string msg,IC i)
	{this.c.AdjustCommand (msg,i);

	}
	void Start () {
		c = new controller ();
		v = new view ();
		render = new RendertoViewcommand ();
		add = new AddGoodscommand ();

	//	Packageview packageview = 
		//THIS IS MORE VIEW BE WRITTER

			AdjustView (new Packageview ());
		AdjustCommand("RendertoViewcommand",render);
		AdjustCommand("AddGoodscommand",add);
	}


	void AdjustView(Vmediator mediator)
	{
		if (mediator != null) {
//			Debug.Log ("xx");
			v.AdjustView (mediator);
		
		}
	}
	public void viewTodo(Observer mediator)
	{
		if (mediator != null) {
			v.viewTodo (mediator);
		}
			
	}
	public void Todo(Observer o)
	{c.Todo (o);


	}
	public void aaaa()
	{
		Todo (new Observer ("AddGoodscommand", 1));

	}

	public void bbb()
	{
		Todo (new Observer ("AddGoodscommand", 2));

	}
}
