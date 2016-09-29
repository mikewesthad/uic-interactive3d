using UnityEngine;

namespace ClassUtilities {

	// For class demo only!
	// This overrides Unity's Debug.Log so that it displays larger.
	public static class Debug {
		public static void Log(object message, int size = 23) {
			UnityEngine.Debug.Log("<size=" + size +">" + message.ToString() + 
				"</size>");
		}
	}

}

