﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.UI;


public class Hand : MonoBehaviour
{

    public SteamVR_Action_Boolean m_GrabAction = null;

    private SteamVR_Behaviour_Pose m_Pose = null;
    private FixedJoint m_Joint = null;

    private Interactable m_CurrentInteractable = null;
    private List<Interactable> m_ContactInteractables = new List<Interactable>();
    // Start is called before the first frame update
    private void Awake()
    {
        m_Pose = GetComponent<SteamVR_Behaviour_Pose>();
        m_Joint = GetComponent<FixedJoint>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Down
        if (m_GrabAction.GetStateDown(m_Pose.inputSource))
        {
            print(m_Pose.inputSource + "Trigger Down");
            Pickup();
        }

        //Up
        if (m_GrabAction.GetStateUp(m_Pose.inputSource))
        {
            print(m_Pose.inputSource + "Trigger Up");
            Drop();
        }

        void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.CompareTag("Interactable"))
                return;

            m_ContactInteractables.Add(other.gameObject.GetComponent<Interactable>());

        }

        void OnTriggerExit(Collider other)
        {
            if (!other.gameObject.CompareTag("Interactable"))
                return;

            m_ContactInteractables.Remove(other.gameObject.GetComponent<Interactable>());
        }

        void Pickup()
        {

        }

        void Drop()
        {

        }

        Interactable GetNearestInteractable()
        {
            return null;

        }

    }
}
