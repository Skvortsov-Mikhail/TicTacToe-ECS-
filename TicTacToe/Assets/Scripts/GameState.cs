using Leopotam.Ecs;
using System.Collections.Generic;
using UnityEngine;

namespace TicTacToe
{
    public class GameState
    {
        public SignType CurrentType = SignType.Cross;

        public readonly Dictionary<Vector2Int, EcsEntity> Cells = new Dictionary<Vector2Int, EcsEntity>();
    }
}