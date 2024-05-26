using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    public GameObject panelresikorendah;
    public GameObject panelterancam;
    public GameObject panelkritis;

    private GameObject activePanel;

    void Start()
    {
        panelresikorendah.SetActive(false);
        panelterancam.SetActive(false);
        panelkritis.SetActive(false);
    }

    void ActivatePanel(GameObject panel)
    {
        if (activePanel == panel)
        {
            activePanel.SetActive(false);
            activePanel = null;
        }
        else
        {
            if (activePanel != null)
                activePanel.SetActive(false);

            activePanel = panel;
            activePanel.SetActive(true);
        }
    }

    public void resikorendah()
    {
        ActivatePanel(panelresikorendah);
    }

    public void terancam()
    {
        ActivatePanel(panelterancam);
    }

    public void kritis()
    {
        ActivatePanel(panelkritis);
    }
}
