﻿using UnityEngine;

namespace ET
{
    namespace EventType
    {
        public struct AppStart
        {
        }

        public struct SceneChangeStart
        {
            public Scene ZoneScene;
        }
        
        
        public struct SceneChangeFinish
        {
            public Scene ZoneScene;
            public Scene CurrentScene;
        }


        
        public class ChangePosition: DisposeObject
        {
            public static readonly ChangePosition Instance = new ChangePosition();
                    
            public Unit Unit;
            public WrapVector3 OldPos = new WrapVector3();

            // 因为是重复利用的，所以用完PublishClass会调用Dispose
            public override void Dispose()
            {
                this.Unit = null;
            }
        }
 

        public class ChangeRotation: DisposeObject
        {
            public static readonly ChangeRotation Instance = new ChangeRotation();
            
            public Unit Unit;
        
               // 因为是重复利用的，所以用完PublishClass会调用Dispose
            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        public struct PingChange
        {
            public Scene ZoneScene;
            public long Ping;
        }
        
        public struct AfterCreateZoneScene
        {
            public Scene ZoneScene;
        }
        
        public struct AfterCreateCurrentScene
        {
            public Scene CurrentScene;
        }
        
        public struct AfterCreateLoginScene
        {
            public Scene LoginScene;
        }

        public struct AppStartInitFinish
        {
            public Scene ZoneScene;
        }

        public struct LoginFinish
        {
            public Scene ZoneScene;
        }

        public struct LoadingBegin
        {
            public Scene Scene;
        }

        public struct LoadingFinish
        {
            public Scene Scene;
        }

        public struct EnterMapFinish
        {
            public Scene ZoneScene;
        }

        public struct AfterUnitCreate
        {
            public Unit Unit;
        }
        
        public struct MoveStart
        {
            public Unit Unit;
        }

        public struct MoveStop
        {
            public Unit Unit;
        }

        public struct UnitEnterSightRange
        {
        }
        
        public struct StartGameLevel
        {
            public Scene ZoneScene;
        }
        
        public struct AdventureBattleRound
        {
            public Scene ZoneScene;
            public Unit AttackUnit;
            public Unit TargetUnit;
        }
        public struct AdventureBattleRoundView
        {
            public Scene ZoneScene;
            public Unit AttackUnit;
            public Unit TargetUnit;
        }


        public struct AdventureBattleOver
        {
            public Scene ZoneScene;
            public Unit WinUnit;
        }
        
        public struct AdventureBattleReport
        {
            public Scene ZoneScene;
            public BattleRoundResult BattleRoundResult;
            public int Round;
        }
        
        public struct AdventureRoundReset
        {
            public Scene ZoneScene;
        }
        
        public struct ShowDamageValueView
        {
            public Scene ZoneScene;
            public Unit TargetUnit;
            public long DamamgeValue;
        }
        
        public class ShowAdventureHpBar : DisposeObject
        {
            public static readonly ShowAdventureHpBar Instance = new ShowAdventureHpBar();
            public Unit Unit;
            public bool isShow;
            
            public override void Dispose()
            {
                this.Unit = null;
            }
        }
        
        
        public struct ExpChange
        {
            public Scene ZoneScene;
            public bool isEnoughUpLevel;
        }
        
        public class MakeQueueOver : DisposeObject
        {
            public static readonly MakeQueueOver Instance = new MakeQueueOver();

            public Scene ZoneScene;
            
            public override void Dispose()
            {
                this.ZoneScene = null;
            }
        }
        
        public struct UpdateTaskInfo
        {
            public Scene ZoneScene;
        }
        
        public struct UpdateChatInfo
        {
            public Scene ZoneScene;
        }
        
    }
}