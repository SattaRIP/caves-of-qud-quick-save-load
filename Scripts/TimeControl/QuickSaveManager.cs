using System;
using XRL;
using XRL.UI;

namespace TimeControl
{
    public static class QuickSaveManager
    {
        public static void QuickSave()
        {
            try
            {
                if (The.Game == null)
                {
                    Popup.ShowFail("No active game to save!");
                    return;
                }

                The.Game.Checkpoint();
                Popup.Show("{{G|Quick saved!}}");
            }
            catch (Exception ex)
            {
                Popup.ShowFail("Quick save failed: " + ex.Message);
            }
        }

        public static void QuickLoad()
        {
            try
            {
                if (The.Game == null)
                {
                    Popup.ShowFail("No active game to load!");
                    return;
                }

                The.Game.RestoreCheckpoint();
                Popup.Show("{{C|Quick loaded!}}");
            }
            catch (Exception ex)
            {
                Popup.ShowFail("Quick load failed: " + ex.Message);
            }
        }
    }
}
