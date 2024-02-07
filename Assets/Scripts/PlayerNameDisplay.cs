using UnityEngine;
using TMPro;

public class PlayerNameDisplay : MonoBehaviour
{
    [SerializeField] private Transform carTransform;
    [SerializeField] private TextMeshProUGUI playerNameText;

    void Update()
    {
        if (carTransform != null && playerNameText != null)
        {
        // Get the player's nickname from PUN 2
        // string playerName = PhotonNetwork.NickName;
            string playerName = "SEVA";

            playerNameText.text = playerName;

            playerNameText.transform.position = Camera.main.WorldToScreenPoint(carTransform.position);

            playerNameText.transform.rotation = carTransform.rotation;
        }
    }
}
