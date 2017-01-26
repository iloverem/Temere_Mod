using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Temere.Items.Weapons
{
    public class GlowingMushroomHammer : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Glowing mushroom hammer";
            item.damage = 5;
            item.melee = true;
        //    item.width = ;
         //   item.height = ;
            item.useTime = 27;
            item.useAnimation = 27;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 50;
            item.rare = 0;
            item.useSound = 1;
            item.autoReuse = true;
            item.hammer = 15;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GlowingMushroom, 8);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
