using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{ 
    public PlayerView playerView;
    public UIView uiView;
    [FormerlySerializedAs("pipeSpawnView")] public PipeView pipeView;
    private PlayerController _playerController;
    private UIController _uiController;
    private PipeController _pipeController;
    void Start()
    {
        _playerController = new PlayerController(playerView);
        _uiController = new UIController(uiView,playerView);
        _pipeController = new PipeController(pipeView,playerView);
        
    }
}
