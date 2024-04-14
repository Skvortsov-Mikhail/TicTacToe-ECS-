using Leopotam.Ecs;

namespace TicTacToe
{
    public class WinSystem : IEcsRunSystem
    {
        private EcsFilter<Winner, Taken> _filter;
        private SceneData _sceneData = null;

        public void Run()
        {
            if (_sceneData.UI.WinScreen.gameObject.activeSelf) return;

            foreach (var index in _filter)
            {
                ref var winnerType = ref _filter.Get2(index);

                _sceneData.UI.WinScreen.Show(true);
                _sceneData.UI.WinScreen.SetWinner(winnerType.value);

                _filter.GetEntity(index).Del<Winner>();
            }
        }
    }
}