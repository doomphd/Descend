using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel_Current;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }

        if (Panel_Current != null)
        {
            bool isActive2 = Panel_Current.activeSelf;
            Panel_Current.SetActive(!isActive2);
        }
    }
}
