using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Temere.Items.Weapons
{
    public class NightSlasher : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Night Slasher";
            item.damage = 20;
            item.melee = true;
            item.width = 62;
            item.height = 62;
            item.toolTip = "May cause bed-wetting";
            item.useTime = 35;
            item.useAnimation = 35;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 500;
            item.rare = 2;
            item.useSound = 1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "NightmareBar", 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
        