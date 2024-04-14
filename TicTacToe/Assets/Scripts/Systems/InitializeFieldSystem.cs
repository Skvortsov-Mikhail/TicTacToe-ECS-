using Leopotam.Ecs;
using UnityEngine;

namespace TicTacToe
{
    public class InitializeFieldSystem : IEcsInitSystem
    {
        private Configuration _configuration = null;
        private EcsWorld _world;
        private GameState _gameState;

        public void Init()
        {
            for (int x = 0; x < _configuration.FieldWidth; x++)
            {
                for (int y = 0; y < _configuration.FieldHeight; y++)
                {
                    var cellEntity = _world.NewEntity();
                    cellEntity.Get<Cell>();

                    var position = new Vector2Int(x, y);
                    cellEntity.Get<Position>().value = position;

                    _gameState.Cells[position] = cellEntity;
                }
            }

            _world.NewEntity().Get<UpdateCameraEvent>();
        }
    }
}