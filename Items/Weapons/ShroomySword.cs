using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace Temere.Items.Weapons
{
    public class ShroomySword : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Shroomy Sword";
            item.damage = 7;
            item.melee = true;
            item.width = 46;
            item.height = 46;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 1;
            item.knockBack = 5;
            item.rare = 0;
            item.value = 30;
            item.useSound = 1;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("ShroomSwordProj");
            item.shootSpeed = 6f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GlowingMushroom, 13);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}