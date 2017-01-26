using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Temere.NPCs
{
    public class HellChefDrop_Spice : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Spice";
            item.width = 28;
            item.height = 14;
            item.maxStack = 99;
            AddTooltip("Hot hot hot!");
            item.value = 300;
            item.rare = 2;
        }
    }
}