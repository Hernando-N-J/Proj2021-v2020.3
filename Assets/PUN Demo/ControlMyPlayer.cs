using Cinemachine;
using Photon.Pun;
using StarterAssets;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace PUN_Demo
{
    public class ControlMyPlayer: MonoBehaviourPun
    {

        [SerializeField] private PhotonView phView;
        [SerializeField] private GameObject followCam;
        [SerializeField] private GameObject uiEventSys;
        [SerializeField] private GameObject mainCam;

        private void Start()
		{
			phView = GetComponent<PhotonView>();
			if(phView.IsMine) return;
			
			followCam.GetComponent<CinemachineVirtualCamera>().enabled = false;
			followCam.SetActive(false);

			mainCam.GetComponent<Camera>().enabled = false;
			mainCam.GetComponent<AudioListener>().enabled = false;
			mainCam.GetComponent<CinemachineBrain>().enabled = false;

			uiEventSys.GetComponent<EventSystem>().enabled = false;
			uiEventSys.GetComponent<InputSystemUIInputModule>().enabled = false;

			GetComponent<ThirdPersonController>().enabled = false;
			GetComponent<CharacterController>().enabled = false;
			GetComponent<PlayerInput>().enabled = false;
		}
	}
}
