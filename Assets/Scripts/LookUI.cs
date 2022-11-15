using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookUI : MonoBehaviour
{
    #region Variable Serialization
    [SerializeField] LayerMask uiLayer = 0;

    Ray ray = new Ray();
    RaycastHit hit;
    Transform ownTransform;
    #endregion

    #region Properties

    #endregion

    #region Unity Methods
    private void OnDrawGizmosSelected()
    {
        if (Application.isPlaying)
        {
            Gizmos.DrawLine(ray.origin, ray.origin + ray.direction * 100f);
        }
    }

    private void Awake()
    {
        ownTransform = transform;
    }

    void FixedUpdate()
    {
        ray.origin = ownTransform.position;
        ray.direction = ownTransform.forward;

        if (Physics.Raycast(ray, out hit, 100f, uiLayer, QueryTriggerInteraction.Collide))
        {
            PlayerLookingAtPanelTrigger trigger = hit.collider.gameObject.GetComponent<PlayerLookingAtPanelTrigger>();

            if (trigger != null)
            {
                trigger.ActivatePanel();
            }
        }
    }
    #endregion

    #region Methods

    #endregion

    #region Coroutines

    #endregion
}