using JetBrains.Annotations;
using Verse;

namespace SirRandoo.ToolkitQuests
{
    [UsedImplicitly]
    public class TkQuests : Mod
    {
        internal static TkQuests Instance;

        public TkQuests(ModContentPack content) : base(content)
        {
            Instance = this;
        }

        public override string SettingsCategory()
        {
            return Content.Name;
        }
    }
}
