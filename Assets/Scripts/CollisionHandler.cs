using UnityEngine;
using TMPro;

public class ColliderHandler : MonoBehaviour
{
    public TMP_Text PlayerText;
    public TMP_Text Player007Text;

    public string PlayerTag = "Player"; 
    public string Player007Tag = "Player007"; 

    private void Start()
    {
        if (PlayerText != null) PlayerText.text = "";
        if (Player007Text != null) Player007Text.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PlayerTag))
        {
            if (PlayerText != null) PlayerText.text = $"Entered: {PlayerTag}";
        }
        else if (other.CompareTag(Player007Tag))
        {
            if (Player007Text != null) Player007Text.text = $"Entered: {Player007Tag}";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(PlayerTag))
        {
            if (PlayerText != null) PlayerText.text = "";
        }
        else if (other.CompareTag(Player007Tag))
        {
            if (Player007Text != null) Player007Text.text = "";
        }
    }
}
