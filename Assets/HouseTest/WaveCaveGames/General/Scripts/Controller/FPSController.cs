using UnityEngine;

namespace WaveCaveGames{
	
	public class FPSController : MonoBehaviour {

		public int speed = 5;
		[Tooltip("Camera Rotate Sensitivity")]
		public float cameraRotateSensitivity = 150f;
		private CharacterController controller;
		private Transform playerCam;

		void Start(){
			
		}
		void Update () {
			float hor = Input.GetAxis("Horizontal");
			float ver = Input.GetAxis("Vertical");
			//rotate camera
		}
	}
}
