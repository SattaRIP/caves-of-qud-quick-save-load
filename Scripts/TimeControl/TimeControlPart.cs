using System;
using XRL;
using XRL.World;
using XRL.World.Parts;

namespace TimeControl
{
    [Serializable]
    public class TimeControlPart : IPlayerPart
    {
        public override void Register(GameObject go, IEventRegistrar registrar)
        {
            registrar.Register(CommandEvent.ID);
            base.Register(go, registrar);
        }

        public override bool HandleEvent(CommandEvent e)
        {
            var cmd = e.Command;

            if (cmd == "TimeControl_QuickSave")
            {
                QuickSaveManager.QuickSave();
                return false;
            }

            if (cmd == "TimeControl_QuickLoad")
            {
                QuickSaveManager.QuickLoad();
                return false;
            }

            return base.HandleEvent(e);
        }
    }
}
