﻿using UnityEngine;
using System.Collections;
using Lockstep.Data;
namespace Lockstep.Example {
    public class ExampleGameManager : GameManager {
        [SerializeField]
        private AgentCode _spawnCode;
        [SerializeField]
        private int _spawnAmount;

        private NetworkHelper _mainNetworkHelper = new ExampleNetworkHelper ();
        public override NetworkHelper MainNetworkHelper {
            get {
                return _mainNetworkHelper;
            }
        }

        protected override void Startup () {

        }

        protected override void OnStartGame () {
            for (int i = 0; i < _spawnAmount; i++) {
                AgentController ac = new AgentController();
                PlayerManager.AddController (ac);
                ac.CreateAgent (_spawnCode,Vector2d.zero);
            }
        }
    }
}