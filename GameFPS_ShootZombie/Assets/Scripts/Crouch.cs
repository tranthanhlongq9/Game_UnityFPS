
using UnityEngine;

public class Crouch : MonoBehaviour
{
    private CharacterController m_CharacterController;
    private bool m_Crouch = false;
    private float m_OriginalHeicht;

    [SerializeField]private float m_CrouchlHeicht = 0.8f;

    public KeyCode crouchKey = KeyCode.C;


    void Start()
    {
        m_CharacterController = GetComponent<CharacterController>();
        m_OriginalHeicht = m_CharacterController.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(crouchKey))
        {
            m_Crouch = !m_Crouch;

            CheckCrouch();
        }
    }

    void CheckCrouch()
    {
        if (m_Crouch == true)
        {
            m_CharacterController.height = m_CrouchlHeicht;

        }
        else
        {
            m_CharacterController.height = m_OriginalHeicht;
        }
    }
}
