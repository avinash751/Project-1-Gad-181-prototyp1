using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PlayerInputs",menuName ="PlayerInputs ScriptableObjects")]

public class PlayerInputs :ScriptableObject
{
    public bool only_W_KeyPressed;
    public bool only_S_KeyPressed;
    public bool only_A_KeyPressed;
    public bool only_D_KeyPressed;
    public bool only_Space_KeyPressed;
    public bool W_Shift_KeyPressed;

    // Start is called before the first frame update

    private void OnEnable()
    {
        only_W_KeyPressed = false;
        only_S_KeyPressed = false;
        only_A_KeyPressed = false;
        only_D_KeyPressed = false;
        only_Space_KeyPressed = false;
        W_Shift_KeyPressed = false;
    }

    public bool W_Key()
    {
        if(Input.GetKey(KeyCode.W))
        {
            only_W_KeyPressed = true;
            return only_W_KeyPressed;
        }
        else
        {
            only_W_KeyPressed = false;
            return only_W_KeyPressed;
        }
    }

    public bool S_Key()
    {
        if (Input.GetKey(KeyCode.S))
        {
            only_S_KeyPressed = true;
            return only_S_KeyPressed;
        }
        else
        {
            only_S_KeyPressed = false;
            return only_S_KeyPressed;
        }
    }

    public bool A_Key()
    {
        if (Input.GetKey(KeyCode.A))
        {
            only_A_KeyPressed = true;
            return only_A_KeyPressed;
        }
        else
        {
            only_A_KeyPressed = false;
            return only_A_KeyPressed;
        }
    }
    public bool D_Key()
    {
        if (Input.GetKey(KeyCode.D))
        {
            only_D_KeyPressed = true;
            return only_D_KeyPressed;
        }
        else
        {
            only_D_KeyPressed = false;
            return only_D_KeyPressed;
        }
    }
    public bool Space_Key()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            only_Space_KeyPressed = true;
            return only_Space_KeyPressed;
        }
        else
        {
            only_Space_KeyPressed = false;
            return only_Space_KeyPressed;
        }
    }

    public bool W_And_Shift_Key()
    {
        if (Input.GetKey(KeyCode.D))
        {
            W_Shift_KeyPressed = true;
            return W_Shift_KeyPressed;
        }
        else
        {
            W_Shift_KeyPressed = false;
            return W_Shift_KeyPressed;
        }
    }





}
