using XRL;
using XRL.World;
using XRL.World.Parts;

namespace TimeControl
{
    [HasCallAfterGameLoaded]
    public class LoadGameHandler
    {
        [CallAfterGameLoaded]
        public static void AfterLoaded()
        {
            if (The.Player == null) return;

            // Ensure TimeControlPart is attached to player
            The.Player.RequirePart<TimeControlPart>();
        }
    }

    [PlayerMutator]
    public class NewCharacterHandler : IPlayerMutator
    {
        public void mutate(GameObject player)
        {
            // Attach part to new characters
            player.RequirePart<TimeControlPart>();
        }
    }
}
