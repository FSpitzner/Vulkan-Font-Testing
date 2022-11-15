using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerLookingAtPanelTrigger : MonoBehaviour
{
    #region Variable Serialization
    [SerializeField] Canvas panelToControl = null;
    [SerializeField] List<Image> images = new List<Image>();
    [SerializeField] List<TextMeshProUGUI> textMeshes = new List<TextMeshProUGUI>();

    private int framesWithoutContact = 0;
    bool active = false;
    #endregion

    #region Properties

    #endregion

    #region Unity Methods
    private void Update()
    {
        if(framesWithoutContact < 10)
            framesWithoutContact++;

        if (framesWithoutContact == 10)
        {
            active = false;
            framesWithoutContact = 11;
            panelToControl.enabled = false;

            ChangeStaticPanelState(false);
        }
    }
    #endregion

    #region Methods
    public void ActivatePanel()
    {
        framesWithoutContact = 0;

        if (!active)
        {
            panelToControl.enabled = true;

            ChangeStaticPanelState(true);
        }
            
        active = true;
    }

    private void ChangeStaticPanelState(bool enabled)
    {
        foreach (TextMeshProUGUI tmp in textMeshes)
        {
            tmp.enabled = enabled;
        }

        foreach (Image i in images)
        {
            i.enabled = enabled;
        }
    }
    #endregion

    #region Coroutines

    #endregion
}