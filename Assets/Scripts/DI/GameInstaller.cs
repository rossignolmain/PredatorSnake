﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private Snake _snake;
    [SerializeField] private GemCountUI _gemCount;
    [SerializeField] private HumanCountUI _humanCount;
    [SerializeField] private LevelResultUI _levelResult;
    [SerializeField] private LevelExit _exit;

    public override void InstallBindings()
    {
        Container.Bind<Snake>().FromInstance(_snake).AsSingle();
        Container.Bind<GemCountUI>().FromInstance(_gemCount).AsSingle();
        Container.Bind<HumanCountUI>().FromInstance(_humanCount).AsSingle();
        Container.Bind<LevelResultUI>().FromInstance(_levelResult).AsSingle();
        Container.Bind<LevelExit>().FromInstance(_exit).AsSingle();
    }
}
