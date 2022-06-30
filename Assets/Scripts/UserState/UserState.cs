using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.UI
{
    public class UserState : IState
    {
        #region Fields

        public enum StateType
        {
            Start = 0,
            SignInOrUp,
            Loby,
        }

        protected StateType _stateType;
        protected StateManager _stateManager;
        protected UserManager _userManager;
        public int ID { get { return (int)_stateType; } }

        #endregion

        #region Constructors

        public UserState(StateType StateType, UserManager UserManager)
        {
            _stateType = StateType;
            _userManager = UserManager;
            _stateManager = UserManager.StateManager;
        }

        #endregion

        #region Interface

        public virtual void Enter()
        {

        }

        public virtual void Update()
        {
            if (_stateManager.CheckTheProcess)
            {
                Proceed();
                _stateManager.CheckTheProcess = false;
            }
        }

        public virtual void Exit()
        {

        }

        public virtual void Proceed()
        {

        }

        #endregion
    }
}
