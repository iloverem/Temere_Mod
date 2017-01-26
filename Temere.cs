using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Temere.Items;
using Temere.Items.Armor;
using Temere.NPCs;

namespace Temere {
  public class TemereMod : Mod
  {
    public override void SetModInfo(out string name, ref ModProperties properties)
    {
      name = "Temere Mod";
      properties.Autoload = true;
    }
  }
}
