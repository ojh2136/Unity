static var gscore : int = 0;

function OnGUI () 
{
//	largeFont = new GUIStyle();
//	largeFont.fontSize = 32;
	GUI.Label (Rect (10, 10, 100, 20), ("Score: " + gscore));
}