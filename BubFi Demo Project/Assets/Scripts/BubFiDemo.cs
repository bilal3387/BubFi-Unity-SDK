using UnityEngine;
using System.Collections;

public class BubFiDemo : MonoBehaviour {

	public void RED()
	{
		BubFiEffectsController.defaultController ().RED ();
	}
	
	public void GREEN()
	{
		BubFiEffectsController.defaultController ().GREEN ();
	}
	
	public void BLUE()
	{
		BubFiEffectsController.defaultController ().BLUE ();
	}

	public void flash()
	{
		BubFiEffectsController.defaultController ().FLASH (Color.red, 200);
	}
	
	public void gradient()
	{
		Color[] colors = {Color.red, Color.green, Color.blue, Color.cyan, Color.magenta};
		BubFiEffectsController.defaultController ().GRADIENT (colors, 15000);
	}
	
	public void dim()
	{
		BubFiEffectsController.defaultController ().FADEIN(Color.red, 3000);
	}
}
