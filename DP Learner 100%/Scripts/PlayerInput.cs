using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Action<Vector2> OnMovementInput;
    public Action<Vector3> OnMovementDirectionInput;
    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        GetMovementInput();
        GetMovementDirection();
    }
    private void GetMovementInput()
    {
        throw new NotImplementedException();
    }
    private void GetMovementDirection()
    {
        /*bool inputkeyfr = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        float inputkeyfrl = Convert.ToSingle(inputkeyfr);
        bool inputkeybk = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        float inputkeybkl = Convert.ToSingle(inputkeybk);
        bool inputkeyrg = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
        float inputkeyrgl = Convert.ToSingle(inputkeyrg);*/
        Vector2 input = new Vector2();
        OnMovementInput?.Invoke(input);
    }
}
