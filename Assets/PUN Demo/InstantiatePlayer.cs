using Photon.Pun;
using UnityEngine;

namespace PUN_Demo
{
public class InstantiatePlayer : MonoBehaviourPun
{
    [SerializeField] private GameObject playerPrefab = null;
    
    private void Start()
    {
        var xPos = Random.Range(5f, -5f);
        var yPos = 4f;
        var zPos = Random.Range(5f, -5f);
        var playerPos = new Vector3(xPos, yPos, zPos);

        PhotonNetwork.Instantiate(playerPrefab.name, playerPos, Quaternion.identity );
    }
}
}
