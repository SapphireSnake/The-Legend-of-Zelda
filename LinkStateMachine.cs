﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Legend_of_the_Power_Rangers
{
    public class LinkStateMachine
    {
        public enum LinkState
        {
            Left, Right, Up, Down, Attack,
            Item1, Item2, Item3, Item4, Item5
        }
        private LinkState currentState = LinkState.Right;
        private LinkState lastDirection = LinkState.Right;

        public void ChangeState(LinkState newState)
        {
            if (newState == LinkState.Attack)
            {
                ChangeAttackState();
            }
            else if (newState == LinkState.Item1 ||
                    newState == LinkState.Item2 || newState == LinkState.Item3 ||
                    newState == LinkState.Item4 || newState == LinkState.Item5)
            {
                ChangeItemState(newState);
            }
            else
            {
                if (newState != LinkState.Attack &&
                    !(newState == LinkState.Item1 || newState == LinkState.Item2 ||
                    newState == LinkState.Item3 || newState == LinkState.Item4 ||
                    newState == LinkState.Item5))
                {
                    lastDirection = newState;
                }
                currentState = newState;
                ChangeDirectionState();
            }
        }

        private void ChangeDirectionState()
        {
            switch (currentState)
            {
                case LinkState.Right:
                    break;
                case LinkState.Left:
                    //
                    break;
                case LinkState.Up:
                    break;
                case LinkState.Down:
                    break;
            }
            currentState = lastDirection;
        }

        private void ChangeAttackState()
            {
                switch(lastDirection)
                {
                    case LinkState.Right:
                        break;
                    case LinkState.Left:
                        break;
                    case LinkState.Up:
                        break;
                    case LinkState.Down:
                        break;
                }

            currentState = lastDirection;
            }
        private void ChangeItemState(LinkState itemState)
        {
            switch (lastDirection)
            {
                case LinkState.Right:
                    RightItemState(itemState);
                    break;
                case LinkState.Left:
                    LeftItemState(itemState);
                    break;
                case LinkState.Up:
                    UpItemState(itemState);
                    break;
                case LinkState.Down:
                    DownItemState(itemState);
                    break;
            }
            currentState = lastDirection;
        }

        private void LeftItemState(LinkState itemState)
        {
            switch (itemState)
            {
                case LinkState.Item1:
                    break;
                case LinkState.Item2:
                    break;
                case LinkState.Item3:
                    break;
                case LinkState.Item4:
                    break;
                case LinkState.Item5:
                    break;
            }
        }

        private void UpItemState(LinkState itemState)
        {
            switch (itemState)
            {
                case LinkState.Item1:
                    break;
                case LinkState.Item2:
                    break;
                case LinkState.Item3:
                    break;
                case LinkState.Item4:
                    break;
                case LinkState.Item5:
                    break;
            }
        }

        private void DownItemState(LinkState itemState)
        {
            switch (itemState)
            {
                case LinkState.Item1:
                    break;
                case LinkState.Item2:
                    break;
                case LinkState.Item3:
                    break;
                case LinkState.Item4:
                    break;
                case LinkState.Item5:
                    break;
            }
        }

        private void RightItemState(LinkState itemState)
        {
            switch (itemState)
            {
                case LinkState.Item1:
                    break;
                case LinkState.Item2:
                    break;
                case LinkState.Item3:
                    break;
                case LinkState.Item4:
                    break;
                case LinkState.Item5:
                    break;
            }
        }
    }
}
