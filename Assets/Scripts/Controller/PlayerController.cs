using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerView _view;
    private PlayerModel _model;
    public GameObject deathPanel;
    public PlayerController(PlayerView view)
    {
        _view = view;
        _view.OnJump += Jump;

        _model = new PlayerModel();

    }

    private void Jump()
    {
        _view.Jump(_model.JumpForce);
    }


}
