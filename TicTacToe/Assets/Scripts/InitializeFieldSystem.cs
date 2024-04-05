using Leopotam.Ecs;
using UnityEngine;

namespace TicTacToe
{
    public class InitializeFieldSystem : IEcsInitSystem
    {
        private Configuration _configuration;
        private EcsWorld _world;

        public void Init()
        {
            for (int x = 0; x < _configuration.FieldWidth; x++)
            {
                for (int y = 0; y < _configuration.FieldHeight; y++)
                {
                    var cellEntity = _world.NewEntity();
                    cellEntity.Get<Cell>();
                    cellEntity.Get<Position>().value = new Vector2Int(x, y);
                }
            }

            _world.NewEntity().Get<UpdateCameraEvent>();
        }
    }
}