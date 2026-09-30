using UnityEngine;
using System.Collections;

public class TemporaryPanel : MonoBehaviour
{
    public GameObject panel;
    public float showTime = 3f;

    public void ShowPanel()
    {
        panel.SetActive(true);
        StartCoroutine(HidePanel());
    }

    IEnumerator HidePanel()
    {
        yield return new WaitForSeconds(showTime);
        panel.SetActive(false);
    }
}