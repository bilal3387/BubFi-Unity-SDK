using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BeatsDetector : MonoBehaviour
{
	public Image image;
	public BubFiAudioVisualizer visualizer;

	
	// Update is called once per frame
	void Update ()
	{
		if (image != null && visualizer != null) {
			Color c = visualizer.color;
			c.r *= 10f;
			c.g *= 10f;
			c.b *= 10f;

			image.color = c;
		} else
			Debug.Log ("image or visualizer NULL");

	}
}
