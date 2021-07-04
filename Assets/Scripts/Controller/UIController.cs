using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController
{
    private PlayerView _playerView;
    private UIView _uiView;
    private UIModel _uiModel;
    public UIController(UIView uiView,PlayerView playerView)
    {
        _playerView = playerView;
        _uiView = uiView;
        _uiModel = new UIModel();
        playerView.OnScore = GetScore;
        playerView.OnDeathCollision = Death;
    }

    void GetScore()
    {
        _uiView.GetScore();
    }

    void Death()
    {
        _uiView.OnDeath();
    }
  
}
