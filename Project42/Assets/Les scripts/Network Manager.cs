using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    const string version = "0.1";
    public string roomName = "room";
    public string prefab = "Car"; //mettre le nom de l'objet (la voiture par exemple) je sais pas vraiment si ça change qq chose mais vaut mieux le faire
    public Transform SpawnPoint;

	void Start ()
    {
        PhotonNetwork.ConnectUsingSettings(version); //http://doc.photonengine.com/en/pun/current/tutorials/tutorial-marco-polo
    }

    void OnjoinedLobby()
    {
        RoomOptions roomOptions = new RoomOptions() { isVisible = false, maxPlayers = 4 }; //http://doc.photonengine.com/en/pun/current/tutorials/matchmaking-and-lobby
        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
    }

    void Onjoinedroom()
    {
        PhotonNetwork.Instantiate(prefab, SpawnPoint.position, SpawnPoint.rotation,0); //depend du fichier resources, pour plus d'informations voir : http://doc.photonengine.com/en/pun/current/tutorials/instantiation
    }
}
