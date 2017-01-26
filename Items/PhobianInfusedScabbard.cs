using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Temere.Items
{
    public class PhobianInfusedScabbard : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Phobian Infused Scabbard";
            item.width = 40;
            item.height = 28;
            item.toolTip = "Nightmares swirl around your waist";
            item.toolTip2 = "+8% Melee damage";
            item.value = 550;
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player)
        {
            player.meleeDamage += 0.08f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Vertebrae, 10);
            recipe.AddIngredient(null, "NightmareBar", 4);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
  