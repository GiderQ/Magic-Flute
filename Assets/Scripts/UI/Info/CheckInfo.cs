using UnityEngine;
using TMPro;
public class CheckInfo : MonoBehaviour
{
    string infoText;
    public TMPro.TextMeshPro windowText;
    void Start()
    {

    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.transform.tag == "object")
        {
            InfoObject infoObject = other.gameObject.GetComponent<InfoObject>();
            infoObject.info = infoText;

            Debug.Log("OnCollisionStay! object ");
        }
    }
}
