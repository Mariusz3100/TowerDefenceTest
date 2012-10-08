using System;
using UnityEngine;


public class Menu:MonoBehaviour
{
		public Texture2D background;
			
			
		public Menu ()
		{
		}
		
		
		void OnGUI () {
       
    		Rect box=new Rect ((float)(Screen.width*0.75),0,(float)(Screen.width*0.25),(float)Screen.height);
			GUI.Box(box,background);
		
		}
		
		
		
}


