﻿using Leopotam.Ecs;

namespace TicTacToe
{
    public class CheckWinSystem : IEcsRunSystem
    {
        private EcsFilter<Position, Taken, CheckWinEvent> _filter;
        private GameState _gameState;
        private Configuration _configuration = null;

        public void Run()
        {
            foreach (var index in _filter)
            {
                ref var position = ref _filter.Get1(index);
                ref var type = ref _filter.Get2(index);

                var chainLength = _gameState.Cells.GetLongestChain(position.value);

                if (chainLength >= _configuration.ChainLength)
                {
                    _filter.GetEntity(index).Get<Winner>();
                }
            }
        }
    }
}