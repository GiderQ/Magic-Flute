using UnityEngine;
using TMPro;
public class CheckInfo : MonoBehaviour
{
    string infoText;
    bool Active;
    public TextMeshProUGUI windowText;
    public GameObject DialogeWindow,DialogeInfo;
    void Update()
    {
        if (Active && Input.GetKeyDown(KeyCode.E))
        {
            DialogeWindow.SetActive(true);
            TextMeshProUGUI DialogeText = DialogeInfo.gameObject.GetComponentInChildren<TextMeshProUGUI>();
            DialogeText.text = infoText;
        }
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.transform.tag == "Object")
        {
            InfoObject infoObject = other.gameObject.GetComponent<InfoObject>();
            infoText = infoObject.info;
            Active = true;
            Debug.Log(infoText);
        }
    }
}
