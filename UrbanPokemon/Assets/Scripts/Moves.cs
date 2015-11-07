using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Moves : MonoBehaviour {

	Dictionary<string, SimpleMove> moves = new Dictionary<string, SimpleMove> ();
	
	public Moves () {
		moves.Add ("scratch", new SimpleMove ("scratch", 4, 100, "normal", "none", 0));
		moves.Add ("cut", new SimpleMove ("cut", 5, 95, "normal", "none", 0));
		moves.Add ("constrict", new SimpleMove ("constrict", 2, 85, "normal", "none", 0));
		moves.Add ("stomp", new SimpleMove ("stomp", 7, 80, "normal", "none", 0));
		moves.Add ("headbutt", new SimpleMove ("headbutt", 70, 100, "normal", "none", 0));
		moves.Add ("gore", new SimpleMove ("gore", 7, 100, "normal", "none", 0));
		moves.Add ("tackle", new SimpleMove ("tackle", 5, 100, "normal", "none", 0));
		moves.Add ("trash", new SimpleMove ("thrash", 12, 100, "normal", "none", 0));
		moves.Add ("hamstring", new SimpleMove ("scratch", 4, 100, "normal", "speed", 5));
		moves.Add ("spinalCrush", new SimpleMove ("spinalCrush", 8, 20, "normal", "attack", 8));
		moves.Add ("splash", new SimpleMove ("splash", 0, 100, "normal", "none", 0));
		moves.Add ("swipe", new SimpleMove ("swipe", 2, 80, "normal", "none", 0));
		moves.Add ("bite", new SimpleMove ("bite", 6, 90, "normal", "none", 0));
		moves.Add ("flail", new SimpleMove ("flail", 1, 50, "normal", "none", 0));
		moves.Add ("peck", new SimpleMove ("peck", 4, 100, "normal", "none", 0));
		moves.Add ("batter", new SimpleMove ("batter", 5, 70, "normal", "none", 0));
	}
}