using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Temere.NPCs
{
    public class NightmareDrop_NightmareFuel : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Nightmare Fuel";
            item.width = 18;
            item.height = 26;
            item.maxStack = 99;
            item.toolTip = "Welcome to my nightmare.";
            item.value = 50;
            item.rare = 0;
        }
    }
}
