using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController
{
    private PipeView _pipeView;
    private PipeModel _pipeModel;
    
    public PipeController(PipeView pipeView,PlayerView playerView)
    {
        _pipeView = pipeView;
        _pipeModel = new PipeModel();

        SetInstantiateRate(_pipeModel.Rate);
        _pipeView.Tick += InstantiatePipe;
    }

    void InstantiatePipe()
    {
        _pipeView.InstantiatePipe(_pipeModel.Speed,_pipeModel.Lifetime);
    }

    void SetInstantiateRate(float rate)
    {
        _pipeView.Rate = rate;
    }

    // void StopPipes()
    // {
    //     _pipeSpawnView.StopPipes();
    // }
}
