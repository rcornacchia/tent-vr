using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeTrigger : MonoBehaviour
{
    private SteamVR_TrackedController _controller;
    public GameObject tent;

    private void OnEnable()
    {
        _controller = GetComponent<SteamVR_TrackedController>();

        if (_controller == null)
        {
            _controller = gameObject.AddComponent<SteamVR_TrackedController>();
        }

        _controller.TriggerClicked += HandleTriggerClicked;
        //_controller.MenuButtonClicked += HandleTriggerClicked;
        //_controller.MenuButtonUnclicked += HandleTriggerClicked;
        //_controller.TriggerUnclicked += HandleTriggerClicked;
        //_controller.SteamClicked += HandleTriggerClicked;
        //_controller.PadClicked += HandleTriggerClicked;
        //_controller.PadUnclicked += HandleTriggerClicked;
        _controller.PadTouched += HandlePadTouched;
        _controller.PadUntouched += HandlePadUntouched;
        //_controller.Gripped += HandleTriggerClicked;
        //_controller.Ungripped += HandleTriggerClicked;

    }

    private void OnDisable()
    {
        _controller.TriggerClicked -= HandleTriggerClicked;
    }

    #region Primitive Spawning
    private void HandleTriggerClicked(object sender, ClickedEventArgs e)
    {
        tent.GetComponent<Renderer>().material.color = Color.red;
    }

    private void HandlePadTouched(object sender, ClickedEventArgs e)
    {
        tent.GetComponent<Renderer>().material.color = Color.blue;
    }

    private void HandlePadUntouched(object sender, ClickedEventArgs e)
    {
        tent.GetComponent<Renderer>().material.color = Color.yellow;
    }

    #endregion
}
