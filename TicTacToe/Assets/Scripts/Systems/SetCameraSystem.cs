using Leopotam.Ecs;
using UnityEngine;

namespace TicTacToe
{
    public class SetCameraSystem : IEcsRunSystem
    {
        private EcsFilter<UpdateCameraEvent> _filter;
        private SceneData _sceneData = null;
        private Configuration _configuration = null;

        public void Run()
        {
            if(!_filter.IsEmpty()) 
            {
                var height = _configuration.FieldHeight;

                var camera = _sceneData.Camera;
                camera.orthographic = true;
                camera.orthographicSize = height / 2f + (height - 1) * _configuration.Offset.y / 2;

                _sceneData.CameraTransform.position = new Vector3(_configuration.FieldWidth / 2f + (_configuration.FieldWidth - 1) * _configuration.Offset.x / 2, height / 2f + (height - 1) * _configuration.Offset.y / 2);
            }
        }
    }
}