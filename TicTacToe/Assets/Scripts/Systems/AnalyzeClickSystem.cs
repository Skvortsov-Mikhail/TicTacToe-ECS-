using Leopotam.Ecs;

namespace TicTacToe
{
    public class AnalyzeClickSystem : IEcsRunSystem
    {
        private EcsFilter<Cell, Clicked>.Exclude<Taken> _filter;
        private GameState _gameState;

        public void Run()
        {
            foreach (var index in _filter)
            {
                ref var ecsEntity = ref _filter.GetEntity(index);

                ecsEntity.Get<Taken>().value = _gameState.CurrentType;
                ecsEntity.Get<CheckWinEvent>();

                _gameState.CurrentType = _gameState.CurrentType == SignType.Cross ? SignType.Ring : SignType.Cross;
            }
        }
    }
}